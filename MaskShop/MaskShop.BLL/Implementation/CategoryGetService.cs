using MaskShop.BLL.Contracts;
using MaskShop.DataAccess.Contracts;
using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.BLL.Implementation
{
    public class CategoryGetService : ICategoryGetService
    {
        private ICategoryDataAccess CategoryDataAccess;

        public CategoryGetService(ICategoryDataAccess CategoryDataAccess)
        {
            this.CategoryDataAccess = CategoryDataAccess;
        }


        public async Task ValidateAsync(ICategoryContainer categoryContainer)
        {
            if(categoryContainer == null)
            {
                throw new ArgumentNullException(nameof(categoryContainer));
            }

            var category = await this.GetBy(categoryContainer);
            
            if(categoryContainer.CategoryId.HasValue && category == null)
            {
                throw new InvalidOperationException($"Category not found by id {categoryContainer.CategoryId}");
            }
        }

        private async Task<Category> GetBy(ICategoryContainer categoryContainer)
        {
            return await this.CategoryDataAccess.GetByAsync(categoryContainer);
        }
    }
}
