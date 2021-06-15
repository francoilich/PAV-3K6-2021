using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Formularios.Frm_ABM_Pedido;
using Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria;
using Editorial_Porfido.Formularios;

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
            //Application.Run(new FRM_ABM_Pedido());
            //Application.Run(new Recuperar_Pedido());
            //Application.Run(new Detalle_pedido());
            //Application.Run(new Frm_Login());
            Application.Run(new Frm_Escritorio());
            //Application.Run(new Frm_suscripcion());
            //Application.Run(new Frm_subscriptor());
        }
    }
}
