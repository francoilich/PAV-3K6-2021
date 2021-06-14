using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Formularios.ABM_Usuarios;
using Editorial_Porfido.Formularios.Frm_ABM_Revista;
using Editorial_Porfido.Formularios.Frm_ABM_Pedido;
using Editorial_Porfido.Formularios.Frm_ABM_Kiosco;
using Editorial_Porfido.Formularios.Frm_ABM_Suscriptor;
using Editorial_Porfido.Formularios.Frm_Liquidacion_de_Sueldos;



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
            //Application.Run(new Frm_Escritorio());
            // Application.Run(new Frm_Login());
            //Application.Run(new ABM_Usuarios());
            //Application.Run(new FRM_ABM_Revista());
            //Application.Run(new FRM_Modificar_Revista());
            //Application.Run(new FRM_Borrar_Revista());
            //Application.Run(new FRM_ABM_Pedido());
            //Application.Run(new FRM_Borrar_Pedido());
            //Application.Run(new FRM_Modificar_Pedido());
            //Application.Run(new FRM_Modificar_Pedido());
            //Application.Run(new FRM_ABM_Kiosco());
            //Application.Run(new FRM_Suscriptor());
            //Application.Run(new FRM_LiquidacionSueldos());
           Application.Run(new Frm_Recuperar_Liquidacion());



        }
    }
}
