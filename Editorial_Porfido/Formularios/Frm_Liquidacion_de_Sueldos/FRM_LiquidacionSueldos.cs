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

namespace Editorial_Porfido.Formularios.Frm_Liquidacion_de_Sueldos
{
    public partial class FRM_LiquidacionSueldos : Form
    {
        NE_Asignaciones asignaciones = new NE_Asignaciones();
        NE_Descuento descuento = new NE_Descuento();
        NE_usuario usuario = new NE_usuario();
        NE_Perfil perfil = new NE_Perfil();
        NE_SueldoPerfilHistorico historico = new NE_SueldoPerfilHistorico();
        TratamientosEspeciales especiales = new TratamientosEspeciales();
        Grid01 grid01 = new Grid01();
        NE_SueldosLiquidacion sueldos = new NE_SueldosLiquidacion();

        public FRM_LiquidacionSueldos()
        { 
            InitializeComponent();
        }

        private void FRM_LiquidacionSueldos_Load(object sender, EventArgs e)
        {
            grid_asignaciones.Formatear("Id, 50;Nombre, 130;Cantidad, 65;Valor,100");
            grid_descuento.Formatear("Id,50;Nombre, 130;Cantidad, 65;Valor,100");
            cmb_asignaciones.CargarCombo(asignaciones.DatosCombo());
            //cmb_asignaciones.SelectedValue = 3;
            cmb_descuento.CargarCombo(descuento.DatosCombo());
            //cmb_descuento.SelectedIndex = -1;
          
            
           

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_agregar_asigna_Click(object sender, EventArgs e)
        {
            //if (txt_cantidad_asigna.Text == "")
            //{
            //    MessageBox.Show("Falta definir la cantidad");
            //    return;
            //}
            //if (cmb_asignaciones.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Falta seleccionar la asignación");
            //    return;
            //}

            //bool bandera = false;
            //for (int i = 0; i < grid_asignaciones.Rows.Count; i++)
            //{
            //    if (grid_asignaciones.Rows[i].Cells[0].Value.ToString() == cmb_asignaciones.SelectedValue.ToString())
            //    {
            //        bandera = true;
            //    }
            //}
            //if (bandera == true)
            //{
            //    MessageBox.Show("Ya se cargó esta asignación");
            //    return;
            //}

            grid_asignaciones.Rows.Add(
                                        cmb_asignaciones.SelectedValue.ToString()
                                        , cmb_asignaciones.Text
                                        , txt_cantidad_asigna.Text
                                        , asignaciones.RecuperaValor(cmb_asignaciones.SelectedValue.ToString())
                                        );

            //if (txt_sueldo_bruto.Text.Trim() == ",")
            //{
            //     return;
            // }

            txt_sueldo_neto.Text = CalcularNetoAsigna().PadLeft(12 ,' ');


        }

        

        private void cmb_asignaciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
         txt_valor_asignaciones.Text = asignaciones.RecuperaValor(cmb_asignaciones.SelectedValue.ToString()).PadLeft(9, ' ');

        }
        
        public string CompletarNumero(string numero, string mascara)
        {
            int comaMascar = mascara.IndexOf(',', 0);
            int comaNumero = numero.IndexOf(',', 0);
            if (comaNumero < comaMascar)
            {
                numero = numero.PadLeft(comaMascar + 3, ' ');
            }
            return numero;
        }

        private void btn_agregar_descu_Click(object sender, EventArgs e)
        {
            if (txt_cantidad_descu.Text == "")
            {
                MessageBox.Show("Falta definir la cantidad");
                return;
            }
            if (cmb_descuento.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el descuento");
                return;
            }
            grid_descuento.Rows.Add(
                                  cmb_descuento.SelectedValue.ToString()
                                  , cmb_descuento.Text
                                  , txt_cantidad_descu.Text
                                  , descuento.RecuperaValor(cmb_descuento.SelectedValue.ToString())
                                  );
            if (txt_sueldo_bruto.Text.Trim() == ",")
            {
                return;
            }
            txt_sueldo_neto.Text = CalcularNetoDescu().PadLeft(12, ' ');




        }

        //private string CalcularSueldoNeto()
        //{
        //    double  valor = double.Parse(txt_sueldo_bruto.Text) + CalcularNetoAsigna() - CalcularNetoDescu();
        //    return valor.ToString();
        //}

        //private string CalcularSueldoNeto()
        //{
        //    double valor = double.Parse(ltxt_sueldo.Pp_Text.Replace('.', ','))
        //                   + CalculaAsignaciones() - CalculaDescuentos();
        //    return valor.ToString();
        //}

        private void cmb_descuento_SelectionChangeCommitted(object sender, EventArgs e)
        {
             txt_valor_descuentos.Text = descuento.RecuperaValor(cmb_descuento.SelectedValue.ToString()).PadLeft(9, ' ');

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_usuario_id.Text != "")
            {
                LlenarDatosPantalla(usuario.Recuperar_x_Id(txt_usuario_id.Text));
            }

            
        }
        private void LlenarDatosPantalla(DataTable tabla)
        {
            txt_usuario_id.Text = tabla.Rows[0]["usuario_id"].ToString();
            txt_nombre_usuario.Text = tabla.Rows[0][1].ToString();
            txt_nombre.Text = tabla.Rows[0][5].ToString();
            txt_apellido.Text = tabla.Rows[0][6].ToString();
            txt_cuil.Text = tabla.Rows[0][7].ToString();
            txt_perfil.Text = perfil.RecuperaDescripcion(tabla.Rows[0]["rol_usuario"].ToString());
            txt_sueldo_bruto.Text = historico.RecuerarUltimoSueldo(tabla.Rows[0]["rol_usuario"].ToString()).PadLeft(11, ' '); 
            txt_mes.Text = especiales.RecuperarMes();
            txt_año.Text = especiales.RecuperarAño();
           
        }

        private string CalcularNetoAsigna()
        {
            double calculo = 0.00;
            foreach (DataGridViewRow row in grid_asignaciones.Rows)
            {
                calculo = double.Parse(grid_asignaciones.Rows[0].Cells[2].Value.ToString()) *
                           double.Parse(grid_asignaciones.Rows[0].Cells[3].Value.ToString());
            }

            calculo = calculo + double.Parse(txt_sueldo_bruto.Text);
            return calculo.ToString("#.00");


        }
   



        private string CalcularNetoDescu()
        {
            double calculoDescu = 0.00;

            foreach (DataGridViewRow row in grid_descuento.Rows)
            {
                calculoDescu = double.Parse(grid_descuento.Rows[0].Cells[2].Value.ToString()) * double.Parse(grid_descuento.Rows[0].Cells[3].Value.ToString());
            }
            calculoDescu = calculoDescu - double.Parse(txt_sueldo_bruto.Text);
            return calculoDescu.ToString("#.00");
        }


        private void btn_grabar_Click(object sender, EventArgs e)
        {
            sueldos.Id_usuario = txt_usuario_id.Text;
            sueldos.Fecha = txt_Fecha.Text;
            sueldos.Mes = txt_mes.Text;
            sueldos.Anno = txt_año.Text;
            sueldos.Sueldo_bruto = txt_sueldo_bruto.Text;
            sueldos.Insertar(grid_asignaciones, grid_descuento);
        }

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            txt_Fecha.Text = especiales.RecuperarFecha();
        }
    }
}
