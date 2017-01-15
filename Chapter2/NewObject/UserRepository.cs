using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewObject
{
    interface IUserRepository
    {
        User GetByID(Guid userID);
    }

    class UserRepository : IUserRepository
    {
        //private string userId;

        public User GetByID(Guid userID)
        {
            return new User();
        }
    }


}
