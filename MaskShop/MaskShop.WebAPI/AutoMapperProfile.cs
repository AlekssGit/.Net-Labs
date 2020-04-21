using AutoMapper;
using MaskShop.Client.DTO.Read;
using MaskShop.Client.Requests.Create;
using MaskShop.Client.Requests.Update;
using MaskShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.WebAPI
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<DataAccess.Entities.Mask, Domain.Mask>();
            this.CreateMap<DataAccess.Entities.Category, Domain.Mask>();
            this.CreateMap<Domain.Mask, MaskDTO>();
            this.CreateMap<Domain.Category, CategoryDTO>();
            this.CreateMap<MaskCreateDTO, MaskUpdateModel>();
            this.CreateMap<MaskUpdateDTO, MaskUpdateModel>();
            this.CreateMap<MaskUpdateModel, MaskShop.DataAccess.Entities.Mask>();
        }
    }
}
