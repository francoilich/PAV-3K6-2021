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


namespace Editorial_Porfido.Formularios.ABM_Usuarios
{
    public partial class ABM_Usuarios : Form
    {
        public ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void ABM_Usuarios_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            string sql;            
        }

        private void grid_rol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_usuario usuario = new NE_usuario();

            if (chk_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = usuario.RecuperarTodo();
                CargarGrilla(tabla);
                return;
            }
            if (txt_Nombre_usuario.Text != "")
            {
                CargarGrilla(usuario.RecuperarXPerfiles(txt_Nombre_usuario.Text));//Carga la grilla
                return;//corta la ejecucion
            }
        }
        private void CargarGrilla (DataTable tabla)
        {
            grid_usuario.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grid_usuario.Rows.Add();
                    grid_usuario.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre_usuario"].ToString();
                    grid_usuario.Rows[i].Cells[1].Value = tabla.Rows[i]["nom_rol_usuario"].ToString();
                    grid_usuario.Rows[i].Cells[2].Value = tabla.Rows[i]["email_usuario"].ToString();
                }
            
        }

        private void cmb_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Usuario agregar_Usuario = new Frm_Agregar_Usuario();
            agregar_Usuario.ShowDialog();
            DataTable tabla = new DataTable();
            agregar_Usuario.Dispose();
        }

        private void txt_Nombre_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Roles_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Usuario borrar_Usuario = new Frm_Borrar_Usuario();
            borrar_Usuario.ShowDialog();
            DataTable tabla = new DataTable();
            borrar_Usuario.Dispose();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Frm_editar_usuario editar_usuario = new Frm_editar_usuario();
            editar_usuario.ShowDialog();
            DataTable tabla = new DataTable();
            editar_usuario.Dispose();
        }

        private void grid_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}