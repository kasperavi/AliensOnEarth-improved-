using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AliensOnEarth.AlienDetails
{ /*
   Author: Avinash
   Company:Multunus Software
   This Class is used to read the User's input and store it in a SortedList.
   */
    class AlienDetailsInputter
    {
        static SortedList alienInfo = new SortedList();
        public static void ReadAlienInput()
        {
            Console.WriteLine("Enter the Details of the Alien Below \n");

            foreach (string x in AlienAttributesReader.GetAttributeslist())
            {
                Console.WriteLine(x);
                alienInfo.Add(x, Console.ReadLine().ToUpper());

            }
          
        }

        public static SortedList getAlienDetails()
        {
            return alienInfo;
        }
    }
}
