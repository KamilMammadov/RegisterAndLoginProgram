using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegisterProgram
{
    class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Login(string email,string password)
        {
            Email = email;
            Password = password;

        }

        //ashagidakki methodlar login ederken mail ve passwordun duzgunluyunu yoxluyur

        public bool IsLoginEmail(List<User> users,string mail)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email== mail)
                {
                   return true;
                }
            }
            Console.WriteLine("Email sehvdir");
            return false;
        }
     
         public bool IsLoginPassword(List<User> users, string password)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Password==password)
                {
                    return true;
                }
            }
            Console.WriteLine("Password isn't correct");
            return false;
        }
    }
}
