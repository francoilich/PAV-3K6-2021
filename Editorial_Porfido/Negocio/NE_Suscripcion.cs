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
        BE_Acceso_BD _BD = new BE_Acceso_BD();
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
    }
}
