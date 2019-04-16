
using System;
using yogeshwarTestProjectModel;

namespace DatayogeshwarTestProjectData.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NotesEntities Init();
    }
}
