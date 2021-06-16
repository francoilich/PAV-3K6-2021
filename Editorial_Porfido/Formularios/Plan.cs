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
    public partial class Plan : Form
    {
        NE_plan plan = new NE_plan();
        BE_Acceso_Datos_T BD = new BE_Acceso_Datos_T();
        public string id_plan { get; set; }
        public Plan()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            plan.Pp_fecha_inicio = date_inicio.Value.ToString();
            plan.Pp_fecha_fin = date_fin.Value.ToString();
            plan.Pp_precio = txt_precio.Text;
            plan.Pp_codigo_interno_r = txt_codigo.Text;
            plan.Insertar();
            MessageBox.Show("Plan cargado con exito");
            return;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Plan_modificar modificar = new Plan_modificar();
            modificar.id_plan = id_plan;
            modificar.ShowDialog();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            grid011.DataSource = plan.recuperarTodo();
            txt_codigo.Clear();
            txt_precio.Clear();
        }

        private void grid011_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id_plan = grid011.CurrentRow.Cells["id_plan"].Value.ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Plan_borrar borrar = new Plan_borrar();
            borrar.id_plan = id_plan;
            borrar.ShowDialog();

        }
    }
}
