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

namespace Editorial_Porfido.Formularios.Frm_ABM_Tarjeta
{
    public partial class FRM_ABM_Tarjeta : Form
    {
        public FRM_ABM_Tarjeta()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_numero_buscar.Clear();
        }

        private void FRM_ABM_Tarjeta_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT * FROM Tarjeta";
            tabla = _BD.Ejecutar_Select(sql);
            dgvtarjeta.DataSource = tabla;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
