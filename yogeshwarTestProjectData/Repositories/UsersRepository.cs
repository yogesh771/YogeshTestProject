using DatayogeshwarTestProjectData.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yogeshwarTestProjectModel;

namespace yogeshwarTestProjectData.Repositories
{
   public class UsersRepository : RepositoryBase<TblUser>, IUserRepository
    {
        public UsersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

    }

    public interface IUserRepository : IRepository<TblUser>
    {

    }
}

