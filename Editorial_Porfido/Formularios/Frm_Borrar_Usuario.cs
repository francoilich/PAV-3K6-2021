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

namespace Editorial_Porfido.Formularios
{
    public partial class Frm_Borrar_Usuario : Form
    {
        public Frm_Borrar_Usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_usuario usuario = new NE_usuario();
            if(txt_usuario.Text == "" && checkBox.Checked==false)
            {
                MessageBox.Show("El usuario esta vacio");
                txt_usuario.Focus();
                return;
            }
            if(checkBox.Checked == true && txt_usuario.Text=="")
            {
                usuario.delete_Todos_Usuarios();
                MessageBox.Show("Todos los usuarios fueron borrados");
                this.Close();
                return;
            }
            usuario.delete_Usuario(txt_usuario.Text);
            MessageBox.Show("Usuario " + txt_usuario.Text + " borrado");
            this.Close();
        }
    }
}
