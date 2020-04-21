using AutoMapper;
using MaskShop.DataAccess.Context;
using MaskShop.DataAccess.Contracts;
using MaskShop.Domain;
using MaskShop.Domain.Contracts;
using MaskShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaskShop.DataAccess.Implementations
{
    public class MaskDataAccess : IMaskDataAccess
    {
        private MaskDirectoryContext context { get; }
        private IMapper mapper { get; }

        public MaskDataAccess(MaskDirectoryContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<Mask>> GetAsync()
        {
            return this.mapper.Map<IEnumerable<MaskShop.Domain.Mask>>(
                await this.context.Mask.Include(x => x.Category).ToListAsync());
        }

        public async Task<MaskShop.Domain.Mask> GetAsync(IMaskIdentity mask)
        {
            var result = await this.Get(mask);

            return this.mapper.Map<MaskShop.Domain.Mask>(result);
        }

        private async Task<MaskShop.DataAccess.Entities.Mask> Get(IMaskIdentity mask)
        {
            if(mask == null)
            {
                throw new ArgumentNullException(nameof(mask));
            }
            
            return await this.context.Mask.Include(x => x.Category).FirstOrDefaultAsync(d => d.id == mask.Id );
        }

        public async Task<Mask> InsertAsync(MaskUpdateModel mask)
        {
            var result = await this.context.AddAsync(this.mapper.Map<Mask>(mask));

            await this.context.SaveChangesAsync();

            return this.mapper.Map<Mask>(result.Entity);
        }

        public async Task<MaskShop.Domain.Mask> UpdateAsync(MaskUpdateModel mask)
        {
            var existing = await this.Get(mask);
            var result = this.mapper.Map(mask, existing);
            this.context.Update(result);
            await this.context.SaveChangesAsync();

            return this.mapper.Map<MaskShop.Domain.Mask>(result);
        }
    }
}
