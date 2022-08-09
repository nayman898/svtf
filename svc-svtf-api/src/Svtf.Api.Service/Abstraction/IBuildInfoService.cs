using Svtf.Api.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Svtf.Api.Service.Abstraction
{
    public interface IBuildInfoService
    {
        BuildInfoContract GetBuildInfo();
    }
}
