using System;
using System.Windows.Forms;

namespace LoginApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Run the application with Form1 as the startup form
            Application.Run(new Form1());
        }
    }
}