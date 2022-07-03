using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegisterProgram
{
    class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public User(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }
        

        //     GetInfoLogin methodu sistme login ederken, login eden maili listde axtarir ve hemen mailin ad soyadini cixardir

        public static string GetInfoLogin(List<User> users, string mail)
        {
            foreach (User item in users)
            {
                if (item.Email == mail)
                {
                    return item.Name + " " + item.Surname;
                }
            }

            return "-";
        }
        
    }
}
