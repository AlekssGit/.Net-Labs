using AutoMapper;
using MaskShop.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class MaskController: ControllerBase
    {
        private ILogger<MaskController> Logger { get; }
        private IMaskCreateService MaskCreateService { get; }
        private IMaskGetService MaskGetService { get; }
        private IMaskUpdateService MaskUpdateService { get; }
        private IMapper Mapper { get; }

        public MaskController(ILogger<MaskController> Logger, IMaskCreateService MaskCreateService, IMaskGetService MaskGetService, IMaskUpdateService MaskUpdateService, IMapper Mapper)
        {
            this.Logger = Logger;
            this.MaskCreateService = MaskCreateService;
            this.MaskGetService = MaskGetService;
            this.MaskUpdateService = MaskUpdateService;
            this.Mapper = Mapper;
        }
   
    }
}
