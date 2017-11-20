using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface ICodeAreaRepository : IRepository<CodeArea>
    {
        List<CodeAreaBasicInfo> GetDistinctCodeAreasInfo();
    }
}