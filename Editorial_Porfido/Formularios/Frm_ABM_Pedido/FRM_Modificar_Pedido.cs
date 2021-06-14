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


namespace Editorial_Porfido.Formularios.Frm_ABM_Pedido
{
    public partial class FRM_Modificar_Pedido : Form
    {
        
        public string id_Pedido { get; set; }
        public FRM_Modificar_Pedido()
        {
            InitializeComponent();
        }

        private void FRM_Modificar_Pedido_Load(object sender, EventArgs e)
        {
            NE_Pedido pedido = new NE_Pedido();
            MostrarDatos(pedido.RecuperarXid_Pedido(id_Pedido));
        }
        public void MostrarDatos(DataTable tabla)
        {
            txt_id_pedido.Text = tabla.Rows[0]["id_pedido"].ToString();
            txt_fecha_pedido.Text = tabla.Rows[0]["fecha_pedido"].ToString();
            txt_fecha_fin.Text = tabla.Rows[0]["fecha_fin"].ToString();
            txt_codigo_interno.Text = tabla.Rows[0]["codigo_interno"].ToString();
            txt_cant.Text = tabla.Rows[0]["cantidad"].ToString();
            txt_precio_uni.Text = tabla.Rows[0]["precio_unitario"].ToString();
            txt_precio_total.Text = tabla.Rows[0]["precio_total"].ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Pedido pedido = new NE_Pedido();
                pedido.Pp_id_pedido= txt_id_pedido.Text;
                pedido.Pp_fecha_pedido = txt_fecha_pedido.Text;
                pedido.Pp_fecha_fin = txt_fecha_fin.Text;
                pedido.Pp_codigo_interno_r= txt_codigo_interno.Text;
                pedido.Pp_cant = txt_cant.Text;
                pedido.Pp_precio_total = txt_precio_total.Text;

                pedido.Modificar();

            }
            else
            {
                return;
            }
        }

        private void btn_salir_mod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
