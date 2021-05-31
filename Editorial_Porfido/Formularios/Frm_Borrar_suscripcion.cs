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

namespace Editorial_Porfido.Formularios
{
    public partial class Frm_borrar_suscripcion : Form
    {
        public string id_suscriptor { get; set; }
        public Frm_borrar_suscripcion()
        {
            InitializeComponent();
        }

        private void Frm_borrar_suscripcion_Load(object sender, EventArgs e)
        {
            NE_Suscripcion suscripcion = new NE_Suscripcion();
            MostrarDatos(suscripcion.recuperarPorIdSuscriptor(int.Parse(id_suscriptor)));
        }
        public void MostrarDatos(DataTable tabla)
        {
            txt_id_suscripcion.Text = tabla.Rows[0]["id_suscriptor"].ToString();
            txt_cod_revista.Text = tabla.Rows[0]["codigo_interno_revista"].ToString();
            txt_fecha_inicio.Text = tabla.Rows[0]["fecha_inicio"].ToString();
            txt_fecha_fin.Text = tabla.Rows[0]["fecha_fin"].ToString();
            txt_forma_pago.Text = tabla.Rows[0]["id_forma_pago"].ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            NE_Suscripcion suscripcion = new NE_Suscripcion() {Pp_id_suscriptor = id_suscriptor.ToString() };

            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                suscripcion.Borrar();
                MessageBox.Show("Se borró correctamente la Suscripcion");
                this.Close();

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
