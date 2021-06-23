using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using Editorial_Porfido.Formularios;
using System.Data;
using System.Windows.Forms;

namespace Editorial_Porfido.Negocio
{
    class NE_Kiosco
    {

        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public string Pp_id_kiosco { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_id_localidad { get; set; }
        public string Pp_barrio { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_numero { get; set; }
        public string Pp_fecha { get; set; }
        public string Pp_cuil { get; set; }


        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Kiosco (id_kiosco, Nombre, CUIL, id_localidad, Barrio"
            + ", Calle, Numero, Fecha) "
            + " VALUES ("
            + Pp_id_kiosco
            + ", '" + Pp_nombre + "'"
            + ", '" + Pp_cuil + "'"
            + ", '" + Pp_id_localidad + "'"
            + ", '" + Pp_barrio + "'"
            + ", '" + Pp_calle + "'"
            + ", '" + Pp_numero + "'"
            + ", '" + Convert.ToDateTime(Pp_fecha) + "')";

            _BD.Insertar(sqlInsertar);
        }

        public DataTable RecuperarXid_kiosco(string id)
        {
            string sql = "SELECT * FROM Kiosco WHERE id_kiosco = '" + id + "'";
            return _BD.Ejecutar_Select(sql);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Kiosco SET "
            //+ "  id_kiosco = '" + Pp_id_kiosco + "'"
            + " Nombre = '" + Pp_nombre + "'"
            + ", CUIL = '" + Pp_cuil + "'"
            + ", id_localidad= '" + Pp_id_localidad + "'"
            + ", Barrio = '" + Pp_barrio + "'"
            + ", Calle = '" + Pp_calle + "'"
            + ", Numero = '" + Pp_numero + "'"
            + ", Fecha = '" + Pp_fecha + "'"
            + " where id_kiosco = " + Pp_id_kiosco;

            _BD.Modificar(sqlModificar);
        }

        //{
        //    string sqlModificar = @"UPDATE Pedidos SET "
        //    + "  fecha_pedido = '" + Pp_fecha_pedido + "'"
        //    + ", fecha_fin = '" + Pp_fecha_fin + "'"
        //    + ", codigo_interno= '" + Pp_codigo_interno_r + "'"
        //    + ", cantidad = '" + Pp_cant + "'"
        //    + ", precio_unitario = '" + Pp_precio_uni + "'"
        //    + ", precio_total = '" + Pp_precio_total + "'"
        //    + " where id_pedido = " + Pp_id_pedido;

        //_BD.Modificar(sqlModificar);
        //}

    public void Borrar()
        {
            string sqlDelete = "DELETE FROM Kiosco WHERE id_kiosco= " + Pp_id_kiosco;
            _BD.Borrar(sqlDelete);
        }

        public DataTable RecuperarXid(string id)
        {
            string sql = "Select *  from Kiosco where id_kiosco = '" + id + "'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable ReporteKiosco_Todos()
        {
            string sql = "SELECT id_kiosco, Nombre, CUIL, Fecha, Barrio FROM Kiosco";
            DataTable tabla = new DataTable();//Referencia a objeto no establecida como instancia de un objeto.'
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        public DataTable ReporteKiosco_RangoId(string RangoInicia, string RangoFinal)
        {
            string sql = "SELECT id_kiosco, Nombre, CUIL, Fecha, Barrio FROM Kiosco WHERE id_kiosco between " + RangoInicia + " AND " + RangoFinal;
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        public DataTable ReporteKiosco_Letra(string letra)
        {
            string sql = "SELECT id_kiosco, Nombre, CUIL, Fecha, Barrio FROM Kiosco WHERE Nombre like '" + letra.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }

        public DataTable ReporteKiosco_Barrio(string letra)
        {
            string sql = "SELECT id_kiosco, Nombre, CUIL, Fecha, Barrio FROM Kiosco WHERE Barrio like '%" + letra.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(sql);
            return tabla;
        }


    }
}
