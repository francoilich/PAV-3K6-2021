using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Editorial_Porfido.Clasess;


namespace Editorial_Porfido.Negocio
{
    class NE_Empresa_Publicitaria
    {
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public string Pp_cuit { get; set;}
        public string Pp_nombre { get; set; }
        public string Pp_fecha_inicio { get; set; }
        public string Pp_id_ciudad { get; set; }
        public string Pp_calle { get; set; }
        public string Pp_numero_calle { get; set; }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Empresa_Publicit (cuit_empresa, nombre, calle"
            + ", altura, fecha_inicio_actividad, id_localidad) "
            + " VALUES ("
            + Pp_cuit
            + ", '" + Pp_nombre + "'"
            + ", '" + Pp_calle + "'"
            + ", " + Pp_numero_calle
            + ", '" + Pp_fecha_inicio + "'"
            + ", " + Pp_id_ciudad + ")";


            _BD.Insertar(sqlInsertar);
        }

        public DataTable recuperarPorCuit(string cuit_empresa)
        {
            string sql = @"Select * from Empresa_publicit where cuit_empresa = " + cuit_empresa;
            return _BD.Ejecutar_Select(sql);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Empresa_publicit WHERE cuit_empresa= " + int.Parse(Pp_cuit);
            _BD.Borrar(sqlDelete);

        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Empresa_Publicit SET"
            + "  cuit_empresa = " + Pp_cuit + ""
            + ", nombre = '" + Pp_nombre + "'"
            + ", calle= '" + Pp_calle + "'"
            + ", altura = '" + Pp_numero_calle + "'"
            + ", fecha_inicio_actividad = "+ Pp_fecha_inicio + ""
            + ", id_localidad = " + Pp_id_ciudad + ""
            + " where cuit_empresa = " + Pp_cuit;

            _BD.Modificar(sqlModificar);
        }



    }
}
