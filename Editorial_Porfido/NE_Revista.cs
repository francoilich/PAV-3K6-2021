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
        public string Pp_precio { get; set; }


        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Revista (codigo_interno, nombre, fecha_inicio_sesion"
            + ", id_tipo_frecuencia, id_rubro, id_numero_edicion, precio) "
            + " VALUES ("
            + Pp_codigo
            + ", '" + Pp_nombre + "'"
            + ", '" + Pp_fecha + "'"
            + ", '" + Pp_frecuencia + "'"
            + ", '" + Pp_rubro + "'"
            + ", " + Pp_id_numero_edi + "'"
            + ", " + Pp_precio + ")";

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
            + ", precio= '" + Pp_precio + "'"
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

        //REPORTES
        public DataTable ReporteRevistasRubro(string rubro)
        {
            string sql = "SELECT nombre, precio,  FROM usuarios WHERE apellido like '" + rubro.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
            //SELECT r.nombre, r.codigo_interno, r.precio, t.nombre FROM Revista r JOIN Tipo_Rubro t ON r.id_rubro = t.id_tipo_rubro
        }

        public DataTable ReporteRevista_RangoEdicion(string RangoInicia, string RangoFinal)
        {
            string sql = "SELECT nombre, codigo_interno, precio, id_numero_edicion, fecha_inicio_sesion FROM Revista WHERE id_numero_edicion between " + RangoInicia + " AND " + RangoFinal;
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        public DataTable ReporteRevista_RangoID(string RangoInicia, string RangoFinal)
        {
            string sql = "SELECT nombre, codigo_interno, precio, id_numero_edicion, fecha_inicio_sesion FROM Revista WHERE codigo_interno between " + RangoInicia + " AND " + RangoFinal;
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        public DataTable ReporteRevista_Todos()
        {
            string sql = "SELECT nombre, codigo_interno, precio, id_numero_edicion, fecha_inicio_sesion FROM Revista";
            DataTable tabla = new DataTable();//Referencia a objeto no establecida como instancia de un objeto.'
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        public DataTable ReporteRevista_RangoPrecio(string RangoInicia, string RangoFinal)
        {
            string sql = "SELECT nombre, codigo_interno, precio, id_numero_edicion, fecha_inicio_sesion FROM Revista WHERE precio between " + RangoInicia + " AND " + RangoFinal;
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        //ESTADISTICAS
        public DataTable RevistaPorRubro()
        {
            string sql = "SELECT r.nombre, r.codigo_interno, r.precio, t.nombre FROM Revista r JOIN Tipo_Rubro t ON r.id_rubro = t.id_tipo_rubro WHERE ";
            DataTable tabla = new DataTable();//Referencia a objeto no establecida como instancia de un objeto.'
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }
    }
}
