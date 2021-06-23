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
using Microsoft.Reporting.WinForms;

namespace Editorial_Porfido.Reportee
{
    public partial class ReportePedidos : Form
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        NE_Revista revista = new NE_Revista();
        NE_TipoRubro rubro = new NE_TipoRubro();
        NE_Kiosco kiosco = new NE_Kiosco();

        public ReportePedidos()
        {
            InitializeComponent();
        }

        private void ReportePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_ListaRevistas.Lista' Puede moverla o quitarla según sea necesario.
            this.ListaTableAdapter.Fill(this.DS_ListaRevistas.Lista);
            this.rv_revistas.RefreshReport();
            this.rv_kiosco.RefreshReport();
            this.rv_revistas.RefreshReport();
            this.rv_rubro.RefreshReport();
        }

        private void ArmarReporteUsuario01(DataTable tabla)
        {
            ReportDataSource PaqueteDatos1 = new ReportDataSource("DataSet1", tabla);
            rv_revistas.LocalReport.ReportEmbeddedResource = "Editorial_Porfido.Reportee.ListadoRevistas.rdlc";
            rv_revistas.LocalReport.DataSources.Clear();
            rv_revistas.LocalReport.DataSources.Add(PaqueteDatos1);
            rv_revistas.RefreshReport();
        }

        private void ArmarReporteUsuario02(DataTable tabla)
        {
            ReportDataSource PaqueteDatos1 = new ReportDataSource("DataSet1", tabla);
            rv_kiosco.LocalReport.ReportEmbeddedResource = "Editorial_Porfido.Reportee.ListadoKioscos.rdlc";
            rv_kiosco.LocalReport.DataSources.Clear();
            rv_kiosco.LocalReport.DataSources.Add(PaqueteDatos1);
            rv_kiosco.RefreshReport();
        }

        private void cb_rubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CalcularDatosRevista();
        }

        private void CalcularDatosRevista()
        {
            DataTable tabla = new DataTable();
            if (rb_edicion.Checked == true)
            {
                string[] datos = mtxt_edicionRevista.Pp_Text.Split('-');
                if (_TE.ValidarNumero(datos[0]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El primero valor no es numérico");
                    mtxt_edicionRevista.Focus();
                    return;
                }
                if (_TE.ValidarNumero(datos[1]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El segundo valor no es numérico");
                    mtxt_edicionRevista.Focus();
                    return;
                }
                ArmarReporteUsuario01(revista.ReporteRevista_RangoEdicion(datos[0], datos[1]));
            }
            if (rb_ID.Checked == true)
            {
                string[] datos = mtxt_IDrevista.Pp_Text.Split('-');
                if (_TE.ValidarNumero(datos[0]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El primero valor no es numérico");
                    mtxt_IDrevista.Focus();
                    return;
                }
                if (_TE.ValidarNumero(datos[1]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El segundo valor no es numérico");
                    mtxt_IDrevista.Focus();
                    return;
                }
                ArmarReporteUsuario01(revista.ReporteRevista_RangoID(datos[0], datos[1]));
            }
            if (rb_todos.Checked == true)
            {
                tabla = revista.ReporteRevista_Todos();
                ArmarReporteUsuario01(tabla);
            }
            if (rb_precio.Checked == true)
            {
                string[] datos = mtxt_PrecioREvista.Pp_Text.Split('-');
                if (_TE.ValidarNumero(datos[0]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El primero valor no es numérico");
                    mtxt_PrecioREvista.Focus();
                    return;
                }
                if (_TE.ValidarNumero(datos[1]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El segundo valor no es numérico");
                    mtxt_PrecioREvista.Focus();
                    return;
                }
                ArmarReporteUsuario01(revista.ReporteRevista_RangoPrecio(datos[0], datos[1]));
            }
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //cb_rubro.CargarCombo(rubro.DatosCombo);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (rb_KioscoBuscarID.Checked == true)
            {
                string[] datos = mtxt_KioscoID.Pp_Text.Split('-');
                if (_TE.ValidarNumero(datos[0]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El primero valor no es numérico");
                    mtxt_KioscoID.Focus();
                    return;
                }
                if (_TE.ValidarNumero(datos[1]) == TratamientosEspeciales.Resultado.error)
                {
                    MessageBox.Show("El segundo valor no es numérico");
                    mtxt_KioscoID.Focus();
                    return;
                }
                ArmarReporteUsuario02(kiosco.ReporteKiosco_RangoId(datos[0], datos[1]));
            }
            if (rb_KioscoTodos.Checked == true)
            {
                tabla = kiosco.ReporteKiosco_Todos();
                ArmarReporteUsuario02(tabla);
            }
            if (rb_KioscoLetra.Checked == true)
            {
                ArmarReporteUsuario02(kiosco.ReporteKiosco_Letra(mtxt_KioscoLetra.Pp_Text));
            }
            if (rb_KioscoBarrio.Checked == true)
            {
                ArmarReporteUsuario02(kiosco.ReporteKiosco_Barrio(mtxt_KioscoBarrio.Pp_Text));
            }
        }

        private void btn_calcularRubro_Click(object sender, EventArgs e)
        {
            //ReportDataSource dato = new ReportDataSource("DataSet1", revista.RevistaPorRubro(Exp_rubro.Pp_Text));
            //rv_rubro.LocalReport.ReportEmbeddedResource = "Editorial_Porfido.Reportee.FrecuenciaRubro.rdlc";
            //string[] comp = Txt_Fecha05.Pp_Text.Split('/');
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("Rp01", "Mes: " + comp[1] + " Año: " + comp[2]);
            //rv_rubro.LocalReport.SetParameters(parametros);
            //rv_rubro.LocalReport.DataSources.Clear();
            //rv_rubro.LocalReport.DataSources.Add(dato);
            //rv_rubro.RefreshReport();

            //BE_Acceso_Datos_T _BD = new BE_Acceso_Datos_T();

            //ReportDataSource datos = new ReportDataSource("ejemplo", sueldo.CalculoEstadisticoUnSueldo(Txt_fecha04.Pp_Text, Exp_usuario04.Pp_Text));
            //rv04.LocalReport.ReportEmbeddedResource = "clase12.Formularios.LiquidacionSueldos.Report3.rdlc";
            //ReportParameter[] parametros = new ReportParameter[2];
            //parametros[0] = new ReportParameter("Rp00", _BD.Fecha());
            //parametros[1] = new ReportParameter("Rp01", "Análisis Estadístico de Asignaciones y Descuentos para "
            //                                  + Txt_fecha04.Pp_Text.Substring(3) + " del usuario " + Exp_usuario04.Pp_descriptor);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
