using System;
using System.Windows.Forms;
using System.Threading;


namespace AmazeLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "amaze_launcher", out createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new AmazeLauncher());
                }
                else
                {
                    _ = MessageBox.Show("An instance of the launcher is already running!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
