using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Editorial_Porfido.Formularios;
using Editorial_Porfido.Negocio;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Formularios.Frm_ABM_Empresa_Publicitaria
{
    public partial class FRM_Modificar_Empresa_Publicitaria : Form
    {
        public string cuit_empresa { get; set; }
        public FRM_Modificar_Empresa_Publicitaria()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(this.Controls) ==
            TratamientosEspeciales.Resultado.correcto)
            {
                NE_Empresa_Publicitaria empresa = new NE_Empresa_Publicitaria();
                empresa.Pp_cuit = txt_cuit.Text;
                empresa.Pp_nombre = txt_nombre.Text;
                empresa.Pp_fecha_inicio = txt_fecha.Text;
                empresa.Pp_calle = txt_calle.Text;
                empresa.Pp_numero_calle = txt_id_numero_calle.Text;
                empresa.Pp_id_ciudad = txt_localidad.Text;

                empresa.Modificar();

            }
            else
            {
                return;
            }
        }

        private void FRM_Modificar_Empresa_Publicitaria_Load(object sender, EventArgs e)
        {
            NE_Empresa_Publicitaria empresa = new NE_Empresa_Publicitaria();
            MostrarDatos(empresa.recuperarPorCuit(cuit_empresa));
        }

        public void MostrarDatos(DataTable tabla)
        {
            txt_cuit.Text = tabla.Rows[0]["cuit_empresa"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_fecha.Text = tabla.Rows[0]["fecha_inicio_actividad"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_id_numero_calle.Text = tabla.Rows[0]["altura"].ToString();
            txt_localidad.Text = tabla.Rows[0]["id_localidad"].ToString();
            
        }
    }
}
