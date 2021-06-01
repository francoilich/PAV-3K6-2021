using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Negocio;

namespace Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria
{
    public partial class FRM_Borrar_Empresa_Publicitaria : Form
    {
        public string cuit_empresa{ get; set; }
        public FRM_Borrar_Empresa_Publicitaria()
        {
            InitializeComponent();
        }
        public void MostrarDatos(DataTable tabla)
        {
            txt_cuit.Text = tabla.Rows[0]["cuit_empresa"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_fecha_inicio.Text = tabla.Rows[0]["fecha_inicio_actividad"].ToString();
            txt_id_localidad.Text = tabla.Rows[0]["id_localidad"].ToString();
            txt_id_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_id_numero_calle.Text = tabla.Rows[0]["altura"].ToString();
        }

        private void FRM_Borrar_Empresa_Publicitaria_Load(object sender, EventArgs e)
        {
            NE_Empresa_Publicitaria _Empresa_Publicitaria = new NE_Empresa_Publicitaria();
            MostrarDatos(_Empresa_Publicitaria.recuperarPorCuit(cuit_empresa));
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            NE_Empresa_Publicitaria _Empresa_Publicitaria = new NE_Empresa_Publicitaria() { Pp_cuit = cuit_empresa.ToString() };
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                _Empresa_Publicitaria.Borrar();
                MessageBox.Show("Se borró correctamente la empresa publicitaria");
                return;

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
