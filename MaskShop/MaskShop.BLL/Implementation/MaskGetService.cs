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
    public class MaskGetService : IMaskGetService
    {
        private IMaskDataAccess maskDataAccess { get; }

        public MaskGetService(IMaskDataAccess maskDataAccess)
        {
            this.maskDataAccess = maskDataAccess;
        }

        public Task<IEnumerable<Mask>> GetAsync()
        {
            return this.maskDataAccess.GetAsync();
        }

        public Task<Mask> GetAsync(IMaskIdentity mask)
        {
            return this.maskDataAccess.GetAsync(mask);
        }
    }
}
