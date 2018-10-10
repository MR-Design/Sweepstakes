using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class User
    {

        int registrationNumber = 2018;
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

            int registrationNumber =+ 1; 
            Console.Write(" your Registration Number s "+ registrationNumber);
        }
       
    }
}
