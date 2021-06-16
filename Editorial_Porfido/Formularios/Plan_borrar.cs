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
    public partial class Plan_borrar : Form
    {
        NE_plan plan = new NE_plan();
        public string id_plan { get; set; }
        public Plan_borrar()
        {
            InitializeComponent();
        }

        private void Plan_borrar_Load(object sender, EventArgs e)
        {
            MostrarDatos(plan.recuperarId(id_plan));
        }


        public void MostrarDatos(DataTable tabla)
        {
            txt_id_plan.Text = tabla.Rows[0]["id_plan"].ToString();
            txt_precio.Text = tabla.Rows[0]["precio"].ToString();
            txt_codigo.Text = tabla.Rows[0]["codigo_interno_revista"].ToString();
            date_inicio.Text = tabla.Rows[0]["fecha_inicio"].ToString();
            date_fin.Text = tabla.Rows[0]["fecha_fin"].ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                plan.Pp_id_plan = txt_id_plan.Text;
                plan.Pp_fecha_inicio = date_fin.Text;
                plan.Pp_fecha_fin = date_fin.Text;
                plan.Pp_codigo_interno_r = txt_codigo.Text;
                plan.Pp_precio = txt_precio.Text;

                plan.Borrar();
                MessageBox.Show("Plan eliminado con exito");
                return;
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
