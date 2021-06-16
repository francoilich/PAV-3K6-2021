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
    public partial class Facturacion_Kiosco : Form
    {
        NE_Kiosco kiosco = new NE_Kiosco();
        NE_Distribucion distribucion = new NE_Distribucion();
        NE_Pedido pedido = new NE_Pedido();
        NE_estadoFacturacion estado = new NE_estadoFacturacion();
        NE_Revista revista = new NE_Revista();
        TratamientosEspeciales tratamientos = new TratamientosEspeciales();

        public Facturacion_Kiosco()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_IDkiosco.Text != "")
            {
                LlenarDatosK(kiosco.RecuperarXid_kiosco(txt_IDkiosco.Text));
            }
            if (txt_IDdistribucion.Text != "")
            {
                LlenarDatosD(distribucion.recuperarXid(txt_IDdistribucion.Text));
                LlenarDatosP(pedido.RecuperarXid_Pedido(txt_IDpedido.Text));
            }
        }

        private void LlenarDatosK(DataTable tabla)
        {
            txt_nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_cuit.Text = tabla.Rows[0]["CUIL"].ToString();
        }

        private void LlenarDatosD(DataTable tabla)
        { 
            txt_fechaDistribucion.Text = tabla.Rows[0]["fecha"].ToString();
            txt_IDpedido.Text = tabla.Rows[0]["id_pedido"].ToString();
           // txt_perfil.Text = perfil.RecuperaDescripcion(tabla.Rows[0]["id_perfil"].ToString());
            //txt_sueldo_bruto.Text = sph.RecuerarUntimoSueldo(txt_id_usuario.Text).PadLeft(11, ' ');
        }

        private void LlenarDatosP(DataTable tabla)
        {
            txt_fechaPedido.Text = tabla.Rows[0]["fecha_pedido"].ToString();
        }

        private void Facturacion_Kiosco_Load(object sender, EventArgs e)
        {
            dgvFacturacion.Formatear("Nombre, 80; Cantidad, 60; Precio unitario, 120, D; Precio total, 100, D");
            cb_estado.CargarCombo(estado.DatosCombo());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Falta definir la cantidad");
                return;
            }
            if (txt_codigoRevista.Text == "")
            {
                MessageBox.Show("Falta definir el codigo interno de la revista");
                return;
            }
            if (cb_estado.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el estado de pedido");
                return;
            }

            bool bandera = false;
            for (int i = 0; i < dgvFacturacion.Rows.Count; i++)
            {
                if (dgvFacturacion.Rows[i].Cells[0].Value.ToString() == cb_estado.SelectedValue.ToString())
                {
                    bandera = true;
                }
            }
            if (bandera == true)
            {
                MessageBox.Show("Ya se cargó este estado");
                return;
            }

            dgvFacturacion.Rows.Add(
                                        estado.NombreCodigo(txt_codigoRevista.Text)                                     
                                        , txt_cantidad.Text
                                        , estado.PrecioRevista(txt_codigoRevista.Text)
                                        //, revista.Pp_precio * txt_cantidad
                                        );
            //if (txt_sueldo_bruto.Text.Trim() == ",")
            //{
            //    return;
            //}

            //txt_sueldoNeto.Text = CalcularNeto().PadLeft(11, ' ');
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    ((TextBox)item).Text = string.Empty;
                }
                if (item.GetType().Name == "MaskedTextBox")
                {
                    ((MaskedTextBox)item).Text = string.Empty;
                }
                if (item.GetType().Name == "Grid1")
                {
                    ((Grid1)item).Rows.Clear();
                }
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_IDkiosco.Text == string.Empty)
            {
                MessageBox.Show("El id: del usuario está vacío ", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IDkiosco.Focus();
                return;
            }
            if (tratamientos.ValidarFecha(txt_fechaDistribucion.Text) == TratamientosEspeciales.Resultado.error)
            {
                MessageBox.Show("No es una fecha valida \n " + txt_fechaDistribucion.Text, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_fechaDistribucion.Focus();
                return;
            }
            if (dgvFacturacion.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron asignaciones", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvFacturacion.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron descuentos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //sueldo.Id_usuario = txt_IDkiosco.Text;
            //sueldo.Fecha = txt_fechaDistribucion.Text;
            //sueldo.Sueldo_bruto = txt_sueldo_bruto.Text;
            //sueldo.Insertar(dgvFacturacion);
        }
    }
}
