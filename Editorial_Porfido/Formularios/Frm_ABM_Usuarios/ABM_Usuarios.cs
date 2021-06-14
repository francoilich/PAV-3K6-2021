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
            // BE_Acceso_BD _BD = new BE_Acceso_BD();
            // DataTable tabla = new DataTable();

            //string sql;

            // sql = "Select userRoleId , userRoleName from RolUsuario";
            // tabla = _BD.Ejecutar_Select(sql);
            // cmb_Rol.DisplayMember = "useRoleName";
            // cmb_Rol.ValueMember = "userRoleId";
            // cmb_Rol.DataSource = tabla;
            cmb_Roles.CargarCombo();
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_Roles.SelectedIndex = -1;
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
            }
            if (cmb_Roles.SelectedIndex != -1)
            {
                CargarGrilla(usuario.RecuperarXPerfiles(cmb_Roles.SelectedValue.ToString()));//Carga la grilla
                return;//corta la ejecucion
            }
        }
        private void CargarGrilla (DataTable tabla)
        {
            grid_rol.Rows.Clear();
           
            
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    grid_rol.Rows.Add();
                    grid_rol.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre_usuario"].ToString();
                    grid_rol.Rows[i].Cells[1].Value = tabla.Rows[i]["rol_usuario_id"].ToString();
                    grid_rol.Rows[i].Cells[2].Value = tabla.Rows[i]["email_usuario"].ToString();


                }
            
        }
    }
}
