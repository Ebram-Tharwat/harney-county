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

        public List<AccountMasterFullDetail> SearchForAccounts(string accountNumber, decimal asmtYear, string ownerName = null
            , decimal? situsNumber = null, string situsSufx = null, string situsDir = null, string situsName = null, string situsZip = null
            , string subDivCode = null, decimal? lotNumber = null, decimal? blockNumber = null
            , string specAlph = null, decimal? specNumber = null
            , string xNumber = null, decimal? mobileHomeId = null, string mobHomeMnfr = null, string mhSerial = null
            , string propCode = null, string codeArea = null)
        {
            IQueryable<AccountMasterFullDetail> query = _dbContext.AccountMasterFullDetails;
            if (!string.IsNullOrWhiteSpace(accountNumber))
                query = query.Where(t => t.AcctNmbr == accountNumber);

            if (asmtYear > 0)
                query = query.Where(t => t.AsmtYear == asmtYear);

            if (!string.IsNullOrWhiteSpace(ownerName))
                query = query.Where(t => t.OwnerName == ownerName);

            if (situsNumber.HasValue)
                query = query.Where(t => t.SitusStrtNmbr == situsNumber);

            if (!string.IsNullOrWhiteSpace(situsSufx))
                query = query.Where(t => t.SitusStrtNmbrSufx == situsSufx);

            if (!string.IsNullOrWhiteSpace(situsDir))
                query = query.Where(t => t.SitusStrtDir == situsDir);

            if (!string.IsNullOrWhiteSpace(situsName))
                query = query.Where(t => t.SitusStrtName == situsName);

            if (!string.IsNullOrWhiteSpace(situsZip))
                query = query.Where(t => t.SitusZipCode == situsZip);

            if (!string.IsNullOrWhiteSpace(subDivCode))
                query = query.Where(t => t.SbdvnCode == subDivCode);

            if (lotNumber.HasValue)
                query = query.Where(t => t.LotNmbr == lotNumber);

            if (blockNumber.HasValue)
                query = query.Where(t => t.BlckNmbr == blockNumber);

            if (!string.IsNullOrWhiteSpace(specAlph))
                query = query.Where(t => t.SpecIntAlph == specAlph);

            if (specNumber.HasValue)
                query = query.Where(t => t.SpecIntNmbr == specNumber);

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

            return query.ToList();
        }
    }
}