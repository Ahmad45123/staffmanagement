using System;
using System.Windows.Forms;

namespace staffmanagement
{
    static class Program
    {
        public static Main mainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new Main();
            if(!mainForm.IsDisposed)
                Application.Run(mainForm);
        }
    }
}
