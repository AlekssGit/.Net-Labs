using FluentAssertions;
using MaskShop.BLL.Implementation;
using MaskShop.DataAccess.Contracts;
using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace MaskShop.BLL.Tests.Unit.cs
{ 
    [TestFixture]
    public class CategoryGetServiceTests
    {
        [Test]
        public async Task ValidateAsync_DepartmentExists_DoesNothing()
        {
            // Arrange
            var categoryContainer = new Mock<ICategoryContainer>();

            var category = new Category();
            var categoryDataAccess = new Mock<ICategoryDataAccess>();
            categoryDataAccess.Setup(x => x.GetByAsync(categoryContainer.Object)).ReturnsAsync(category);

            var categoryGetService = new CategoryGetService(categoryDataAccess.Object);

            // Act
            var action = new Func<Task>(() => categoryGetService.ValidateAsync(categoryContainer.Object));

            // Assert
            await action.Should().NotThrowAsync<Exception>();
        }
    }
}
