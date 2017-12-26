using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IDeductionHistoryRepository : IRepository<DeductionHistory>
    {
        List<DeductionFullDetail> GetDeductionHistoryFullDetailsByEmplNumber(decimal employeeNumber);
    }
}