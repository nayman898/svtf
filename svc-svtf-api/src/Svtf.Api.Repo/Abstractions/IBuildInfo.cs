using System;
using System.Collections.Generic;
using System.Text;

namespace Svtf.Api.Repo.Abstractions
{
    public interface IBuildInfo
    {
        string PartType { get; set; }
        string PartLink { get; set; }
    }
}
