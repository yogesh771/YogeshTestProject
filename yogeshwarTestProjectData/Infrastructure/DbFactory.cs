

using yogeshwarTestProjectModel;

namespace DatayogeshwarTestProjectData.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        NotesEntities dbContext;

        public NotesEntities Init()
        {
            return dbContext ?? (dbContext = new NotesEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
