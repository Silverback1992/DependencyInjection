using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyCoupled
{
    public class UserInterface
    {
        public void GetData()
        {
            Console.Write("Enter your username: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter your passoword: ");
            string? password = Console.ReadLine();

            var business = new Business();
            business.SignUp(userName, password);
        }
    }
}
