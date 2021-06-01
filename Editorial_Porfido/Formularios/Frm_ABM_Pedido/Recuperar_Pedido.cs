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

namespace Editorial_Porfido.Formularios.Frm_ABM_Pedido
{
    public partial class Recuperar_Pedido : Form
    {
        NE_Pedido pedido = new NE_Pedido();
        NE_usuario usuario = new NE_usuario();

        public Recuperar_Pedido()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {

        }

        private void Recuperar_Pedido_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            cmb_Roles.CargarCombo();
        }

    }
}
