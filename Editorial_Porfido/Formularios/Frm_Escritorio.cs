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
    //int userId = 0;

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
           // NE_usuario usuario = new NE_usuario();
            //userId
            login.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void revistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
