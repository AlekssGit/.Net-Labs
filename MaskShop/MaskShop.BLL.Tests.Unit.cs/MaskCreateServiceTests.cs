using AutoFixture;
using FluentAssertions;
using MaskShop.BLL.Contracts;
using MaskShop.BLL.Implementation;
using MaskShop.DataAccess.Contracts;
using MaskShop.Domain.Models;
using MaskShop.Domain;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace MaskShop.BLL.Tests.Unit
{
    public class MaskCreateServiceTests
    {
        [Test]
        public async Task CreateAsync_CategoryValidationSucceed_CreateMask()
        {
            //Arrange
            var mask = new MaskUpdateModel();
            var expected = new Mask();

            var categoryGetService = new Mock<ICategoryGetService>();
            categoryGetService.Setup(x => x.ValidateAsync(mask));

            var maskDataAccess = new Mock<IMaskDataAccess>();
            maskDataAccess.Setup(x => x.InsertAsync(mask)).ReturnsAsync(expected);

           

            var maskGetService = new MaskCreateService(maskDataAccess.Object, categoryGetService.Object);

            //Act
            var result = await maskGetService.CreateAsync(mask);

            //Assert
            result.Should().Be(expected);
        }

        [Test]
        public async Task CreateAsync_CategoryValidationFailed_ThrowsError()
        {
            //Arrange
            var fixture = new Fixture();
            var mask = new MaskUpdateModel();
            var expected = fixture.Create<string>();

            var categoryGetService = new Mock<ICategoryGetService>();
            categoryGetService.Setup(x => x.ValidateAsync(mask)).Throws(new InvalidOperationException(expected));

            var maskDataAccess = new Mock<IMaskDataAccess>();

            var maskGetService = new MaskCreateService(maskDataAccess.Object, categoryGetService.Object);

            //Act
            var action = new Func<Task>(() => maskGetService.CreateAsync(mask));

            //Assert
            await action.Should().ThrowAsync<InvalidOperationException>().WithMessage(expected);
            maskDataAccess.Verify(x => x.InsertAsync(mask), Times.Never);
        }
    }
}
