using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace ControlleursWorkflow
{
    class PdfGenerator
    {

        /*private MSG msg;*/
        //I replaced msg type by string as long as I don't have the MSG class.
        private static string msg = "Ce texte est le texte décrypté. Bravo à vous";



        public static void GeneratePdf(string msg)
        {
            System.IO.FileStream fs = new FileStream("First PDF document.pdf", FileMode.Create);
            // Create an instance of the document class which represents the PDF document itself.
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF   
            // Writer class using the document and the filestrem in the constructor.  
            
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            Console.WriteLine("testns");
            Console.ReadLine();

            // Add meta information to the document  
            document.AddAuthor("Micke Blomquist");
            document.AddCreator("Sample application using iTextSharp");
            document.AddKeywords("PDF tutorial education");
            document.AddSubject("Document subject - Describing the steps creating a PDF document");
            document.AddTitle("The document title - PDF creation using iTextSharp");


            // Open the document to enable you to write to the document  
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner  
            document.Add(new Paragraph(msg));
            // Close the document  
            document.Close();
            // Close the writer instance  
            writer.Close();
            // Always close open filehandles explicity  
            fs.Close();
        }
    }
}
