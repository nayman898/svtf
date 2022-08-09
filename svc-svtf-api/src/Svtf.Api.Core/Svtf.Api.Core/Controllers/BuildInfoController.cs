using Microsoft.AspNetCore.Mvc;
using Svtf.Api.Service.Abstraction;

namespace Svtf.Api.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildInfoController : ControllerBase
    {
        private readonly ILogger<BuildInfoController> _logger;
        private IConfigurationRoot _config;
        private IBuildInfoService _service;

        public BuildInfoController(ILogger<BuildInfoController> logger, IConfigurationRoot config, IBuildInfoService service)
        {
            _logger = logger;
            _config = config;
            _service = service;
        }

        [HttpGet]
        public IActionResult GetBuildInfo()
        {
            _logger.BeginScope("Get SVTF Build Info");
            var result = _service.GetBuildInfo();
            return Ok(result);
        }
    }
}