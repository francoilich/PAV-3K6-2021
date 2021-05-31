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
using Editorial_Porfido.Formularios;

namespace Editorial_Porfido.Formularios
{
    public partial class Frm_suscripcion : Form
    {
        BE_Acceso_BD _BD = new BE_Acceso_BD();
        NE_Suscripcion suscripcion = new NE_Suscripcion();
        public string id_suscripcion { get; set; }
        public Frm_suscripcion()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
            {
                CargarGrilla(suscripcion.recuperarTodo());
                return;
            }
            if(txt_suscripcion.Text != "")
            {
                CargarGrilla(suscripcion.recuperarPorIdSuscriptor(int.Parse(txt_suscripcion.Text)));
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_suscripcion.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_suscripcion.Rows.Add();
                grid_suscripcion.Rows[i].Cells[0].Value = tabla.Rows[i]["id_suscriptor"].ToString();
                grid_suscripcion.Rows[i].Cells[1].Value = tabla.Rows[i]["codigo_interno_revista"].ToString();
                grid_suscripcion.Rows[i].Cells[2].Value = tabla.Rows[i]["fecha_inicio"].ToString();
                grid_suscripcion.Rows[i].Cells[3].Value = tabla.Rows[i]["fecha_fin"].ToString();
            }

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Frm_agregar_suscripcion frm_Agregar = new Frm_agregar_suscripcion();
            frm_Agregar.ShowDialog();
            frm_Agregar.Dispose();
        }

        private void grid_suscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_suscripcion = grid_suscripcion.CurrentRow.Cells["id_suscriptor"].Value.ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_borrar_suscripcion suscripcion = new Frm_borrar_suscripcion();
            suscripcion.id_suscriptor = id_suscripcion;
            suscripcion.ShowDialog();
            suscripcion.Dispose();
        }

        private void Frm_suscripcion_Load(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_suscripcion frm_Modificar_ = new Frm_Modificar_suscripcion();
            frm_Modificar_.id_suscriptor = id_suscripcion;
            frm_Modificar_.ShowDialog();
            frm_Modificar_.Dispose();
        }
    }
}
