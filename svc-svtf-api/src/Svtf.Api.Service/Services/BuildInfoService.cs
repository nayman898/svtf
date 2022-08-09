using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Svtf.Api.Service.Abstraction;
using System;
using Svtf.Api.Shared.Contracts;
using System.Collections.Generic;
using Svtf.Api.Shared.Models;

namespace Svtf.Api.Service.Services
{
    public class BuildInfoService : IBuildInfoService
    {
        private IConfigurationRoot _config;
        private ILogger _logger;
        public BuildInfoService(ILogger<BuildInfoService> logger, IConfigurationRoot config)
        {
            _logger = logger;
            _config = config;
        }
        public BuildInfoContract GetBuildInfo()
        {
            BuildInfoContract contract = new BuildInfoContract()
            {
                ElectricalBuildInfo = new List<ElectricalBuildInfo>()
                {
                    {
                        new ElectricalBuildInfo()
                        {
                            PartType = "Gauge",
                            VoltageRequirement = "12v",
                            WiringRequirement = new WiringRequirement()
                            {
                                Leads = 3,
                                PowerRequirement = PowerRequirementType.Ignition,
                            }
                        }
                    }
                }
            };
            return contract;
        }
    }
}
