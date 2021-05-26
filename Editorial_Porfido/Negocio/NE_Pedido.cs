using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Data;

namespace Editorial_Porfido.Negocio
{
    class NE_Pedido
    {
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public string Pp_id_pedido { get; set; }
        public string Pp_fecha_pedido { get; set; }
        public string Pp_fecha_fin { get; set; }
        public string Pp_codigo_interno_r { get; set; }
        public string Pp_cant { get; set; }
        public string Pp_precio_uni{ get; set; }
        public string Pp_precio_total{ get; set; }



        public DataTable RecuperarXid_Pedido(string id)
        {
            string sql = "select * from Pedidos  where id_pedido = '" + id + "'";
            return _BD.Ejecutar_Select(sql);

        }

       

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Pedidos (id_pedido,fecha_pedido,fecha_fin"
            + ", codigo_interno,cantidad,precio_unitario,precio_total) "
            + " VALUES ("
            + Pp_id_pedido 
            + ", '" + Pp_fecha_pedido + "'"
            + ", '" + Pp_fecha_fin + "'"
            + ", '" + Pp_codigo_interno_r + "'"
            + ", '" + Pp_cant + "'"
            + ", '" + Pp_precio_uni + "'"
            + ", " + Pp_precio_total + ")";

            _BD.Insertar(sqlInsertar);

            

        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Pedidos WHERE id_pedido= " + int.Parse(Pp_id_pedido);
            _BD.Borrar(sqlDelete);

        }
//       
//		Message	"Sintaxis incorrecta cerca de ','."	string


        public void Modificar()
        {
            string sqlModificar = @"UPDATE Pedidos SET "
            + "  fecha_pedido = '" + Pp_fecha_pedido + "'"
            + ", fecha_fin = '" + Pp_fecha_fin + "'"
            + ", codigo_interno= '" + Pp_codigo_interno_r + "'"
            + ", cantidad = '" + Pp_cant + "'"
            + ", precio_unitario = '" + Pp_precio_uni + "'"
            + ", precio_total = '" + Pp_precio_total + "'"
            + " where id_pedido = " + Pp_id_pedido;
            
            _BD.Modificar(sqlModificar);
        }


    }
}
