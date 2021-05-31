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

namespace Editorial_Porfido.Formularios
{
    public partial class Frm_Modificar_suscripcion : Form
    {
        public string id_suscriptor { get; set; }
        public Frm_Modificar_suscripcion()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_suscripcion_Load(object sender, EventArgs e)
        {
            NE_Suscripcion suscripcion = new NE_Suscripcion();
            MostrarDatos(suscripcion.recuperarPorIdSuscriptor(int.Parse(id_suscriptor.ToString())));
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

            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Suscripcion suscripcion = new NE_Suscripcion();
                suscripcion.Pp_id_suscriptor = txt_id_suscripcion.Text;
                suscripcion.Pp_cod_revista = txt_cod_revista.Text;
                suscripcion.Pp_fecha_inicio = txt_fecha_inicio.Text;
                suscripcion.Pp_fecha_fin = txt_fecha_fin.Text;
                suscripcion.Pp_id_forma_pago = txt_forma_pago.Text;

                suscripcion.Modificar();

            }
            else
            {
                return;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
