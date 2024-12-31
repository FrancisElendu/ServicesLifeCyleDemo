using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLifeCyleDemo.Services;

namespace ServicesLifeCyleDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceLifeTimeDemoController : ControllerBase
    {
        private readonly TransientService _tService1;
        private readonly TransientService _tService2;
        private readonly ScopedService _scService1;
        private readonly ScopedService _scService2;
        private readonly SingletonService _sService1;
        public ServiceLifeTimeDemoController(TransientService tService1, TransientService tService2, ScopedService scService1, ScopedService scService2, SingletonService sService1)
        {
            _tService1 = tService1 ?? throw new ArgumentNullException(nameof(tService1));
            _tService2 = tService2 ?? throw new ArgumentNullException(nameof(tService2));
            _scService1 = scService1 ?? throw new ArgumentNullException(nameof(scService1));
            _scService2 = scService2 ?? throw new ArgumentNullException(nameof(scService2));
            _sService1 = sService1 ?? throw new ArgumentNullException(nameof(sService1));
        }


        [HttpGet("lifecycle-services")]
        public IActionResult GeLifecyleServicest()
        {
            return Ok(new
            {
                Transient = new
                {
                    _tService1 = _tService1.GetId(),
                    _tService2 = _tService2.GetId(),
                },

                Scoped = new
                {
                    _scService1 = _scService1.GetId(),
                    _scService2 = _scService2.GetId(),
                },

                Singleton = new
                {
                    _sService1 = _sService1.GetId()
                }
            });
        }
    }
}
