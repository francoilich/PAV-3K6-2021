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

namespace Editorial_Porfido.Formularios.Frm_ABM_Kiosco
{
    public partial class FRM_ABM_Kiosco : Form
    {
        public string Id_kiosco { get; set; }
        public FRM_ABM_Kiosco()
        {
            InitializeComponent();
        }

        private void FRM_ABM_Kiosco_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "Select * from Kiosco";
            tabla = _BD.Ejecutar_Select(sql);
            grid_kiosco.DataSource = tabla;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "Select * from Kiosco";
            tabla = _BD.Ejecutar_Select(sql);
            grid_kiosco.DataSource = tabla;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Kiosco kiosco = new NE_Kiosco();
                kiosco.Pp_id_kiosco = txt_id_kiosco.Text;
                kiosco.Pp_nombre = txt_nombre_kiosco.Text;
                kiosco.Pp_id_localidad = txt_localidad_kiosco.Text;
                kiosco.Pp_barrio = txt_barrio_kiosco.Text;
                kiosco.Pp_calle = txt_calle_kiosco.Text;
                kiosco.Pp_numero = txt_numero_kiosco.Text;
                kiosco.Pp_fecha = txt_fecha_Kiosco.Text;

                kiosco.Insertar();
            }
            else
            {
                return;
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            FRM_Borrar_Kiosco borrar = new FRM_Borrar_Kiosco();
            borrar.Id_kiosco =Id_kiosco;
            borrar.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            FRM_Modificar_Kiosco modificar = new FRM_Modificar_Kiosco();
            modificar.Id_kiosco = Id_kiosco;
            modificar.ShowDialog();
        }

        private void grid_kiosco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_kiosco = grid_kiosco.CurrentRow.Cells["id_kiosco"].Value.ToString();
        }
    }
}

