using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Editorial_Porfido.Clasess;
using System.Windows.Forms;

namespace Editorial_Porfido.Negocio
{
    class NE_Suscripcion
    {
        public string Pp_id_suscriptor { get; set; }
        public string Pp_cod_revista { get; set; }
        public string Pp_fecha_inicio { get; set; }
        public string Pp_fecha_fin { get; set; }
        public string Pp_id_forma_pago { get; set; }

        BE_Acceso_BD _BD = new BE_Acceso_BD();
        BE_Acceso_Datos_T BDT = new BE_Acceso_Datos_T();
        NE_plan plan = new NE_plan();
        string sql;

        public DataTable recuperarTodo()
        {
            sql = @"select * from suscripcion";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable recuperarPorIdSuscriptor(int id)
        {
            sql = @"select * from suscripcion where id_suscriptor = " + id + " ";
            return _BD.Ejecutar_Select(sql);
        }

        public void Insertar()
        {
            string sql = @"insert into suscripcion (id_suscriptor, codigo_interno_revista,fecha_inicio,fecha_fin,id_forma_pago) "
                 +" VALUES ("
            + Pp_id_suscriptor
            + ", " + Pp_cod_revista  
            + ", '" + Pp_fecha_inicio + "'"
            + ", '" + Pp_fecha_fin + "'"
            + ", '" + Pp_id_forma_pago+ " ')";

            _BD.Insertar(sql);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM suscripcion WHERE id_suscriptor= " + int.Parse(Pp_id_suscriptor);
            _BD.Borrar(sqlDelete);
        
        }
        public void Modificar()
        {
            string sqlModificar = @"UPDATE suscripcion SET "
            + "  id_suscriptor = " + Pp_id_suscriptor
            + ", codigo_interno_revista = " + Pp_cod_revista
            + ", fecha_inicio = '" + Convert.ToDateTime(Pp_fecha_inicio) + "'"
            + ", fecha_fin = '" + Convert.ToDateTime(Pp_fecha_fin) + "'"
            + ", id_forma_pago = " + Pp_id_forma_pago;

            _BD.Modificar(sqlModificar);
        }
        public void Insertar(Grid01 grid01)
        {
            DataTable data = recuperarFormaPago(Pp_id_forma_pago);
            string id_forma_pago = data.Rows[0][0].ToString();
            string sql = @"insert into suscripcion (id_suscriptor, codigo_interno_revista,fecha_inicio,fecha_fin,id_forma_pago) "
                 + " VALUES ("
            + Pp_id_suscriptor
            + ", " + Pp_cod_revista
            + ", '" + Pp_fecha_inicio + "'"
            + ", '" + Pp_fecha_fin + "'"
            + ", '" + id_forma_pago + " ')";

            BDT.InicioTransaccion();
            BDT.Insertar(sql);
            plan.InsertarPlan(grid01);
            if (BDT.FinalTransaccion() == BE_Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }
        }
        public DataTable recuperarFormaPago(string formaPago)
        {
            string sql="select id_forma_pago from forma_pago where nombre = '" + formaPago + "'";
            return _BD.Ejecutar_Select(sql);
        }
        
    }
}
