﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant //concurrent
    {
        public string firstName;
        public string lastName ;
        public string email;
        public int Id = 2018;

        public void Infos()
        {
            Console.Write("What is your first Name?");
             firstName = Console.ReadLine();

            Console.Write("What is your Last Name?");
            lastName = Console.ReadLine();

            Console.Write("What is your Email adress?");
             email = Console.ReadLine();
           
             Id = +1;
            Console.Write(" your Registration Number is = {0} ", Id);
        }


}
}
