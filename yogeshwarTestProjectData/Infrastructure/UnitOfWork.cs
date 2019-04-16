using DatayogeshwarTestProjectData.Infrastructure;
using System;
using yogeshwarTestProjectModel;

namespace yogeshwarTestProjectData.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private NotesEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public NotesEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
           // var trans = DbContext.Database.BeginTransaction();
            try
            {                
                DbContext.SaveChanges();
               // trans.Commit();
            }
            catch (Exception e) {
               // trans.Rollback();
            }

        }
    }
}
