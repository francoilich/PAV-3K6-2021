using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_Asignaciones
    {
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();

        public EstructuraComboBox DatosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();
            edc.Value = "id_asignacion";
            edc.Display = "n_asignacion";
            edc.Sql = "SELECT * FROM Asignaciones";
            edc.Tabla = _BD.EjecutarSelect(edc.Sql);
            return edc;
        }
        public string RecuperaValor(string id)
        {
            return _BD.EjecutarSelect("SELECT monto FROM Asignaciones WHERE id_asignacion = " + id).Rows[0][0].ToString();
        }


    }
}
