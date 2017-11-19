using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.ViewModel;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Services
{
    public class CodeAreaService : ICodeAreaService
    {
        private readonly ICodeAreaRepository _codeAreaRepository;

        public CodeAreaService(ICodeAreaRepository codeAreaRepository)
        {
            this._codeAreaRepository = codeAreaRepository;
        }

        public List<CodeAreaBasicInfo> GetDistinctCodeAreasInfo()
        {
            return this._codeAreaRepository.GetDistinctCodeAreasInfo();
        }
    }
}