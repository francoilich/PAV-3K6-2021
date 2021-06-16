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

namespace Editorial_Porfido.Formularios.Frm_ABM_Revista
{
    public partial class Frm_Asignacion_Regalo : Form
    {
        NE_Regalo NE_Regalo = new NE_Regalo();
        public string id_precio { get; set; }
        public Frm_Asignacion_Regalo()
        {
            InitializeComponent();
        }

        private void Frm_Asignacion_Regalo_Load(object sender, EventArgs e)
        {
            grid_asignacion_regalo.DataSource = NE_Regalo.RecuperarTodoTipoRegalo();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            grid_plan.DataSource = NE_Regalo.RecuperarTodo();
        }

        private void grid_plan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_precio = grid_plan.CurrentRow.Cells["precio"].Value.ToString();
            int precio = int.Parse(id_precio);
            for(int i=0; i < grid_asignacion_regalo.Rows.Count; i++)
            {
                if (precio <= 1000 || precio < 1500)
                {
                    txt_Regalo.Text = grid_asignacion_regalo.Rows[0].Cells["id_tipo_regalo"].Value.ToString();
                    break;
                }
                if (precio >= 1500 || precio <= 2500)
                {
                    txt_Regalo.Text = grid_asignacion_regalo.Rows[1].Cells["id_tipo_regalo"].Value.ToString();
                    break;
                }
                if(precio >= 1700 || precio <= 3000)
                {
                    txt_Regalo.Text = grid_asignacion_regalo.Rows[4].Cells["id_tipo_regalo"].Value.ToString();
                    break;
                }
                if (precio > 3000 || precio <= 3100)
                {
                    txt_Regalo.Text = grid_asignacion_regalo.Rows[3].Cells["id_tipo_regalo"].Value.ToString();
                    break;
                }
                if (precio >= 3250 || precio <= 4400)
                {
                    txt_Regalo.Text = grid_asignacion_regalo.Rows[2].Cells["id_tipo_regalo"].Value.ToString();
                    break;
                }
                if (precio >= 4500 || precio <= 6000)
                {
                    txt_Regalo.Text = grid_asignacion_regalo.Rows[5].Cells["id_tipo_regalo"].Value.ToString();
                    break;
                }
            }
        }

        private void grid_asignacion_regalo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            grid_asignacion_regalo.DataSource = NE_Regalo.RecuperarTodoTipoRegalo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            NE_Regalo.Pp_id_regalo = txt_id_regalo.Text;
            NE_Regalo.Pp_nombre = txt_nombre.Text;
            NE_Regalo.Pp_descripcion = txt_descripcion.Text;
            NE_Regalo.Pp_tipo_regalo = txt_Regalo.Text;
            NE_Regalo.Pp_plan = txt_plan.Text;
            NE_Regalo.insertar();
            MessageBox.Show("Regalo cargado con exito");
            return;
        }   
    }
}
