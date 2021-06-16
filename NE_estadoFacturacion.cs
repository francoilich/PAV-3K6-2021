using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_estadoFacturacion
    {
        BE_Acceso_BD_Transacciones _BDT = new BE_Acceso_BD_Transacciones();

        public EstructuraComboBox DatosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();
            edc.Value = "id_estado";
            edc.Display = "n_estado";
            edc.Sql = "SELECT * FROM Estadios";
            edc.Tabla = _BDT.EjecutarSelect(edc.Sql);
            return edc;
        }

        public string NombreCodigo(string codigo)
        {
            return _BDT.EjecutarSelect("SELECT nombre FROM Revista WHERE codigo_interno = " + codigo).Rows[0][0].ToString();
        }

        public string PrecioRevista(string codigo)
        {
            return _BDT.EjecutarSelect("SELECT precio FROM Revista WHERE codigo_interno = " + codigo).Rows[0][0].ToString();
        }


        //public string RecuperaValor(string id)
        //{
        //    return _BDT.EjecutarSelect("SELECT monto FROM descuentos WHERE id_descuento = " + id).Rows[0][0].ToString();
        //}
    }
}