using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Editorial_Porfido.Clasess
{
    class BE_Acceso_BD
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        

        private void conectar()
        {
            conexion.ConnectionString = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K6G13_2021; Persist Security Info = True; User ID = BD3K6G13_2021; Password = BDG13_5193 ";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;

        }
        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable Ejecutar_Select(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;

        }
        public void Ejecutar_Insert(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();   
        }
        public void Ejecutar_Update(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public void Ejecutar_Delete(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public void Insertar(string SqlInsertar)
        {
            conectar();
            cmd.CommandText = SqlInsertar;
            cmd.ExecuteNonQuery();
            desconectar();
        }

        public void Modificar(string SqlModificar)
        {
            InsModBorr(SqlModificar);
        }
        private void InsModBorr(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }

        public void Borrar(string SqlBorrar)
        {
            conectar();
            cmd.CommandText = SqlBorrar;
            cmd.ExecuteNonQuery();
            desconectar();
        }

    }
}
