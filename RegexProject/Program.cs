using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProject 
  {
    public class Program
    {
        public static void Main(String[] args)
        {
            Paterns paterns = new Paterns();
            Console.WriteLine("Enter First Name:");
            string firstName=Console.ReadLine();    
            paterns.ValidFirstName(firstName);

            Console.WriteLine("Enter Last Name:");
            string LastName = Console.ReadLine();
            paterns.ValidFirstName(LastName);

        }
    }
    
  }
