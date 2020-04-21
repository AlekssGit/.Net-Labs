using MaskShop.BLL.Contracts;
using MaskShop.Domain;
using MaskShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.BLL.Implementation
{
    public class MaskUpdateService : IMaskUpdateService
    {
        private IMaskDataAccess maskDataAccess { get; }
        private ICategoryGetService categoryGetService { get; }

        public MaskUpdateService(IMaskDataAccess maskDataAccess, ICategoryGetService categoryGetService)
        {
            this.maskDataAccess = maskDataAccess;
            this.categoryGetService = categoryGetService;
        }

        public async Task<Mask> UpdateAsync(MaskUpdateModel mask)
        {
            await this.categoryGetService.ValidateAsync(mask);

            return await this.maskDataAccess.UpdateAsync(mask);
        }
    }
}
