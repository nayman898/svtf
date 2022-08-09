using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Svtf.Api.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Svtf.Api.Shared.Client
{
    public class SvtfSharedClient
    {
        private IConfigurationRoot _config;
        public SvtfSharedClient(IConfigurationRoot config)
        {
            _config = config;
        }
        public BuildInfoContract GetBuildInfo()
        {
            BuildInfoContract contract;
            using (HttpClient client = new HttpClient())
            {
                string baseUrl = _config["SvtfApi:BaseUrl"].ToString();
                client.BaseAddress = new Uri(baseUrl);
                var response = client.GetAsync("/buildinfo").Result;
                contract = JsonConvert.DeserializeObject<BuildInfoContract>(response.Content.ReadAsStringAsync().Result);
            }
            return contract;
        }
    }
}
