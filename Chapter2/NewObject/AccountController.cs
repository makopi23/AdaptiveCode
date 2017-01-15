using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewObject
{
    class AccountController
    {
        //private readonly SecurityService securityService;
        private readonly ISecurityService securityService;

        /*
        public AccountController()
        {
            this.securityService = new SecurityService();
        }
        */
        public AccountController(ISecurityService securityService){
            if(securityService == null)
            {
                throw new ArgumentNullException("securityService");
            }
            this.securityService = securityService;
        }

        //[HttpPost]
        public void ChangePassword(Guid userID, string newPassword)
        {
            //var userRepository = new UserRepository();
            //var user = userRepository.GetByID(userID);
            this.securityService.ChangeUserPassword(userID, newPassword);
        }
    }
}
