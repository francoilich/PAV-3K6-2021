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
    public partial class Frm_editar_usuario : Form
    {
        public Frm_editar_usuario()
        {
            InitializeComponent();
        }

        private void btn_aceptar_edit_Click(object sender, EventArgs e)
        {
            NE_usuario usuario = new NE_usuario();
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("El nombre de usuario no debe estar vacio");
                txt_nombre.Focus();
                return;
            }
            if (txt_contraseña.Text == "")
            {
                MessageBox.Show("La contraseña no debe puede estar vacia");
                txt_nombre.Focus();
                return;
            }
            if (usuario.validar_Usuario_Por_Nombre(txt_nombre.Text) == NE_usuario.ResultadoValidacion.existe)
            {
                usuario.editar_usuario(txt_nombre.Text, txt_contraseña.Text, cmb_Roles.SelectedValue.ToString(), txt_email.Text);
                MessageBox.Show("El Usuario con nombre " + txt_nombre.Text + " modificado");
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario no existe agreguelo con el boton agregar");
                this.Close();
            }
        }

        private void Frm_editar_usuario_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "Select rol_usuario_nombre ,rol_usuario_id from rol_usuario";
            tabla = _BD.Ejecutar_Select(sql);
            cmb_Roles.CargarCombo();
        }
    }
}
