using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_null_object_pattern
{
    interface IUserRepository
    {
        IUser GetByID(Guid userID);
    }
}
