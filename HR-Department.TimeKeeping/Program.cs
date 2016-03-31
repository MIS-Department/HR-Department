using System;
using System.Windows.Forms;

namespace HR_Department.TimeKeeping
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TimeKeepingForms.TimeKeeping());
            Application.Run(new TimeKeepingForms.TimeKeepingMain());
        }
    }
}
