using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace Presentation.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        
        private readonly ILogger<DeviceController> _logger;
        private readonly HomeAssistantDeviceContext dbContext;

        public DeviceController(ILogger<DeviceController> logger, HomeAssistantDeviceContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet(Name = "")]
        public IEnumerable<Device> Get()
        {
            return dbContext.Devices.ToList();
        }
    }
}
