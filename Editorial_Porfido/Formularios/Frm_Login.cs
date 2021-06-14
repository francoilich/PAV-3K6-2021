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

namespace Editorial_Porfido
{
    public partial class Frm_Login : Form

    {
        public string Pp_usuario
        {
            get { return txt_usu.Text; }
            set { txt_usu.Text = value; }

        }
        public string Pp_password
        {
            get { return txt_pass.Text; }
            set { txt_pass.Text = value; }

        }


        public Frm_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usu.Text == "")
            {
                MessageBox.Show("El Usuario esta vacio");
                txt_usu.Focus();
                return;
            }
            if (txt_pass.Text == "")
            {

                MessageBox.Show("El Pasword esta vacio");
                txt_pass.Focus();
                return;

            }
            NE_usuario usuario = new NE_usuario();
            if (usuario.ValidarUsuario(txt_usu.Text, txt_pass.Text) == NE_usuario.ResultadoValidacion.existe)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("El Usuario y Password no existen");
                return;
            }







        }
    }
}
