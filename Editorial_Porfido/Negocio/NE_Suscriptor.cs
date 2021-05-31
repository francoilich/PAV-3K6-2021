using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Data;

namespace Editorial_Porfido.Negocio
{
    class NE_Suscriptor
    {
        BE_Acceso_BD _BD = new BE_Acceso_BD();


        public string Pp_id_suscriptor { get; set; }
        public string  Pp_nombre { get; set; }
        public string Pp_apellido { get; set; }
        public string Pp_dni { get; set; }
        public string  Pp_codpostal { get; set; }
        public string Pp_id_localidad { get; set; }
        public string Pp_barrio { get; set; }
        public string  Pp_calle { get; set; }
        public string Pp_numero { get; set; }



        public DataTable RecuperarXid(string id)
        {
            string sql = "select * from Suscriptor  where id_suscriptor = '" + id + "'";
            return _BD.Ejecutar_Select(sql);

        }


        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Suscriptor (id_suscriptor,Nombre ,Apellido"
            + ", DNI,codigo_postal,id_localidad,Barrio,Calle,Numero) "
            + " VALUES ("
            + Pp_id_suscriptor
             + ", '" + Pp_nombre + "'"
            + ", '" + Pp_apellido + "'"
            + ", '" + Pp_dni + "'"
            + ", '" + Pp_codpostal + "'"
            + ", '" + Pp_id_localidad + "'"
            + ", '" + Pp_barrio + "'"
             + ", '" + Pp_calle + "'"
            + ", " + Pp_numero + ")";

            _BD.Insertar(sqlInsertar);



        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Suscriptor WHERE id_suscriptor= " + Pp_id_suscriptor;
            _BD.Borrar(sqlDelete);

        }


        public void Modificar()
        {
            string sqlModificar = @"UPDATE Suscriptor SET "
            + " Nombre = '" + Pp_nombre + "'"
            + ", Apellido= '" + Pp_apellido + "'"
            + ", DNI = '" + Pp_dni + "'"
            + ", codigo_postal = '" + Pp_codpostal + "'"
            + ", id_localidad = '" + Pp_id_localidad + "'"
            + ", Barrio = '" + Pp_barrio + "'"
            + ", Calle = '" + Pp_calle + "'"
            + ", Numero = '" + Pp_numero + "'"
            + " where id_suscriptor = " + Pp_id_suscriptor;

            _BD.Modificar(sqlModificar);
        }
    }
}
