using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FSKI_ferramenta_de_competição
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
            Application.Run(new FSKI_Principal());
        }
    }
}
