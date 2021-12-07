using System;
using System.Windows.Forms;

namespace DgvFilterPopupDemo
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var x = new Samples();
            Application.Run(x);
        }
    }
}