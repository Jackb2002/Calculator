using System;
using System.Windows.Forms;

namespace Calculator
{
    internal static class Program
    {
        public static Form basicCalc;
        public static Form ConvertionCalc;
        public static Form GraphingCalc;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
