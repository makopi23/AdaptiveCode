using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewObject
{
    public interface ISecurityService
    {
        void ChangeUserPassword(Guid userID, string newPassword);
    }

    class SecurityService : ISecurityService
    {
        private readonly IUserRepository userRepository;


        public SecurityService(IUserRepository userRepository)
        {
            if(userRepository == null)
            {
                throw new ArgumentNullException("userRepository");
                this.userRepository = userRepository;
            }
        }

        public void ChangeUserPassword(Guid userID, string newPassword)
        {
            var user = userRepository.GetByID(userID);
            user.ChangePassword(newPassword);
        }
    }
}
