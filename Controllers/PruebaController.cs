using Microsoft.AspNetCore.Mvc;
using WebApi.Abstractions;
using WebApi.Classes;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController : ControllerBase
    {
        private readonly IPruebaProvider PruebaProvider;
        public PruebaController(IPruebaProvider PruebaProvider)
        {
            this.PruebaProvider = PruebaProvider;
        }

        [HttpGet]
        [Route("/Test")]
        public ServiceResponse Test()
        {
            return PruebaProvider.Instance.Test();
        }
    }
}