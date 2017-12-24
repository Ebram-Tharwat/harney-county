using HarneyCounty.Domain.Core.Models;
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

        public AccountMasterFullDetail GetAccountFullDetailsByYearAndAccountNumber(int year, string actNumber)
        {
            return _dbContext.AccountMasterFullDetails
                .FirstOrDefault(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim());
        }

        public List<AccountMasterFullDetail> SearchForAccounts(string accountNumber, decimal asmtYear, out int resultCount
            , string ownerName = null
            , decimal? situsNumber = null, string situsSufx = null, string situsDir = null, string situsZip = null, string situsStreetName = null
            , string subDivCode = null, decimal? lotNumber = null, decimal? blockNumber = null, int? townShip = null, string townshipDirection = null
            , string range = null, string rangeDirection = null, int? section = 0, string quarterSection = null, int? parcel = null, string specialInterestAlpha = null, int? specialInterestNumber = 0
            , string xNumber = null, decimal? mobileHomeId = null, string mobHomeMnfr = null, string mhSerial = null
            , string propCode = null, string codeArea = null
            , int pageNumber = 1, int pageSize = 50)
        {
            IQueryable<AccountMasterFullDetail> query = _dbContext.AccountMasterFullDetails;
            if (!string.IsNullOrWhiteSpace(accountNumber))
                query = query.Where(t => t.AcctNmbr.ToLower().Trim() == accountNumber.ToLower().Trim());

            if (asmtYear > 0)
                query = query.Where(t => t.AsmtYear.ToString() == asmtYear.ToString());

            if (!string.IsNullOrWhiteSpace(ownerName))
                query = query.Where(t => t.OwnerName.Contains(ownerName) || t.OwnerAlphaName.Contains(ownerName));

            if (situsNumber.HasValue)
                query = query.Where(t => t.SitusStrtNmbr == situsNumber);

            if (!string.IsNullOrWhiteSpace(situsSufx))
                query = query.Where(t => t.SitusStrtNmbrSufx.ToLower() == situsSufx.ToLower());

            if (!string.IsNullOrWhiteSpace(situsDir))
                query = query.Where(t => t.SitusStrtDir.ToLower() == situsDir.ToLower());

            if (!string.IsNullOrWhiteSpace(situsZip))
                query = query.Where(t => t.SitusZipCode.ToLower() == situsZip.ToLower());

            if (!string.IsNullOrWhiteSpace(situsStreetName))
                query = query.Where(t => t.SitusStrtName.ToLower() == situsStreetName.ToLower());

            if (!string.IsNullOrWhiteSpace(subDivCode))
                query = query.Where(t => t.SbdvnCode.ToLower() == subDivCode.ToLower());

            if (townShip.HasValue)
                query = query.Where(t => t.Twnshp == townShip.Value);

            if (!string.IsNullOrWhiteSpace(townshipDirection))
                query = query.Where(t => t.TwnshpDir.ToLower() == townshipDirection.ToLower());

            if (!string.IsNullOrWhiteSpace(range))
                query = query.Where(t => t.Range.ToLower() == range.ToLower());

            if (!string.IsNullOrWhiteSpace(rangeDirection))
                query = query.Where(t => t.RangDir.ToLower() == rangeDirection.ToLower());

            if (section.HasValue)
                query = query.Where(t => t.Sctn == section.Value);

            if (!string.IsNullOrWhiteSpace(quarterSection))
                query = query.Where(t => t.QtrSctn.ToLower() == quarterSection.ToLower());

            if (parcel.HasValue)
                query = query.Where(t => t.Prcl == parcel.Value);

            if (!string.IsNullOrWhiteSpace(specialInterestAlpha))
                query = query.Where(t => t.SpecIntAlph.ToLower() == specialInterestAlpha.ToLower());

            if (specialInterestNumber.HasValue)
                query = query.Where(t => t.SpecIntNmbr == specialInterestNumber);

            if (lotNumber.HasValue)
                query = query.Where(t => t.LotNmbr == lotNumber);

            if (blockNumber.HasValue)
                query = query.Where(t => t.BlckNmbr == blockNumber);

            if (!string.IsNullOrWhiteSpace(xNumber))
                query = query.Where(t => t.XNmbr.ToLower() == xNumber.ToLower());

            if (mobileHomeId.HasValue)
                query = query.Where(t => t.MobileHomeId == mobileHomeId);

            if (!string.IsNullOrWhiteSpace(mobHomeMnfr))
                query = query.Where(t => t.MobHomeMnfr.ToLower() == mobHomeMnfr.ToLower());

            if (!string.IsNullOrWhiteSpace(mhSerial))
                query = query.Where(t => t.MhSerial.ToLower() == mhSerial.ToLower());

            if (!string.IsNullOrWhiteSpace(propCode))
                query = query.Where(t => t.PropClassCode.Trim().Equals(propCode.Trim(), System.StringComparison.InvariantCultureIgnoreCase));

            if (!string.IsNullOrWhiteSpace(codeArea))
                query = query.Where(t => t.CodeAreaCode.ToLower() == codeArea.ToLower());

            if (pageNumber > 0)
            {
                var result = query.OrderBy(t => new { t.AsmtYear, t.AcctNmbr }).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                resultCount = query.Count();
                return result;
            }
            else
            {
                var result = query.ToList();
                resultCount = result.Count;
                return result;
            }
        }
    }
}