using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Formularios.Frm_ABM_Pedido;
using Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria;
using Editorial_Porfido.Formularios;
using Editorial_Porfido.Formularios.Frm_ABM_Revista;
using Editorial_Porfido.Formularios.Frm_Suscripcion;

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
            //Application.Run(new Plan());
            //Application.Run(new Frm_Asignacion_Regalo());
            //Application.Run(new Recuperar_Pedido());
            Application.Run(new Frm_Suscripcion());
            // Application.Run(new Frm_suscripcion());
            //Application.Run(new Frm_subscriptor());

        }
    }
}
