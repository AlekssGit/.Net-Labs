using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MaskShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private ILogger<PriceController> Logger { get; }
        private IMapper Mapper { get; }

        public PriceController(ILogger<PriceController> logger, IMapper mapper)
        {
            this.Logger = logger;
            this.Mapper = mapper;
        }
    }
}