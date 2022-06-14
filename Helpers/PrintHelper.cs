using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace Naimushin.Helpers
{
    public static class PrintHelper
    {
        private static string _text;

        public static void Print(string text)
        {
            _text = text; 
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); 
        }
        private static void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
