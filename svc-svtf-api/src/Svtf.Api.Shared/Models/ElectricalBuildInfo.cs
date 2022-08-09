using System;
using System.Collections.Generic;
using System.Text;

namespace Svtf.Api.Shared.Models
{
    public class ElectricalBuildInfo : BuildInfoBase
    {
        public string VoltageRequirement { get; set; }
        public WiringRequirement WiringRequirement { get; set; }
    }
    public class WiringRequirement
    {
        public int Leads { get; set; }
        public PowerRequirementType PowerRequirement { get; set; }
    }
    public enum PowerRequirementType
    {
        Constant,
        Ignition
    }
}
