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

namespace Editorial_Porfido.Formularios.Frm_ABM_Suscriptor
{
    public partial class FRM_Borrar_Suscriptor : Form
    {
        public string Id_suscriptor { get; set; }
        public FRM_Borrar_Suscriptor()
        {
            InitializeComponent();
        }

        

        private void FRM_Borrar_Suscriptor_Load(object sender, EventArgs e)
        {
            NE_Suscriptor suscri = new NE_Suscriptor();
            MostrarDatos(suscri.RecuperarXid(Id_suscriptor));
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            NE_Suscriptor suscri = new NE_Suscriptor() { Pp_id_suscriptor = Id_suscriptor.ToString() };
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                suscri.Borrar();
                
                MessageBox.Show("Se borró correctamente el Suscriptor");
                this.Close();

            }
        }

        public void MostrarDatos(DataTable tabla)
        {
            txt_id_suscriptor.Text = tabla.Rows[0]["id_suscriptor"].ToString();
            txt_nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_Apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_DNI.Text = tabla.Rows[0]["DNI"].ToString();
            txt_codigo_postal.Text = tabla.Rows[0]["codigo_postal"].ToString();
            txt_id_localidad.Text = tabla.Rows[0]["id_localidad"].ToString();
            txt_barrio.Text = tabla.Rows[0]["Barrio"].ToString();
             txt_calle.Text = tabla.Rows[0]["Calle"].ToString();
            txt_numero.Text = tabla.Rows[0]["Numero"].ToString();
        }
    }
}
