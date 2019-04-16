using DatayogeshwarTestProjectData.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yogeshwarTestProjectModel;

namespace yogeshwarTestProjectData.Repositories
{
   public class NotesRepository : RepositoryBase<TblNote>, INotesRepository
    {
        public NotesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }         

    }

    public interface INotesRepository : IRepository<TblNote>
    {
       
    }
}
