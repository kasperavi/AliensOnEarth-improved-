using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AliensOnEarth.ExportFiles
{
    /*
   Author: Avinash
   Company:Multunus Software
   This Interface is used to create any new formats to maintain the format structure and behaviour.
   */
    interface IGenerateFormat
    {
        void GenerateFile(SortedList alienInfo);
    }
}