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
//using System.Windows.Forms


namespace Editorial_Porfido.Formularios.Frm_ABM_Revista
{
    public partial class FRM_Modificar_Revista : Form
    {

        public string Codigo_interno { get; set; }

        public FRM_Modificar_Revista()
        {
            InitializeComponent();
        }

        private void FRM_Modificar_Revista_Load(object sender, EventArgs e)
        {
            NE_Revista revista = new NE_Revista();
            MostrarDatos(revista.RecuperarXCodigo(Codigo_interno));

        }
        public void MostrarDatos(DataTable tabla)
            
        {   txt_codigo.Text=tabla.Rows[0]["codigo_interno"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_fecha.Text = tabla.Rows[0]["fecha_inicio_sesion"].ToString();
            txt_frecuencia.Text = tabla.Rows[0]["id_tipo_frecuencia"].ToString();
            txt_rubro.Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_id_numero_edi.Text = tabla.Rows[0]["id_numero_edicion"].ToString();
        }

        private void btn_guardar_mod_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Revista revista = new NE_Revista();
                revista.Pp_codigo = txt_codigo.Text;
                revista.Pp_nombre = txt_nombre.Text;
                revista.Pp_fecha = txt_fecha.Text;
                revista.Pp_frecuencia = txt_frecuencia.Text;
                revista.Pp_rubro = txt_rubro.Text;
                revista.Pp_id_numero_edi = txt_id_numero_edi.Text;

                revista.Modificar();
                MessageBox.Show("Se modifico correctamente la revista");

            }            else
            {
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
