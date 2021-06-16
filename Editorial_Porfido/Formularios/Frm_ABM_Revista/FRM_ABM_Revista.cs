using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Clasess;
using Editorial_Porfido.Negocio;

namespace Editorial_Porfido.Formularios.Frm_ABM_Revista
{
    public partial class FRM_ABM_Revista : Form
    {
        public string Codigo_interno { get;set; }

        public FRM_ABM_Revista()
        {
            InitializeComponent();
          
        }

        public void grid_revista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo_interno = grid_revista.CurrentRow.Cells["codigo_interno"].Value.ToString();
            

        }

        private void FRM_ABM_Revista_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "Select * from Revista"; 
             tabla = _BD.Ejecutar_Select(sql);
            grid_revista.DataSource = tabla;
          
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Revista revista = new NE_Revista();
                revista.Pp_codigo = txt_codigo.Text;
                revista.Pp_nombre = txt_nombre.Text;
                revista.Pp_fecha = txt_fecha.Text;
                revista.Pp_frecuencia = txt_frecuencia.Text;
                revista.Pp_rubro = txt_rubro.Text;
                revista.Pp_id_numero_edi = txt_id_numero_edi.Text;
                
                revista.Insertar();
                MessageBox.Show("Revista guardada con exito!");
                return;
            }
            else
            {
                return;
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            FRM_Modificar_Revista modificar = new FRM_Modificar_Revista();
            modificar.Codigo_interno = Codigo_interno;
            modificar.ShowDialog();
        }

		private void btn_Eliminar_Click(object sender, EventArgs e)
		{
            FRM_Borrar_Revista borrar = new FRM_Borrar_Revista();
            borrar.Codigo_interno = Codigo_interno;
            borrar.ShowDialog();
		}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "Select * from Revista";
            tabla = _BD.Ejecutar_Select(sql);
            grid_revista.DataSource = tabla;
        }

        private void btn_plan_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.ShowDialog();
            plan.Dispose();
        }
    }
}
