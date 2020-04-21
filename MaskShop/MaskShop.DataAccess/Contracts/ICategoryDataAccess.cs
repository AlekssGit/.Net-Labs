using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.DataAccess.Contracts
{
    public interface ICategoryDataAccess
    {
        Task<Category> GetByAsync(ICategoryContainer category);
    }
}
