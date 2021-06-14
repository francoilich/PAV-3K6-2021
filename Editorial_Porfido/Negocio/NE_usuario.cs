using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Editorial_Porfido.Clasess;





namespace Editorial_Porfido.Negocio
   
{
    class NE_usuario
    {

        public enum ResultadoValidacion { existe, no_existe }
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public ResultadoValidacion ValidarUsuario(string usuario, string password)
        {
            string sql = @"Select * from usuario where nombre_usuario ='" + usuario + "' " +
                " and contraseña_usuario = '" + password + " ' ";


            DataTable tabla = new DataTable();

            tabla = _BD.Ejecutar_Select(sql);

            if (tabla.Rows.Count == 1)//si la tabla tiene 1 registro
            {
                return ResultadoValidacion.existe;

            }
            else
            {
                return ResultadoValidacion.no_existe;
            }


        }

        public int RecuperarIdUsuario(string usuario, string password)
        {
            string sql = @"SELECT usuario_id FROM usuario WHERE nombre_usuario = '" + usuario + "'"
                     + " AND contraseña_usuario = '" + password + "'";


            DataTable tabla = new DataTable();

            tabla = _BD.Ejecutar_Select(sql);

            return int.Parse(tabla.Rows[0][0].ToString());
        }
        public DataTable RecuperarTodo()
        {
            string sql = @"Select u.* ,p.rol_usuario_nombre as Perfil"
                          + "from usuario u join rol_usuario p"
                          + " on  u.rol_usuario=p.rol_usuario";
            return _BD.Ejecutar_Select(sql);

        }
        public DataTable RecuperarXPerfiles(string user)
        {
            string sql = @"Select u.* ,p.rol_usuario_nombre as Perfil"
                        + "from usuario u join rol_usuario p"
                        + " on  u.rol_usuario=p.rol_usuario"
                        + "where u.rol_usuario= " + user;
            return _BD.Ejecutar_Select(sql);

        }

        public DataTable Recuperar_x_Id(string id_usuario)
        {
            string sql = "SELECT * FROM usuario WHERE usuario_id =" + id_usuario;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarXNomPerfiles(string id)
        {
            //string sql = @"Select u.* ,p.rol_usuario_nombre as Perfil"
            //            + "from usuario u join rol_usuario p"
            //            + " on  u.rol_usuario=p.rol_usuario"
            //            + "where u.rol_usuario= " + id;

            string sql = @"Select p.rol_usuario_nombre"
                       +" from usuario u join rol_usuario p"
                       +" on  u.rol_usuario = p.rol_usuario_id"
                        +"  where u.usuario_id ="+ id;
            return _BD.Ejecutar_Select(sql);

        }


    }
}
