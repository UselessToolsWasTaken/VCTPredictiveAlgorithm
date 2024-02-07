using System;
using System.Windows.Forms;

namespace VCTWinnerPredictor
{
    internal static class Program
    {
        [MTAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();

            Application.Run(form);
        }
    }
}
