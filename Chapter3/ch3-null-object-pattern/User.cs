using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_null_object_pattern
{
    public class User : IUser
    {
        private Guid guid;
        private string password;

        public User()
        {
            // Todo
        }

        public Guid ID
        {
            get;
            private set;
        }

        public User(string password)
        {
            this.password = password;
        }

        public void ChangePassword(string newPassword)
        {
            password = newPassword;
        }

        public User(Guid guid)
        {
            this.guid = guid;
            sessionExpiry = DateTime.Now;
            IncrementSessionTicket();
        }
        public void IncrementSessionTicket()
        {
            sessionExpiry.AddMinutes(30);
        }

        private DateTime sessionExpiry;

    }
}
