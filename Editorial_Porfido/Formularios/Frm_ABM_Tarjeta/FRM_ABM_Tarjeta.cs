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

namespace Editorial_Porfido.Formularios.Frm_ABM_Tarjeta
{
    public partial class FRM_ABM_Tarjeta : Form

    {
        public string id_tarjeta { get; set; }
        public FRM_ABM_Tarjeta()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_numero_buscar.Clear();
        }

        private void FRM_ABM_Tarjeta_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT * FROM Tarjeta";
            tabla = _BD.Ejecutar_Select(sql);
            dgvtarjeta.DataSource = tabla;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Tarjeta _tarjeta = new NE_Tarjeta();
                _tarjeta.Pp_id_tarjeta = txt_id_tarjeta.Text;
                _tarjeta.Pp_numero = txt_numero.Text;
                _tarjeta.Pp_fecha_venc = txt_fecha.Text;
                _tarjeta.Pp_id_suscriptor = txt_id_suscriptor.Text;
                _tarjeta.Pp_id_tipo_tarjeta = txt_id_tipo_tarjeta.Text;
                


                _tarjeta.Insertar();
                MessageBox.Show("tarjeta cargada con exito");
                return;
            }
            else
            {
                MessageBox.Show("Hubo un error al cargarse la tarjeta!");
                return;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = "select * from Tarjeta";
            tabla = _BD.Ejecutar_Select(sql);
            dgvtarjeta.DataSource = tabla;
        }

        private void dgvtarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();

            string sql;

            sql = @"Select * from Tarjeta where id_tarjeta = " + txt_id_tarjeta.Text;

            dgvtarjeta.DataSource = _BD.Ejecutar_Select(sql);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            FRM_Modificar_Tarjeta modificar = new FRM_Modificar_Tarjeta();
            modificar.id_tarjeta = id_tarjeta;
            modificar.ShowDialog();
        }
    }
}
