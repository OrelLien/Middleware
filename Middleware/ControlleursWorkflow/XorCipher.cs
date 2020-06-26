using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlleursWorkflow
{
    class XorCipher
    {

       /* private MSG msg;*/
        private string key;
        private static string msg = "Ce texte est le texte décrypté. Bravo à vous";


        static void Main(String[] args)
        {
           string PlainText = "aller liverpool";
           string encryptedText = "©¤¤­ºè¤¡¾­º¸§§¤";
           int EncryptionKey = 200;
           Console.WriteLine("test");
           Console.WriteLine(EncryptDecrypt(encryptedText, EncryptionKey));
           Console.WriteLine(EncryptDecrypt(PlainText, EncryptionKey));
           Console.ReadLine();
           PdfGenerator.GeneratePdf(msg);
        }


        public static string EncryptDecrypt(string PlainText, int EncryptionKey)
        {
            StringBuilder InputStringBuild = new StringBuilder(PlainText);
            StringBuilder OutStringBuild = new StringBuilder(PlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < PlainText.Length; iCount++)
            {
                Textch = InputStringBuild[iCount];
                Textch = (char)(Textch ^ EncryptionKey);
                OutStringBuild.Append(Textch);
            }
            return OutStringBuild.ToString();
        }
    }

}
