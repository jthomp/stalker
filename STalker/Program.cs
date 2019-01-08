using System;
using System.Windows.Forms;

namespace STalker {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.showSplash) {
                Application.Run(new frmSplash());
            }
            Application.Run(new frmSTalker());
        }
    }
}
