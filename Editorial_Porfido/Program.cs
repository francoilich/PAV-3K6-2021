using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Formularios.ABM_Usuarios;

namespace Editorial_Porfido
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Escritorio());
            Application.Run(new Frm_Login());
            //Application.Run(new ABM_Usuarios());
        }
    }
}
