using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Formularios;
using Editorial_Porfido.Negocio;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Formularios.Frm_ABM_Tarjeta
{
    public partial class FRM_Modificar_Tarjeta : Form
    {
        public string id_tarjeta { get; set; }
        public FRM_Modificar_Tarjeta()
        {
            InitializeComponent();
        }

        public void MostrarDatos(DataTable tabla)
        {
            txt_id_tarjeta.Text = tabla.Rows[0]["id_tarjeta"].ToString();
            txt_numero.Text = tabla.Rows[0]["numero"].ToString();
            txt_fecha_venc.Text = tabla.Rows[0]["fecha_venc"].ToString();
            txt_id_suscriptor.Text = tabla.Rows[0]["id_suscriptor"].ToString();
            txt_id_tipo_tarjeta.Text = tabla.Rows[0]["id_tipo_tarjeta"].ToString();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Tarjeta tarjeta = new NE_Tarjeta();
                tarjeta.Pp_id_tarjeta = txt_id_tarjeta.Text;
                tarjeta.Pp_numero = txt_numero.Text;
                tarjeta.Pp_fecha_venc = txt_fecha_venc.Text;
                tarjeta.Pp_id_suscriptor = txt_id_suscriptor.Text;
                tarjeta.Pp_id_tipo_tarjeta = txt_id_tipo_tarjeta.Text;
                

                tarjeta.Modificar();

            }
            else
            {
                return;
            }
        }

        private void FRM_Modificar_Tarjeta_Load(object sender, EventArgs e)
        {
            NE_Tarjeta tarjeta = new NE_Tarjeta();
            MostrarDatos(tarjeta.recuperarPorId_tarjeta(id_tarjeta));
        }
    }
}
