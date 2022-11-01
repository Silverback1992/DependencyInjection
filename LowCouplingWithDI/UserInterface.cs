using LowCouplingWithDI;
using LowCouplingWithDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCouplingWithDI
{
    public class UserInterface
    {
        private IBusiness _business;

        public UserInterface(IBusiness business)
        {
            _business = business;
        }

        public void GetData()
        {
            Console.Write("Enter your username: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter your passoword: ");
            string? password = Console.ReadLine();

            _business.SignUp(userName, password);
        }
    }
}
