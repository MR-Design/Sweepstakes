using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {

        Sweepstakes(string name)
        {

            // Create a new dictionary of strings, with string keys.
            //
            Dictionary<string, string> NewUser =
                new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            NewUser.Add("txt", "notepad.exe");
            NewUser.Add("bmp", "paint.exe");
            NewUser.Add("dib", "paint.exe");
            NewUser.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is 
            // already in the dictionary.
            try
            {
                NewUser.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
        }


        //void RegisterContestant(Contestant contestant)
        //string PickWinner()
        //void PrintContestantInfo(Contestant contestant)
    }
}
