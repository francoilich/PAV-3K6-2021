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

namespace Editorial_Porfido.Formularios.Frm_ABM_Suscriptor
{
    public partial class FRM_Modificar_Suscriptor : Form
    {
        public string Id_suscriptor { get; set; }
        public FRM_Modificar_Suscriptor()
        {
            InitializeComponent();
        }

        private void FRM_Modificar_Suscriptor_Load(object sender, EventArgs e)
        {
            NE_Suscriptor suscri = new NE_Suscriptor();
            MostrarDatos(suscri.RecuperarXid(Id_suscriptor));
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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Suscriptor suscriptor = new NE_Suscriptor();
                suscriptor.Pp_id_suscriptor = txt_id_suscriptor.Text;
                suscriptor.Pp_nombre = txt_nombre.Text;
                suscriptor.Pp_apellido = txt_Apellido.Text;
                suscriptor.Pp_dni = txt_DNI.Text;
                suscriptor.Pp_codpostal =txt_codigo_postal.Text;
                suscriptor.Pp_id_localidad = txt_id_localidad.Text;
                suscriptor.Pp_barrio = txt_barrio.Text;
                suscriptor.Pp_calle = txt_calle.Text;
                suscriptor.Pp_numero = txt_numero.Text;


                suscriptor.Modificar();
                MessageBox.Show("Se Modifico correctamente el Suscriptor");
                this.Close();

            }
            else
            {
                return;
            }
        }
    }
}

