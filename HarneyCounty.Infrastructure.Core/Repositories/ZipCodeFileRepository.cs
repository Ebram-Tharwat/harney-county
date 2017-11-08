using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarneyCounty.Infrastructure.Core.DAL;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class ZipCodeFileRepository : EFRepository<ZipCodeFile>, IZipCodeFileRepository
    {
        public ZipCodeFileRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<ZipCodeFile> GetZipCodes(List<string> zipCodes)
        {
            return _dbContext.ZipCodeFiles.Where(z => zipCodes.Contains(z.ZipCode.Trim())).ToList();
        }
    }
}
