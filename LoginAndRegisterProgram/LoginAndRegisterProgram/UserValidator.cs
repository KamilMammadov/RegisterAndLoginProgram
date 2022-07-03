using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegisterProgram
{
    class UserValidator : ValidatorBase
    {
        public bool Validate(User user, List<User> exsistingUsers)
        {
            return ValidateName(user.Name) & ValidateSurname(user.Surname) & ValidateEmailUnique(user, exsistingUsers) & ValidateEmailContains(user.Email);
        }

        private bool ValidateName(string name)
        {
            if (ValidateWordSize(name, 3, 30))
            {
                return true;
            }
            Console.WriteLine("Name Length is false");
            return false;
        }

        private bool ValidateSurname(string surname)
        {
            if (ValidateWordSize(surname, 5, 20))
            {
                return true;
            }
            Console.WriteLine("Surname Length is false");
            return false;
        }

        private bool ValidateEmailContains(string email)
        {
            if (ValidateCharContains(email, '@'))
            {
                return true;
            }
            Console.WriteLine("You must use @ in your mail");
            return false;
        }

        private bool ValidateEmailUnique(User user, List<User> existingUsers)
        {
            string email = user.Email;
            List<string> existingEmails = new List<string>();

            foreach (User item in existingUsers)
            {
                existingEmails.Add(item.Email);
            }


            if (ValidateWordContains(existingEmails, email))
            {
                return true;

            }
            Console.WriteLine("This mail was used!");
            return false;
        }

       


    }
}
