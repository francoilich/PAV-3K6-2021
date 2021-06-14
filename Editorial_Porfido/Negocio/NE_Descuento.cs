using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_Descuento
    {
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();

        public EstructuraComboBox DatosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();
            edc.Value = "id_descuento";
            edc.Display = "n_descuento";
            edc.Sql = "SELECT * FROM Descuentos";
            edc.Tabla = _BD.EjecutarSelect(edc.Sql);
            return edc;
        }
        public string RecuperaValor(string id)
        {
            return _BD.EjecutarSelect("SELECT monto FROM Descuentos WHERE id_descuento = " + id).Rows[0][0].ToString();
        }
    }
}
