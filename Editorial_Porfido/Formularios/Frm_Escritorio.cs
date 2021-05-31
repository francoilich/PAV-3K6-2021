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
using Editorial_Porfido.Formularios.Frm_ABM_Pedido;
using Editorial_Porfido.Formularios.Frm_ABM_Revista;
using Editorial_Porfido.Formularios.Frm_ABM_Tarjeta;
using Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria;
using Editorial_Porfido.Formularios;
using Editorial_Porfido.Formularios.Frm_ABM_Kiosco;
using Editorial_Porfido.Formularios.Frm_ABM_Suscriptor;
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

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            FRM_ABM_Pedido _ABM_Pedido = new FRM_ABM_Pedido();
            _ABM_Pedido.ShowDialog();
            _ABM_Pedido.Dispose();
        }

        private void btn_revista_Click(object sender, EventArgs e)
        {
            FRM_ABM_Revista _ABM_Revista = new FRM_ABM_Revista();
            _ABM_Revista.ShowDialog();
            _ABM_Revista.Dispose();
        }

        private void btn_tarjeta_Click(object sender, EventArgs e)
        {
            FRM_ABM_Tarjeta _ABM_Tarjeta = new FRM_ABM_Tarjeta();
            _ABM_Tarjeta.ShowDialog();
            _ABM_Tarjeta.Dispose();
        }

        private void btn_empresa_publicitaria_Click(object sender, EventArgs e)
        {
            FRM_ABM_Empresa_Publicitaria _ABM_Empresa_Publicitaria = new FRM_ABM_Empresa_Publicitaria();
            _ABM_Empresa_Publicitaria.ShowDialog();
            _ABM_Empresa_Publicitaria.Dispose();
        }

        private void btn_suscripcion_Click(object sender, EventArgs e)
        {
            Frm_suscripcion frm_Suscripcion = new Frm_suscripcion();
            frm_Suscripcion.ShowDialog();
            frm_Suscripcion.Dispose();
        }

        private void btm_kiosco_Click(object sender, EventArgs e)
        {
            FRM_ABM_Kiosco _ABM_Kiosco = new FRM_ABM_Kiosco();
            _ABM_Kiosco.ShowDialog();
            _ABM_Kiosco.Dispose();
        }

        private void btn_suscriptor_Click(object sender, EventArgs e)
        {
            FRM_Suscriptor _Suscriptor = new FRM_Suscriptor();
            _Suscriptor.ShowDialog();
            _Suscriptor.Dispose();
        }
    }
}
