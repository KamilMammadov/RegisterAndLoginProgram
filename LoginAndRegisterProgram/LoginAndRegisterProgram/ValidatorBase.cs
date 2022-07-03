using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegisterProgram
{
    public class ValidatorBase
    {
        public bool ValidateWordSize(string word,int min,int max)
        {
            
            return word.Length >= min && word.Length <= max;
        }




        public bool ValidateCharContains(string word,char input)
        {
            foreach (char item in word)
            {
                if (input==item)
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool ValidateWordContains(List<string> words,string text)
        {
            foreach (string item in words)
            {
                if (text==item)
                {
                    return false;
                }
            }
            return true;
        }     
    }
}
