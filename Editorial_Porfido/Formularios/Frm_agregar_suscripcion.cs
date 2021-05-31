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
    public partial class Frm_agregar_suscripcion : Form
    {
        public Frm_agregar_suscripcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Suscripcion _Suscripcion = new NE_Suscripcion();
            _Suscripcion.Pp_id_suscriptor = txt_suscripcion.Text;
            _Suscripcion.Pp_cod_revista = txt_cod_revista.Text;
            _Suscripcion.Pp_fecha_inicio = txt_fecha_inicio.Text;
            _Suscripcion.Pp_fecha_fin = txt_fecha_fin.Text;
            _Suscripcion.Pp_id_forma_pago = cmb_forma_pago.SelectedValue.ToString();

            _Suscripcion.Insertar();
            MessageBox.Show("Pedido cargado con exito");
            return;
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void Frm_agregar_suscripcion_Load(object sender, EventArgs e)
        {
            cmb_forma_pago.CargarCombo();
        }

        private void cmb_forma_pago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
