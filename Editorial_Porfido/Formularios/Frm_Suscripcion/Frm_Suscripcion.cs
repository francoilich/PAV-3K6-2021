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

namespace Editorial_Porfido.Formularios.Frm_Suscripcion
{

    public partial class Frm_Suscripcion : Form
    {
        NE_Suscriptor suscriptor = new NE_Suscriptor();
        NE_plan plan = new NE_plan();
        NE_Revista revista = new NE_Revista();
        BE_Acceso_BD BD = new BE_Acceso_BD();
        public Frm_Suscripcion()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            DataTable table = suscriptor.RecuperarXid(txt_id_sus.Text);
            if(table.Rows.Count != 0)
            {
                MostrarDatos(table);
            }
            else
            {
                MessageBox.Show("El usuario con id " + txt_id_sus.Text + " no esta en la base de datos.");
                txt_id_sus.Clear();
            }
            
        }
        public void MostrarDatos(DataTable tabla)
        {
            txt_id_sus.Text = tabla.Rows[0]["id_suscriptor"].ToString();
            txt_nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_dni.Text = tabla.Rows[0]["DNI"].ToString();
            txt_codigo_postal.Text = tabla.Rows[0]["codigo_postal"].ToString();
            txt_barrio.Text = tabla.Rows[0]["Barrio"].ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DataTable tabla = revista.RecuperarXCodigo(txt_cod_revista.Text);
            if(tabla.Rows.Count != 0)
            {
                grid_plan.Rows.Add(date_inicio.Text, date_fin.Text, txt_precio.Text, txt_cod_revista.Text);
                txt_total.Text = CalcularPlan();
            }
            else { 
                MessageBox.Show("El codigo de revista no existe");
                LimpiarDatos();
            }
        }
        private void LimpiarDatos()
        {
            txt_precio.Clear();
            txt_cod_revista.Clear();
        }

        private void Frm_Suscripcion_Load(object sender, EventArgs e)
        {
            cmb_forma_pago.CargarCombo();
        }
        private string CalcularPlan()
        {
            double calculo = 0;
            for(int i = 0; i < grid_plan.Rows.Count ; i++)
            {
                calculo += double.Parse(grid_plan.Rows[i].Cells[2].Value.ToString());
            }
            return calculo.ToString();
        }
    }
}
