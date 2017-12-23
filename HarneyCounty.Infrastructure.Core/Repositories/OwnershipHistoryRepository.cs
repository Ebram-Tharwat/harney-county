﻿using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class OwnershipHistoryRepository : EFRepository<OwnershipHistory>, IOwnershipHistoryRepository
    {
        public OwnershipHistoryRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<OwnershipHistory> GetOwnershipHistoryByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbContext.OwnershipHistories
               .Where(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}