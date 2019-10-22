using System;
using System.Threading;
using System.Windows.Forms;

namespace Barbar.HostsSwitcher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var language = System.Globalization.CultureInfo.CurrentCulture;;

            Properties.Resources.Culture = language;
            Thread.CurrentThread.CurrentCulture = language;
            Thread.CurrentThread.CurrentUICulture = language;

            bool createdNew = false;
            Mutex mutex = null;
            try
            {
                mutex = new Mutex(true, "HostsSwitcher", out createdNew);
            }
            catch
            {
            }
            if (mutex == null || !createdNew)
            {
                MessageBox.Show(Properties.Resources.HostsSwitchStartErrorMessage, Properties.Resources.HostsSwitchStartErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Application.Run(new FormMain());
            }
            finally
            {
                mutex.Close();
            }
        }
    }
}
