using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_null_object_pattern
{
    public class UserRepository : IUserRepository
    {
        //private string userId;
        private ICollection<User> users;

        public UserRepository()
        {
            users = new List<User>
            {
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid())
            };
        }

        public IUser GetByID(Guid userID)
        {
            //return new User();
            IUser userFound = users.SingleOrDefault(user => user.ID == userID);
            if(userFound == null)
            {
                userFound = new NullUser();
            }
            return userFound;
        }

        public IUser GetByID(string name)
        {
            User user = new User();
            user.Name = name;
            return user;
        }
    }
}
