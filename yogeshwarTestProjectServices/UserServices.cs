using DatayogeshwarTestProjectData.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yogeshwarTestProjectData.Repositories;
using yogeshwarTestProjectModel;

namespace yogeshwarTestProjectServices
{
    public interface IUsersServices
    {
        IEnumerable<TblUser> GetAll();       
    }
    public class UserServices : IUsersServices
    {
        private readonly IUserRepository usersRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserServices(IUserRepository _usersRepository, IUnitOfWork _unitOfWork)
        {
            this.usersRepository = _usersRepository;
            this.unitOfWork = _unitOfWork;
        }
        public IEnumerable<TblUser> GetAll()
        {
            return usersRepository.GetAll();
        }
    }
}
