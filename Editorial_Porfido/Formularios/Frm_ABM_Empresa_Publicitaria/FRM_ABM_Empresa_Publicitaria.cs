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

namespace Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria
{
    public partial class FRM_ABM_Empresa_Publicitaria : Form
    {
        public string cuit_empresa { get; set; }
        public FRM_ABM_Empresa_Publicitaria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cuit_empresa = grid_empresa_publicitaria.CurrentRow.Cells["cuit_empresa"].Value.ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_cuit_buscar.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ABM_Empresa_Publicitaria_Load(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT * FROM Empresa_Publicit";
            tabla = _BD.Ejecutar_Select(sql);
            grid_empresa_publicitaria.DataSource = tabla;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Empresa_Publicitaria _Empresa_Publicitaria = new NE_Empresa_Publicitaria();
                _Empresa_Publicitaria.Pp_cuit= txt_cuit.Text;
                _Empresa_Publicitaria.Pp_nombre = txt_nombre.Text;
                _Empresa_Publicitaria.Pp_calle = txt_calle.Text;
                _Empresa_Publicitaria.Pp_numero_calle = txt_numero_calle.Text;
                _Empresa_Publicitaria.Pp_fecha_inicio = txt_fecha_inicio.Text;
                _Empresa_Publicitaria.Pp_id_ciudad = txt_numero_calle.Text;

                _Empresa_Publicitaria.Insertar();
                MessageBox.Show("Datos cargados con exito!");
                return;
            }
            else
            {
                return;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            BE_Acceso_BD _BD = new BE_Acceso_BD();
            DataTable tabla = new DataTable();
            string sql;
            sql = "SELECT * FROM Empresa_Publicit";
            tabla = _BD.Ejecutar_Select(sql);
            grid_empresa_publicitaria.DataSource = tabla;
            NE_Empresa_Publicitaria _Empresa_Publicitaria = new NE_Empresa_Publicitaria();
            txt_cuit.Clear();
            txt_nombre.Clear();
            txt_calle.Clear();
            txt_numero_calle.Clear();
            txt_fecha_inicio.Clear();
            txt_ciudad.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Empresa_Publicitaria empresa_Publicitaria = new NE_Empresa_Publicitaria();
            grid_empresa_publicitaria.DataSource = empresa_Publicitaria.recuperarPorCuit((txt_cuit_buscar.Text));
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //FRM_Borrar_Empresa_Publicitaria borrar_Empresa_Publicitaria = new FRM_Borrar_Empresa_Publicitaria();
            //borrar_Empresa_Publicitaria.cuit_empresa = cuit_empresa;
            //borrar_Empresa_Publicitaria.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            FRM_Modificar_Empresa_Publicitaria modificar = new FRM_Modificar_Empresa_Publicitaria();
            modificar.cuit_empresa = cuit_empresa;
            modificar.ShowDialog();
        }
    }
}
