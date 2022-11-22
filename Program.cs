using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEstacionamiento
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        ///Se crea la clase en Program.cs para manipular ventana Usuario y Admin sin cerrar programa.
        public static Inicio Inicio;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Inicio = new Inicio());
        }
    }
}
