using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Data;

namespace Editorial_Porfido.Negocio
{
    class NE_plan
    {
        BE_Acceso_Datos_T BD = new BE_Acceso_Datos_T();
        public string Pp_id_plan { get; set; }
        public string Pp_fecha_inicio { get; set; }
        public string Pp_fecha_fin { get; set; }
        public string Pp_precio { get; set; }
        public string Pp_codigo_interno_r { get; set; }
        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Plan_Revista (fecha_inicio ,fecha_fin"
            + ", precio, codigo_interno_revista)"
            + " VALUES ("
            + "'"+ Pp_fecha_inicio+"'"
            + ", '" + Pp_fecha_fin + "'"
            + ", " + Pp_precio
            + ", " + Pp_codigo_interno_r + ")";

            BD.Insertar(sqlInsertar);
        }

        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Plan_Revista WHERE id_plan = " + Pp_id_plan;
            BD.Borrar(sqlDelete);

        }


        public void Modificar()
        {
            string sqlModificar = @"UPDATE Plan_Revista SET "
            + " fecha_inicio = '" + Pp_fecha_inicio + "'"
            + ", fecha_fin = '" + Pp_fecha_fin + "'"
            + ", precio = " + Pp_precio 
            + ", codigo_interno_revista = " + Pp_codigo_interno_r
            + " where id_plan = " + Pp_id_plan;

            BD.Modificar(sqlModificar);
        }

        public DataTable recuperarId(string id)
        {
            string sql = @"select * from plan_revista where id_plan = " + id;
            return BD.EjecutarSelect(sql);
        }
        public DataTable recuperarTodo()
        {
            string sql = @"select * from plan_revista";
            return BD.EjecutarSelect(sql);
        }
        public void InsertarPlan(Grid01 plan)
        {
            string SqlInsertarAsig = @"INSERT INTO Plan_Revista (fecha_inicio ,fecha_fin, precio, codigo_interno_revista)"
                                        + "VALUES ("; 

            for (int i = 0; i < plan.Rows.Count; i++)
            {
                string ValoresMoviles = "";

                ValoresMoviles += "'" + plan.Rows[i].Cells[0].Value.ToString()
                                + "', '" + plan.Rows[i].Cells[1].Value.ToString()
                                 + "', " + plan.Rows[i].Cells[2].Value.ToString()
                                 + ", " + plan.Rows[i].Cells[3].Value.ToString() + ")";

                BD.Insertar(SqlInsertarAsig + ValoresMoviles);
            }
        }
    }
}
