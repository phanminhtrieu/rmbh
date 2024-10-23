using rmbh_backoffice.VC;
using rmbh_backoffice.VC.Controllers;
using rmbh_backoffice.VC.Views;

namespace rmbh_backoffice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Form1());
            AppManager.Start<LoginController>();
        }
    }
}