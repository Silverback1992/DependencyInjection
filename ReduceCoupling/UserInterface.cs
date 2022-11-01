using ReduceCoupling;
using ReduceCoupling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducedCoupling
{
    public class UserInterface
    {
        public void GetData()
        {
            Console.Write("Enter your username: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter your passoword: ");
            string? password = Console.ReadLine();

            IBusiness business = new Business();
            //if i want to use business V2 i only need to change the code above to this:
            //IBusiness business = new BusinessV2();
            //so with this we reduced the coupling
            business.SignUp(userName, password);
        }
    }
}
