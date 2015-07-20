using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AliensOnEarth.AlienDetails
{
    /*
  Author: Avinash
  Company:Multunus Software
  This Class is used to Print the Details on the Console Window.
  */
    class AlienDetailsDisplayer
    {
        public static void AlienDataDisplay(SortedList alienInfo)
        {

            Console.WriteLine();
            Console.WriteLine("The Entered Alien Details are below \n");
            // Traversing and printing the contents of the SortedList that contains Alien Details
            
            foreach (DictionaryEntry records in alienInfo)
            {
                Console.WriteLine(records.Key + "\t" + ": " +records.Value);
            }
        }
    }
}
