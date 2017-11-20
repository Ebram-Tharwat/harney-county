using HarneyCounty.Domain.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface ICodeAreaService
    {
        List<CodeAreaBasicInfo> GetDistinctCodeAreasInfo();
    }
}
