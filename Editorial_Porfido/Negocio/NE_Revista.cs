using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Data;
using Editorial_Porfido.Formularios;
using System.Windows.Forms;

namespace Editorial_Porfido.Negocio
{
    class NE_Revista
    {
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public string Pp_codigo { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_fecha { get; set; }
        public string Pp_frecuencia { get; set; }
        public string Pp_rubro { get; set; }
        public string Pp_id_numero_edi { get; set; }


        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Revista (codigo_interno, nombre, fecha_inicio_sesion"
            + ", id_tipo_frecuencia, id_rubro, id_numero_edicion) "
            + " VALUES ("
            + Pp_codigo
            + ", '" + Pp_nombre + "'"
            + ", '" + Pp_fecha + "'"
            + ", '" + Pp_frecuencia + "'"
            + ", '" + Pp_rubro + "'"
            + ", " + Pp_id_numero_edi + ")";
          

            _BD.Insertar(sqlInsertar);

        }

        public DataTable RecuperarXCodigo(string codigo)
        {
            string sql = "Select *  from Revista where codigo_interno = '" + codigo + "'";
            return _BD.Ejecutar_Select(sql);
         
        }
        public void Modificar()
        {
            string sqlModificar = @"UPDATE Revista SET "
            + " nombre= '" + Pp_nombre + "'"
            + ", fecha_inicio_sesion= '" +Pp_fecha+ "'"
            + ", id_tipo_frecuencia= '" +Pp_frecuencia+ "'"
            + ", id_rubro= '" + Pp_rubro + "'"
            + ", id_numero_edicion= '" + Pp_id_numero_edi + "'"
            + " where codigo_interno= '" + Pp_codigo + "'";

            //: 'Falta la comilla de cierre después de la cadena de caracteres ''.
//Sintaxis incorrecta cerca de ''.'





            _BD.Modificar(sqlModificar);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Revista WHERE codigo_interno= " + Pp_codigo;
            _BD.Borrar(sqlDelete);
            
           }
        //public void Borrar(string codigo)
        //{
        //    string sqlDelete = "DELETE FROM Revista WHERE codigo_interno= " + codigo;
        //    _BD.
        //}
    }

}
