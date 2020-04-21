using MaskShop.BLL.Contracts;
using MaskShop.Domain;
using MaskShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MaskShop.BLL.Implementation
{
    public class MaskCreateService : IMaskCreateService
    {
        private IMaskDataAccess maskDataAccess { get; }
        private ICategoryGetService categoryGetService { get; }

        public MaskCreateService(IMaskDataAccess maskDataAccess, ICategoryGetService categoryGetService )
        {
            this.maskDataAccess = maskDataAccess;
            this.categoryGetService = categoryGetService;
        }


        public async Task<Mask> CreateAsync(MaskUpdateModel mask)
        {
            await this.categoryGetService.ValidateAsync(mask);

            return await this.maskDataAccess.InsertAsync(mask);
        }
    }
}
