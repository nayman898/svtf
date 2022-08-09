using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Svtf.Api.Shared.Client;
using Svtf.Api.Shared.Contracts;

namespace Svtf.Web.App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfigurationRoot _config;
        private readonly ILogger<IndexModel> _logger;
        public BuildInfoContract Contract { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfigurationRoot config)
        {
            _logger = logger;
            _config = config;
        }

        public void OnGet()
        {
            SvtfSharedClient client = new(_config);
            Contract = client.GetBuildInfo();
        }
    }
}