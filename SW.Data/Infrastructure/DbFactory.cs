using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SWDbContext dbContext;
        public SWDbContext Init()
        {
            return dbContext ?? (dbContext = new SWDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
