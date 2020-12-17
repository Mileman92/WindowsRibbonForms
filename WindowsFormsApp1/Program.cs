using System;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new RibbonForm1());

            Application.Run(new RibbonForm3());


            //RibbonForm1 MAIN
            //RibbonForm2 Planung
            //RibbonForm3 Prufungen
            //RibbonForm4 Apparate
        }
    }
}
