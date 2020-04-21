using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using MaskShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.DataAccess.Contracts
{
    public interface IMaskDataAccess
    {
        Task<Mask> InsertAsync(MaskUpdateModel mask);
        Task<IEnumerable<Mask>> GetAsync();
        Task<Mask> GetAsync(IMaskIdentity mask);
        Task<Mask> UpdateAsync(MaskUpdateModel mask);
    }
}
