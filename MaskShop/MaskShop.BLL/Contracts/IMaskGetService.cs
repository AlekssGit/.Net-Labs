using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.BLL.Contracts
{
    public interface IMaskGetService
    {
        Task<IEnumerable<Mask>> GetAsync();
        Task<Mask> GetAsync(IMaskIdentity mask);
    }
}
