using Store.Data.Infrastructure;
using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class LazyLoadingRepository : RepositoryBase<LazyLoadingData>, ILazyLoadingRepository
    {
        public LazyLoadingRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<LazyLoadingData> GetLazyLoadingDatas()
        {
            var Datas = this.DbContext.LazyLoadingDatas.ToList();

            return Datas;
        }
    }
    public interface ILazyLoadingRepository : IRepository<LazyLoadingData>
    {
    }
}