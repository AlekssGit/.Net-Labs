using AutoMapper;
using MaskShop.DataAccess.Context;
using MaskShop.DataAccess.Contracts;
using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.DataAccess.Implementations
{
    public class CategoryDataAccess : ICategoryDataAccess
    {
        private MaskDirectoryContext Context { get; }
        private IMapper Mapper { get; }

        public CategoryDataAccess(MaskDirectoryContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.Context = context;
        }

        public async Task<Category> GetByAsync(ICategoryContainer category)
        {
            return category.CategoryId.HasValue ? this.Mapper.Map<Category>(await this.Context.Category.FirstOrDefaultAsync(x => x.id == category.CategoryId)):null;
        }
    }
}
