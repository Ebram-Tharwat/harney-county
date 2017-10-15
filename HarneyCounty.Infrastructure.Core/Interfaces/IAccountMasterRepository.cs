using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IAccountMasterRepository : IRepository<AccountMaster>
    {
        List<AccountMasterFullDetail> SearchForAccounts(string accountNumber, decimal asmtYear, out int resultCount
            , string ownerName = null
            , decimal? situsNumber = null, string situsSufx = null, string situsDir = null, string situsName = null, string situsZip = null
            , string subDivCode = null, decimal? lotNumber = null, decimal? blockNumber = null, int? townShip=null, string townshipDirection=null
            , string range=null, string rangeDirection=null, int? section=null, string quarterSection = null,int? parcel = null,string specialInterestAlpha = null,int? specialInterestNumber = 0
            , string specAlph = null, decimal? specNumber = null
            , string xNumber = null, decimal? mobileHomeId = null, string mobHomeMnfr = null, string mhSerial = null
            , string propCode = null, string codeArea = null
            , int pageNumber = 1, int pageSize = 50);
    }
}