using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Negocio
{
    class NE_Perfil
    {
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();

        public EstructuraComboBox DatosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();
            edc.Value = "id_perfil";
            edc.Display = "nombre";
            edc.Sql = "SELECT * Perfiles";
            edc.Tabla = _BD.EjecutarSelect(edc.Sql);
            return edc;
        }
        public string RecuperaDescripcion(string id)
        {
            return _BD.EjecutarSelect("SELECT nombre FROM Perfiles WHERE id_perfil = " + id).Rows[0][0].ToString();
        }



    }
}
