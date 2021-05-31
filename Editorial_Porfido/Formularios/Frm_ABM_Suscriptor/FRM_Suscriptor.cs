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

namespace Editorial_Porfido.Formularios.Frm_ABM_Suscriptor
{
    public partial class FRM_Suscriptor : Form
    {
        public string Id_suscriptor { get; set; }
        public FRM_Suscriptor()
        {
            InitializeComponent();
        }

        private void FRM_Suscriptor_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "select * from Suscriptor";
            tabla = _BD.Ejecutar_Select(sql);
            grid_suscriptor.DataSource = tabla;
        }

        private void btn_guardar_suscriptor_Click(object sender, EventArgs e)
        {
            NE_Suscriptor suscriptor = new NE_Suscriptor();
            suscriptor.Pp_id_suscriptor = txt_id_suscriptor.Text;
            suscriptor.Pp_nombre = txt_nombre_suscriptor.Text;
            suscriptor.Pp_apellido = txt_apellido_suscriptor.Text;
            suscriptor.Pp_dni = txt_dni_suscriptor.Text;
            suscriptor.Pp_codpostal = txt_codpostal_suscriptor.Text;
            suscriptor.Pp_id_localidad = txt_localidad_suscriptor.Text;
            suscriptor.Pp_barrio = txt_barrio_suscriptor.Text;
            suscriptor.Pp_calle = txt_calle_suscriptor.Text;
            suscriptor.Pp_numero = txt_numero_suscriptor.Text;


            suscriptor.Insertar();
            MessageBox.Show("Se Guardo correctamente el Suscriptor , Actualiza tus nuevos Datos8");
            
        }

        private void btn_actualizar_suscriptor_Click(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "select * from Suscriptor";
            tabla = _BD.Ejecutar_Select(sql);
            grid_suscriptor.DataSource = tabla;
        }

        private void btn_salir_suscriptor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_suscriptor_Click(object sender, EventArgs e)
        {
            FRM_Borrar_Suscriptor borrar = new FRM_Borrar_Suscriptor();
            borrar.Id_suscriptor = Id_suscriptor;
            borrar.ShowDialog();
        }

        private void grid_suscriptor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_suscriptor = grid_suscriptor.CurrentRow.Cells["id_suscriptor"].Value.ToString();
        }

        private void btn_editar_suscriptor_Click(object sender, EventArgs e)
        {
            FRM_Modificar_Suscriptor modi = new FRM_Modificar_Suscriptor();
            modi.Id_suscriptor = Id_suscriptor;
            modi.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
