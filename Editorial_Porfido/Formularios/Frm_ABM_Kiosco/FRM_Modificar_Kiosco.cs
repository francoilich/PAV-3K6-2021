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

namespace Editorial_Porfido.Formularios.Frm_ABM_Kiosco
{
    public partial class FRM_Modificar_Kiosco : Form
    {
        public string Id_kiosco { get; set; }
        public FRM_Modificar_Kiosco()
        {
            InitializeComponent();
        }

        private void FRM_Modificar_Kiosco_Load(object sender, EventArgs e)
        {
            NE_Kiosco kiosco = new NE_Kiosco();
            MostrarDatos(kiosco.RecuperarXid(Id_kiosco));
        }

        public void MostrarDatos(DataTable tabla)

        {
            txt_id_kiosco.Text = tabla.Rows[0]["id_kiosco"].ToString();
            txt_nombre_kiosco.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_localidad_kiosco.Text = tabla.Rows[0]["id_localidad"].ToString();
            txt_barrio_kiosco.Text = tabla.Rows[0]["Barrio"].ToString();
            txt_calle_kiosco.Text = tabla.Rows[0]["Calle"].ToString();
            txt_numero_kiosco.Text = tabla.Rows[0]["Numero"].ToString();
            txt_fecha_Kiosco.Text = tabla.Rows[0]["Fecha"].ToString();

        }

        private void btn_guardar_mod_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Kiosco kiosco = new NE_Kiosco();
                kiosco.Pp_id_kiosco = txt_id_kiosco.Text;
                kiosco.Pp_nombre = txt_nombre_kiosco.Text;
                kiosco.Pp_id_localidad = txt_localidad_kiosco.Text;
                kiosco.Pp_barrio = txt_barrio_kiosco.Text;
                kiosco.Pp_calle = txt_calle_kiosco.Text;
                kiosco.Pp_numero = txt_numero_kiosco.Text;
                kiosco.Pp_fecha = txt_fecha_Kiosco.Text;

                kiosco.Modificar();
                this.Close();
            }
            else
            {
                return;
                
            }
        
        }
    }
}
