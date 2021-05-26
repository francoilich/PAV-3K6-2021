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


namespace Editorial_Porfido.Formularios.Frm_ABM_Pedido
{
    
    public partial class FRM_Borrar_Pedido : Form
    {
        public string id_Pedido { get; set; }
        public FRM_Borrar_Pedido()
        {
            InitializeComponent();
        }

       

        public void MostrarDatos(DataTable tabla)
        {
            txt_id_pedido.Text = tabla.Rows[0]["id_pedido"].ToString();
            txt_fecha_pedido.Text= tabla.Rows[0]["fecha_pedido"].ToString();
            txt_fecha_fin.Text = tabla.Rows[0]["fecha_fin"].ToString();
            txt_codigo_interno.Text = tabla.Rows[0]["codigo_interno"].ToString();
            txt_cant.Text = tabla.Rows[0]["cantidad"].ToString();
            txt_precio_uni.Text = tabla.Rows[0]["precio_unitario"].ToString();
            txt_precio_total.Text = tabla.Rows[0]["precio_total"].ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            NE_Pedido pedido = new NE_Pedido() { Pp_id_pedido = id_Pedido.ToString() };
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                pedido.Borrar();
                //usuario.Borrar(Id_usuario);
                MessageBox.Show("Se borró correctamente el Pedido");

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FRM_Borrar_Pedido_Load(object sender, EventArgs e)
        {
            NE_Pedido pedido = new NE_Pedido();
            MostrarDatos(pedido.RecuperarXid_Pedido(id_Pedido));
        }
    }
}
