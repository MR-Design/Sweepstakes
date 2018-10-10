using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class User
    {
        // Here I will Collect User Info 
        //Neme, LastName , Email , Registration Number

        public void Infos()
        {
            Console.Write("What is your first Name?");
            string firstName = Console.ReadLine();

            Console.Write("What is your Last Name?");
            string lasttName = Console.ReadLine();

            Console.Write("What is your Email adress?");
            string email = Console.ReadLine();

            // Maybe I need a Function To Save Registration Numbers
            Console.Write("What is your Registration Number?");
            string registrationNumber = Console.ReadLine();
        }
       
    }
}
