using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;

namespace HarneyCounty.Infrastructure.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private HarneyCountyDbContext _dbContext;

        #endregion Fields

        #region Ctor

        public UnitOfWork(HarneyCountyDbContext context)
        {
            _dbContext = context;
        }

        #endregion Ctor

        #region IUnitOfWork Members

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        #endregion IUnitOfWork Members
    }
}