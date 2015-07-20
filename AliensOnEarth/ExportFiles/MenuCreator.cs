using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections.ObjectModel;
using AliensOnEarth.AlienDetails;

namespace AliensOnEarth.ExportFiles
{
    class MenuCreator
    {
        static List<string> fullClassList = new List<string>();
        static List<string> exportFormatList = new List<string>();
        static string @namespace = "AliensOnEarth.ExportFiles";

        public static void FormatExporterMenu()
        {


            int menuNo = 1, userChoice;
            // static string @namespace = "AliensOnEarth.ExportFiles";
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.Namespace == @namespace).ToList();
            //types.ForEach(t => Console.WriteLine(t.Name));
            types.ForEach(t => fullClassList.Add(t.Name));
            foreach (string x in fullClassList)
            {
                if (x.Substring(0, 8) == "ExportTo")
                {
                    exportFormatList.Add(x);
                }
            }
            fullClassList.Clear();
            Console.WriteLine("\nChoose a choice no to export the above details to the desired format below\n");
            foreach (string y in exportFormatList)
            {
                Console.WriteLine((menuNo++) + ": " + y+"\n");
            }
            
            try
            {

                userChoice = Convert.ToInt32(Console.ReadLine());
                CheckFormat(userChoice);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Invalid Choice");
            }

        }

        public static void CheckFormat(int userChoice)
        {
            try
            {
                //Dynamically getting the Class name of the Format
                Type calledType = Type.GetType(@namespace + "." + ExportFileName(userChoice));
                // Creating an instance of the Class
                object instance = Activator.CreateInstance(calledType);
                MethodInfo method = calledType.GetMethod("GenerateFile");
                //passing method arguments with object
                method.Invoke(instance, new object[] { AlienDetailsInputter.getAlienDetails() });
            }
            catch
            {
                Console.WriteLine("Invalid Menu Choice or the format is not implemented properly.Press Enter to Exit");
            }
        }

        public static string ExportFileName(int userChoice)
        {
            return exportFormatList[userChoice - 1];
        }
    }
}
