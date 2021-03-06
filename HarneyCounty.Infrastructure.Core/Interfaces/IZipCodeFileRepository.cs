﻿using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IZipCodeFileRepository : IRepository<ZipCodeFile>
    {
        List<ZipCodeFile> GetZipCodes(List<string> zipCodes);
    }
}
