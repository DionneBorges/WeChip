using DB;
using System;
using System.Windows.Forms;
using WeChip.Views;

namespace WeChip
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WeChipContext context = new WeChipContext();
            DbInitializer.Initialize(context);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
