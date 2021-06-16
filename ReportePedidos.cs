using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editorial_Porfido.Reportee
{
    public partial class ReportePedidos : Form
    {
        public ReportePedidos()
        {
            InitializeComponent();
        }

        private void ReportePedidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
