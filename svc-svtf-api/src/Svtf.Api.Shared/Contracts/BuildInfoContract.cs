using Svtf.Api.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Svtf.Api.Shared.Contracts
{
    public class BuildInfoContract
    {
        public List<EngineBuildInfo> EngineBuildInfo { get; set; }
        public List<InteriorBuildInfo> InteriorBuildInfo { get; set; }
        public List<ExteriorBuildInfo> ExteriorBuildInfo { get; set; }
        public List<ElectricalBuildInfo> ElectricalBuildInfo { get; set; }
    }
}
