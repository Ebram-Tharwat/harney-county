using HarneyCounty.Application.Core.ViewModel.Payroll;
using System;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IDeductionHistoryService
    {
        List<string> GetAllDeductionCodes();

        List<DeductionDetailsViewModel> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime? payDate = null, string deductionCode = null);

        List<DeductionDetailsViewModel> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime? startDate = null, DateTime? endDate = null, string deductionCode = null);
    }
}