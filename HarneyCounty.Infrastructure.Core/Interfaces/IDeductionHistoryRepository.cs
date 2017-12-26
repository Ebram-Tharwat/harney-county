using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IDeductionHistoryRepository : IRepository<DeductionHistory>
    {
        List<DeductionFullDetail> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime paydate);
    }
}