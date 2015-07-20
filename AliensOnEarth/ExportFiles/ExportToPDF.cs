using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//These Libraries below are required for the PDF generation
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;

namespace AliensOnEarth.ExportFiles
{
    /*
     Author: Avinash
     Company:Multunus Software
     This Class is used to Write the Alien Records to a PDF file
     */
    class ExportToPDF:IGenerateFormat
    {
        public void GenerateFile(SortedList alienInfo)
        {
            Console.WriteLine("Exporting To PDF");

            //creation of a document-object
            Document pdfCreate = new Document(PageSize.A4.Rotate());

            try
            {

                //create a writer that listens to this doucment and writes the document to desired Stream.

                PdfWriter.GetInstance(pdfCreate, new FileStream(FileNamePaths.filePath + FileNamePaths.fileName + ".pdf", FileMode.Create));

                // Open the document now 
                pdfCreate.Open();

                // Writing To pdf from hashtable
                pdfCreate.Add(new Paragraph("Alien Record Details"));
                pdfCreate.Add(new Paragraph("----------------------------------------------"));
                foreach (DictionaryEntry records in alienInfo)
                {
                   pdfCreate.Add(new Paragraph(records.Key + "          " + records.Value));
                    
                }
                Console.WriteLine("Exporting To PDF Completed!");

            }
            catch (DocumentException ex)
            {
                Console.Error.WriteLine(ex.Message);

            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                // closing the document

                pdfCreate.Close();
                Console.WriteLine("Press Enter to Exit!");
                
            }
        }
    }
}
