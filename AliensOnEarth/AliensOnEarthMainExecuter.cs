using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliensOnEarth.AlienDetails;
using AliensOnEarth.ExportFiles;

namespace AliensOnEarth
{
    /*
    Author: Avinash
    Company:Multunus Software
    This is the Main Home Class where it calls the other Classes and Methods.
    */
    class AliensOnEarthMainExecuter
    {
        static void Main(string[] args)
        {
            AlienDetailsInputter.ReadAlienInput();
            AlienDetailsDisplayer.AlienDataDisplay(AlienDetailsInputter.getAlienDetails());
            MenuCreator.FormatExporterMenu();
            Console.ReadLine();
        }
    }
}
