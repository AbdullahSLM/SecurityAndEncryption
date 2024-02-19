using System;
using System.Windows.Forms;

namespace SecurityAndEncryption
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen; // توسيط النافذة الرئيسية في وسط الشاشة

            Application.Run(mainForm);
        }

    }
}
