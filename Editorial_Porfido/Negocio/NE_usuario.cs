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
    class NE_usuario
    {

        public enum ResultadoValidacion { existe, no_existe }
        BE_Acceso_BD _BD = new BE_Acceso_BD();

        public ResultadoValidacion ValidarUsuario(string usuario, string password)
        {
            string sql = "Select * from Usuario where nombre_usuario ='" + usuario + "' " +
                " and contraseña_usuario = '" + password + " ' ";


            DataTable tabla = new DataTable();

            tabla = _BD.Ejecutar_Select(sql);

            if (tabla.Rows.Count == 1)
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
            string sql = @"SELECT usuario_id FROM Usuario WHERE nombre_usuario = '" + usuario + "'"
                     + " AND contraseña_usuario = '" + password + "'";


            DataTable tabla = new DataTable();

            tabla = _BD.Ejecutar_Select(sql);

            return int.Parse(tabla.Rows[0][0].ToString());
        }
        public DataTable RecuperarTodo()
        {
            string sql = @"select u.*, ru.rol_usuario_nombre as nom_rol_usuario from usuario u join rol_usuario ru on u.rol_usuario = ru.rol_usuario_id";
            return _BD.Ejecutar_Select(sql);

        }
        public DataTable RecuperarXPerfiles(string nombre)
        {
            string sql = @"select u.*, ru.rol_usuario_nombre as nom_rol_usuario from usuario u join rol_usuario ru on u.rol_usuario = ru.rol_usuario_id where u.nombre_usuario = '" + nombre + "'";
            return _BD.Ejecutar_Select(sql);

        }
        public void Agregar_Usuario(string nombre, string contraseña, string rolUsuario,string email)
        {
            string sql = @"insert into usuario (nombre_usuario, contraseña_usuario, rol_usuario, email_usuario) values ('"
                + nombre + "','" + contraseña + "'," + rolUsuario + ",'" + email + "')";
            _BD.Ejecutar_Insert(sql);
        }
        public ResultadoValidacion validar_Usuario_Por_Nombre(string nombre)
        {
            string sql = @"select * from usuario where nombre_usuario = '" + nombre + "'";
            DataTable tabla = _BD.Ejecutar_Select(sql);
            if(tabla.Rows.Count==1)
            {
                return ResultadoValidacion.existe;

            }
            else
            {
                return ResultadoValidacion.no_existe;
            }
        }

        public void delete_Usuario(string nombre)
        {
            string sql = @"delete from usuario where nombre_usuario = '" + nombre + "'";
            _BD.Ejecutar_Delete(sql);
        }
        public void delete_Todos_Usuarios()
        {
            string sql = @"delete from usuario ";
            _BD.Ejecutar_Delete(sql);
        }

        public void editar_usuario(string nombre, string contraseña, string rolUsuario, string email)
        {
            string sql = @"update usuario set nombre_usuario = '" + nombre + "'," +
            "contraseña_usuario = '" + contraseña + "'," + "rol_usuario = '" + rolUsuario + "'," +
            "email_usuario = '" + email + "' where nombre_usuario = '"+nombre+"'";
           _BD.Ejecutar_Update(sql);

        }
    }
}

