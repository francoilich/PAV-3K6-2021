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
    public partial class Frm_Agregar_Usuario : Form
    {
        public Frm_Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_usuario usuario = new NE_usuario();
            if(txt_nombre.Text == "")
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
            if(usuario.validar_Usuario_Por_Nombre(txt_nombre.Text)==NE_usuario.ResultadoValidacion.existe)
            {
                MessageBox.Show("El Usuario con nombre "+txt_nombre.Text+" ya existe!");
                return;
            }
            else
            {
                usuario.Agregar_Usuario(txt_nombre.Text, txt_contraseña.Text, cmb_Roles.SelectedValue.ToString(), txt_email.Text);
                MessageBox.Show("El usuario fue creado con exito!!");
                this.Close();
            }

        }

        private void Frm_Agregar_Usuario_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            cmb_Roles.CargarCombo();
        }
    }
}
