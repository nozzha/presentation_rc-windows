using NozzhaPRC.Core;
using System;
using System.Windows.Forms;

namespace NozzhaPRC
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

            // Detect if the application is new
            // Note: `currAppAPI` default value is `0` which indicates that the application is new
            //  after finishing the `FormTutorial` this value should change to the current `BuildVers.APP_API`
            //  so that application does not open the tutorial form when the user opens the application
            //  for the second time.
            //
            // Note 2: `1` is the `APP_API` version of the first release
            if (Properties.Settings.Default.currAppAPI < 1)
                Application.Run(new FormTutorial());
            else
                Application.Run(new FormMain());
        }
    }
}
