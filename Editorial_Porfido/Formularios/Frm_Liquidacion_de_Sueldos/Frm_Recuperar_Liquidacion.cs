using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Clasess;
using Editorial_Porfido.Negocio;

namespace Editorial_Porfido.Formularios.Frm_Liquidacion_de_Sueldos
{
     
    public partial class Frm_Recuperar_Liquidacion : Form
    {
        NE_SueldosLiquidacion liquidacion = new NE_SueldosLiquidacion();
        public Frm_Recuperar_Liquidacion()
        {
            InitializeComponent();
        }

        private void Frm_Recuperar_Liquidacion_Load(object sender, EventArgs e)
        {
            Grid01.Formatear("id,75; Apellido, 100; Nombres, 150; Sueldo Bruto, 100; Mes, 75; Año, 75");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            FRM_ModificacionSueldos modificar = new FRM_ModificacionSueldos();
            modificar.Id_usuario = Grid01.CurrentRow.Cells[0].Value.ToString();
            modificar.Mes= Grid01.CurrentRow.Cells[4].Value.ToString();
            modificar.Anno= Grid01.CurrentRow.Cells[5].Value.ToString();
            modificar.Sueldo_bruto= Grid01.CurrentRow.Cells[3].Value.ToString();
            modificar.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Grid01.Cargar(liquidacion.SueldosLiquidados(txt_id_usuario.Text, txt_mes.Text, txt_anno.Text));
        }
    }
}
