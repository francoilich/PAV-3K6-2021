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
using Editorial_Porfido.Clasess;
using Editorial_Porfido.Formularios;




namespace Editorial_Porfido.Formularios.Frm_ABM_Revista
{
    public partial class FRM_Borrar_Revista : Form
    {

        public string Codigo_interno { get; set; }

        public FRM_Borrar_Revista()
        {
            InitializeComponent();
        }
        

        public void MostrarDatos(DataTable tabla)

        {   txt_codigo.Text= tabla.Rows[0]["codigo_interno"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_fecha.Text = tabla.Rows[0]["fecha_inicio_sesion"].ToString();
            txt_frecuencia.Text = tabla.Rows[0]["id_tipo_frecuencia"].ToString();
            txt_rubro.Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_id_numero_edi.Text = tabla.Rows[0]["id_numero_edicion"].ToString();
        }

        private void btn_guardar_mod_Click(object sender, EventArgs e)
        {
            NE_Revista revista= new NE_Revista() { Pp_codigo=Codigo_interno};
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                revista.Borrar();
                //usuario.Borrar(Id_usuario);
                MessageBox.Show("Se borró correctamente la revista");

            }
        }

        private void FRM_Borrar_Revista_Load(object sender, EventArgs e)
        {
            NE_Revista revista = new NE_Revista();
            MostrarDatos(revista.RecuperarXCodigo(Codigo_interno));

        }

        private void btn_salir_borr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
