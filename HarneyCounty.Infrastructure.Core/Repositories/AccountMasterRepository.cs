using HarneyCounty.Common.Extensions;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class AccountMasterRepository : EFRepository<AccountMaster>, IAccountMasterRepository
    {
        public AccountMasterRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public AccountMasterFullDetail GetAccountFullDetailsByAccountMasterId(int accountMasterId)
        {
            return _dbContext.AccountMasterFullDetails.FirstOrDefault(t => t.AccountMasterId == accountMasterId);
        }

        public AccountMasterFullDetail GetAccountFullDetailsByYearAndAccountNumber(int year, string actNumber)
        {
            return _dbContext.AccountMasterFullDetails.FirstOrDefault(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim());
        }

        public List<AccountMasterAndSummeryData> SearchForAccounts(string accountNumber, decimal asmtYear, out int resultCount
            , string ownerName = null
            , decimal? situsNumber = null, string situsSufx = null, string situsDir = null, string situsZip = null
            , string subDivCode = null, decimal? lotNumber = null, decimal? blockNumber = null, int? townShip = null, string townshipDirection = null
            , string range = null, string rangeDirection = null, int? section = 0, string quarterSection = null, int? parcel = null, string specialInterestAlpha = null, int? specialInterestNumber = 0
            , string xNumber = null, decimal? mobileHomeId = null, string mobHomeMnfr = null, string mhSerial = null
            , string propCode = null, string codeArea = null
            , int pageNumber = 1, int pageSize = 50)
        {
            IQueryable<AccountMasterFullDetail> query = _dbContext.AccountMasterFullDetails;
            if (!string.IsNullOrWhiteSpace(accountNumber))
                query = query.Where(t => t.AcctNmbr.Trim() == accountNumber.Trim());

            if (asmtYear > 0)
                query = query.Where(t => t.AsmtYear.ToString() == asmtYear.ToString());

            if (!string.IsNullOrWhiteSpace(ownerName))
                query = query.Where(t => t.SearchName.Contains(ownerName));

            if (situsNumber.HasValue)
                query = query.Where(t => t.SitusStrtNmbr == situsNumber);

            if (!string.IsNullOrWhiteSpace(situsSufx))
                query = query.Where(t => t.SitusStrtNmbrSufx == situsSufx);

            if (!string.IsNullOrWhiteSpace(situsDir))
                query = query.Where(t => t.SitusStrtDir == situsDir);

            if (!string.IsNullOrWhiteSpace(situsZip))
                query = query.Where(t => t.SitusZipCode == situsZip);

            if (!string.IsNullOrWhiteSpace(subDivCode))
                query = query.Where(t => t.SbdvnCode == subDivCode);

            if (townShip.HasValue)
                query = query.Where(t => t.Twnshp == townShip.Value);

            if (!string.IsNullOrWhiteSpace(townshipDirection))
                query = query.Where(t => t.TwnshpDir == townshipDirection);

            if (!string.IsNullOrWhiteSpace(range))
                query = query.Where(t => t.Range == range);

            if (!string.IsNullOrWhiteSpace(rangeDirection))
                query = query.Where(t => t.RangDir == range);

            if (section.HasValue)
                query = query.Where(t => t.Sctn == section.Value);

            if (!string.IsNullOrWhiteSpace(quarterSection))
                query = query.Where(t => t.QtrSctn == quarterSection);

            if (parcel.HasValue)
                query = query.Where(t => t.Prcl == parcel.Value);

            if (!string.IsNullOrWhiteSpace(specialInterestAlpha))
                query = query.Where(t => t.SpecIntAlph == specialInterestAlpha);

            if (specialInterestNumber.HasValue)
                query = query.Where(t => t.SpecIntNmbr == specialInterestNumber);

            if (lotNumber.HasValue)
                query = query.Where(t => t.LotNmbr == lotNumber);

            if (blockNumber.HasValue)
                query = query.Where(t => t.BlckNmbr == blockNumber);

            if (!string.IsNullOrWhiteSpace(xNumber))
                query = query.Where(t => t.XNmbr == xNumber);

            if (mobileHomeId.HasValue)
                query = query.Where(t => t.MobileHomeId == mobileHomeId);

            if (!string.IsNullOrWhiteSpace(mobHomeMnfr))
                query = query.Where(t => t.MobHomeMnfr == mobHomeMnfr);

            if (!string.IsNullOrWhiteSpace(mhSerial))
                query = query.Where(t => t.MhSerial == mhSerial);

            if (!string.IsNullOrWhiteSpace(propCode))
                query = query.Where(t => t.PropClassCode == propCode);

            if (!string.IsNullOrWhiteSpace(codeArea))
                query = query.Where(t => t.CodeAreaCode == codeArea);

            var groupByYearAndAccountNumber = query.GroupBy(t => new { t.AsmtYear, t.AcctNmbr });

            if (pageNumber > 0)
            {
                var result = groupByYearAndAccountNumber.OrderBy(t => t.Key).Skip((pageNumber - 1) * pageSize).Take(pageSize)
                    .ToList()
                    .Select(g =>
                    {
                        var record = new AccountMasterAndSummeryData(g.First());
                        record.MobileHomeRecords = g.Where(t => t.MobileHome_Id.HasValue).AsNotNull()
                        .Select(mob => new MobileHomeData(mob)).ToList();
                        return record;
                    }).ToList();
                //var result = query.OrderBy(x => x.AcctNmbr).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                //resultCount = query.Count();
                resultCount = groupByYearAndAccountNumber.Count();
                return result;
            }
            else
            {
                var result = groupByYearAndAccountNumber.ToList().Select(g =>
                {
                    var record = new AccountMasterAndSummeryData(g.First());
                    record.MobileHomeRecords = g.Where(t => t.MobileHome_Id.HasValue).AsNotNull()
                    .Select(mob => new MobileHomeData(mob)).ToList();
                    return record;
                }).ToList();
                resultCount = result.Count;
                return result;
            }
        }
    }
}