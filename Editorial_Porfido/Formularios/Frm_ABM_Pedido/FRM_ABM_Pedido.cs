using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Clasess;
using Editorial_Porfido.Negocio;

namespace Editorial_Porfido.Formularios.Frm_ABM_Pedido
{
    public partial class FRM_ABM_Pedido : Form
    {
        public string id_Pedido { get; set; }
        public FRM_ABM_Pedido()
        {
            InitializeComponent();
        }

        private void FRM_ABM_Pedido_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "select * from Pedidos";
            tabla = _BD.Ejecutar_Select(sql);
            dgvPedido.DataSource = tabla;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            
            string sql;

            sql = @"Select * from Pedidos where id_pedido = " + txt_num_Pedido.Text ;

            dgvPedido.DataSource = _BD.Ejecutar_Select(sql);
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_num_Pedido.Clear();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Pedido pedido = new NE_Pedido();
                pedido.Pp_id_pedido= txt_id_pedido.Text;
                pedido.Pp_fecha_pedido = txt_fecha_pedido.Text;
                pedido.Pp_fecha_fin = txt_fecha_fin.Text;
                pedido.Pp_codigo_interno_r = txt_codigo_interno.Text;
                pedido.Pp_cant = txt_cant.Text;
                pedido.Pp_precio_uni = txt_precio_uni.Text;
                pedido.Pp_precio_total = txt_precio_total.Text;


                pedido.Insertar();
            }
            else
            {
                return;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "select * from Pedidos";
            tabla = _BD.Ejecutar_Select(sql);
            dgvPedido.DataSource = tabla;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            FRM_Borrar_Pedido borrar = new FRM_Borrar_Pedido();
            borrar.id_Pedido = id_Pedido;
            borrar.ShowDialog();
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Pedido = dgvPedido.CurrentRow.Cells["id_pedido"].Value.ToString();
               
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            FRM_Modificar_Pedido modificar = new FRM_Modificar_Pedido();
            modificar.id_Pedido = id_Pedido;
            modificar.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txt_id_pedido.Clear();
            txt_fecha_pedido.Clear();
            txt_fecha_fin.Clear();
            txt_codigo_interno.Clear();
            txt_cant.Clear();
            txt_precio_uni.Clear();
            txt_precio_total.Clear();
        }
       
    }
}
