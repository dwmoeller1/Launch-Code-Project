using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Structure_helper
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
            Application.Run(new StartScrn());
        }

        static public Job CurrentJob { get; set; }
        static public StartScrn StartScrn { get; set; }
        static public Connections Connections { get; set; }
    }
}
