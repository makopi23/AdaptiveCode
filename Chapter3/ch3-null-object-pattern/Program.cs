using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_null_object_pattern
{
    class Program
    {
        static IUserRepository userRepository = new UserRepository();

        static void Main(string[] args)
        {
            Console.WriteLine("★START★");
            //var user = userRepository.GetByID(Guid.NewGuid());
            var user = userRepository.GetByID("abc");
            user.IncrementSessionTicket();
            /*
            if(user != null)
            {
                user.IncrementSessionTicket();
            }
            */
            string userName;
            if (!user.IsNull)
            {
                userName = user.Name;
            }
            else
            {
                userName = "unknown";
            }
            Console.WriteLine("The user's name is {0}", userName);
            Console.ReadKey();
        }
    }
}
