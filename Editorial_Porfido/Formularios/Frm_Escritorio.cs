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
using Editorial_Porfido.Formularios.ABM_Usuarios;

namespace Editorial_Porfido
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            
           MessageBox.Show("Usuario = " +  login.Pp_usuario +  "Password= " +  login.Pp_password);
            login.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_Usuarios usuarios = new ABM_Usuarios();
            usuarios.ShowDialog();
            DataTable tabla = new DataTable();
            usuarios.Dispose();
        }
    }
}
