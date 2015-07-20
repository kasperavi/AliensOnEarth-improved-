using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AliensOnEarth.ExportFiles
{
    /*
    Author: Avinash
    Company:Multunus Software
    This Class is used to Write the Alien Records to a TXT file
    */
    class ExportToTXT:IGenerateFormat
    {
        public void GenerateFile(SortedList alienInfo)
        {
            Console.WriteLine("Exporting To TXT");
            StreamWriter objWriter;
            try
            {
                //creating Streamwriter to write .txt file with Filename and path
                objWriter = new StreamWriter(FileNamePaths.filePath + FileNamePaths.fileName + ".txt");
                objWriter.WriteLine("Alien Record Details");
                objWriter.WriteLine("--------------------------------");
                //Writing the Contents of the Hastable to the .txt file
                foreach (DictionaryEntry records in alienInfo)
                {
                    objWriter.WriteLine(records.Key + "\t" + records.Value);
                }
                Console.WriteLine("Exporting To TXT Completed!");
                //Closing the Streamwriter
                objWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Press Enter to Exit!");
                
            }

        }
    }
}
