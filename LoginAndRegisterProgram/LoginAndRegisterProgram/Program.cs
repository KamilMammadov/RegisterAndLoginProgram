using System;
using System.Collections.Generic;

namespace LoginAndRegisterProgram
{
    class Program
    {
        public static List<User> users { get; set; } = new List<User>()
        {
            new User("Super","Admin","admin@gmail.com","123321")
        };
        static void Main(string[] args)
        {
           

            

            Console.WriteLine(" Available Commands :");
            Console.WriteLine("/login");
            Console.WriteLine("/register");
            Console.WriteLine("/exit");
           
            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Profiles in program : ");
                ShowPerson();

                Console.WriteLine();
                Console.WriteLine("commandi daxil edin :");
                string command = Console.ReadLine();

                if (command == "/register")
                {
                    Console.Write("Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Surname : ");
                    string surname = Console.ReadLine();
                    Console.Write("Email : ");
                    string email = Console.ReadLine();
                    Console.Write("Password : ");
                    string password = Console.ReadLine();

                    Console.Write("enter password again for security :");
                    string checkpassword = Console.ReadLine();

                    Console.WriteLine("--------------------------------------------------------");

                    if (IsPassword(password, checkpassword))            
                    {
                        AddNewPerson(name, surname, email, password);
                    }
                    else
                    {
                        Console.WriteLine("Password isn't correct");
                    }

                }
                else if (command == "/login")
                {
                    Console.WriteLine();
                    Console.Write("Please enter your email : ");
                    string loginEmail = Console.ReadLine();
                    Console.Write("Please enter your password : ");
                    string loginPassword = Console.ReadLine();

                    Login login = new Login(loginEmail, loginPassword);
                    
                    if (login.IsLoginPassword(users, loginPassword) & login.IsLoginEmail(users, loginEmail))
                    {
                        Console.WriteLine("Successful login");
                        Console.WriteLine(User.GetInfoLogin(users, loginEmail));
                        
                    }
                    else
                    {
                        Console.WriteLine("You canət login!");
                    }

                }
                else if (command=="/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command is wrong!");
                }
                
            }
        }




        public static bool IsPassword(string password, string checkpassword)
        {
            return password == checkpassword;
        }

    

        public static bool AddNewPerson(string name, string lastname, string email, string password)
        {
            User user = new User(name, lastname, email, password);

            UserValidator userValidator = new UserValidator();
            if (userValidator.Validate(user, users))
            {
                users.Add(user);
                Console.WriteLine($"{name} {lastname} successfully registered, now you can login with your new account!");
                return true;
            }
            Console.WriteLine("Can't added system");
            return false;
        }

     public static void ShowPerson()
        {
            foreach (User item in users)
            {
                Console.WriteLine(item.Name +" "+item.Surname+" "+ item.Email);
            }
        }

      
    }
}
