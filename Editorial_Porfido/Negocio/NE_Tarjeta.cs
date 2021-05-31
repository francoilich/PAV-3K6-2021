using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Editorial_Porfido.Clasess;


namespace Editorial_Porfido.Negocio
{
    class NE_Tarjeta
    {
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public string Pp_id_tarjeta { get; set; }
        public string Pp_numero { get; set; }
        public string Pp_fecha_venc { get; set; }
        public string Pp_id_suscriptor { get; set; }
        public string Pp_id_tipo_tarjeta { get; set; }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Tarjeta (id_tarjeta, numero, fecha_venc"
            + ", id_suscriptor, id_tipo_tarjeta) "
            + " VALUES ("
            + Pp_id_tarjeta
            + ", " + Pp_numero + ""
            + ", '" + Pp_fecha_venc + "'"
            + ", " + Pp_id_suscriptor + ""
            + ", " + Pp_id_tipo_tarjeta + ")";


            _BD.Insertar(sqlInsertar);

        }

        public DataTable recuperarPorId_tarjeta (string id_tarjeta)
        {
            string sql = @"Select * from Tarjeta where id_tarjeta = " + id_tarjeta;
            return _BD.Ejecutar_Select(sql);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Tarjeta WHERE id_tarjeta= " + (Pp_id_tarjeta);
            _BD.Borrar(sqlDelete);

        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Tarjeta SET "
            + "  id_tarjeta = " + Pp_id_tarjeta + ""
            + ", numero = '" + Pp_numero + "'"
            + ", fecha_venc = '" + Pp_fecha_venc + "'"
            + ", id_suscriptor = '" + Pp_id_suscriptor + "'"
            + ", id_tipo_tarjeta = '" + Pp_id_tipo_tarjeta + "'"
            + " where id_tarjeta = '" + Pp_id_tarjeta;

            _BD.Modificar(sqlModificar);

        }
    }
}
