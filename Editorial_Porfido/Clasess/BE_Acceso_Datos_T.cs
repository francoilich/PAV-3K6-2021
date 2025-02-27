﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Editorial_Porfido.Clasess
{
    class BE_Acceso_Datos_T
    {
        public enum EstadoTransaccion { error, correcto}
        public enum TipoConexion {simple, transaccion }

        string CadenaConexion = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K6G13_2021; Persist Security Info = True; User ID = BD3K6G13_2021; Password = BDG13_5193";
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        EstadoTransaccion ControlTransaccion = EstadoTransaccion.correcto;
        TipoConexion ControlConexion = TipoConexion.simple;

        public void InicioTransaccion()
        {
            ControlTransaccion = EstadoTransaccion.correcto;
            ControlConexion = TipoConexion.transaccion;
        }

        public EstadoTransaccion FinalTransaccion()
        {
            if (ControlConexion== TipoConexion.transaccion)
            {
                if (ControlTransaccion == EstadoTransaccion.correcto)
                {
                    Transaccion.Commit();
                }
                else
                {
                    Transaccion.Rollback();
                }
            }
            ControlConexion = TipoConexion.simple;
            Desconectar();
            return ControlTransaccion;
        }

        private void  Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = CommandType.Text;

                if (ControlConexion == TipoConexion.transaccion)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        }
        private void Desconectar()
        {
            if (ControlConexion== TipoConexion.simple)
                Conexion.Close();
        }
        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en la consulta: \n "
                                 + sql + "\n"
                                 + "El mensaje de error es: \n"
                                 + e.Message);
            }
            Desconectar();
            return tabla;
        }
        public EstadoTransaccion Insertar(string SqlInsertar)
        {
            return InsModBorr(SqlInsertar);
        }
        public EstadoTransaccion Modificar(string SqlModificar)
        {
            return InsModBorr(SqlModificar);
        }
        public EstadoTransaccion Borrar(string SqlBorrar)
        {
            return InsModBorr(SqlBorrar);
        }
        private EstadoTransaccion InsModBorr(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en comando sql: \n "
                                 + sql + "\n"
                                 + "El mensaje de error es: \n"
                                 + e.Message);

            }
            Desconectar();
            return ControlTransaccion;
        }
    }
}
