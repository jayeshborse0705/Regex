using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProject
{

    internal class Paterns
    {
        Regex regex = new Regex("^[A-z][1][A-Za-z]{2,}$");

        public void ValidFirstName(string First_Name)
        {
            Console.WriteLine("Enter FirstName:" +First_Name);
            if (regex.IsMatch(First_Name))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
       

    }
}
