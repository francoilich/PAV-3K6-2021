using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Windows.Forms;
using System.Data;

namespace Editorial_Porfido.Negocio
{
    class NE_SueldosLiquidacion
    {

        public string Id_usuario { get; set; }
        public string Fecha { get; set; }
        public string Sueldo_bruto { get; set; }
        public string Mes { get; set; }
        public string Anno { get; set; }
        BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();
        public void Borrar(string id_usuario, string mes, string anno)
        {
            string sqlBorrarAsignaciones = "DELETE FROM SueldosAsignaciones "
                              + " WHERE id_usuario = " + id_usuario.Trim()
                              + " AND mes = " + mes
                              + " AND anno = " + anno;

            string sqlBorrarDescuentos = "DELETE FROM SueldosDescuentos "
                              + " WHERE id_usuario = " + id_usuario.Trim()
                              + " AND mes = " + mes
                              + " AND anno = " + anno;

            string sqlBorrarLiquidacion = "DELETE FROM Sueldos "
                                          + " WHERE id_usuario = " + id_usuario.Trim()
                                          + " AND mes = " + mes
                                          + " AND anno = " + anno;

            _BD.InicioTransaccion();
            _BD.Borrar(sqlBorrarAsignaciones);
            _BD.Borrar(sqlBorrarDescuentos);
            _BD.Borrar(sqlBorrarLiquidacion);
            if (_BD.FinalTransaccion() == BE_Acceso_BD_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }
        }
        public void Modificar(Grid01 asignaciones, Grid01 descuentos)
        {
            string SqlModificar = @"UPDATE Sueldos
                                    SET fecha =  Convert(Date, '" + Fecha + "', 103)"
                                    + ", sueldo_bruto = " + Sueldo_bruto.Trim().Replace(",", ".")
                                    + " WHERE id_usuario = " + Id_usuario.Trim()
                                    + " AND mes = " + Fecha.Substring(3, 2)
                                    + " AND anno = " + Fecha.Substring(6, 4);

            string sqlBorrarAsignaciones = "DELETE FROM SueldosAsignaciones "
                                          + " WHERE id_usuario = " + Id_usuario.Trim()
                                          + " AND mes = " + Fecha.Substring(3, 2)
                                          + " AND anno = " + Fecha.Substring(6, 4);

            string sqlBorrarDescuentos = "DELETE FROM SueldosDescuentos "
                              + " WHERE id_usuario = " + Id_usuario.Trim()
                              + " AND mes = " + Fecha.Substring(3, 2)
                              + " AND anno = " + Fecha.Substring(6, 4);

            _BD.InicioTransaccion();
            _BD.Modificar(SqlModificar);
            _BD.Borrar(sqlBorrarAsignaciones);
            InsertarAsignaciones(asignaciones);
            _BD.Borrar(sqlBorrarDescuentos);
            InsertarDescuentos(descuentos);
            if (_BD.FinalTransaccion() == BE_Acceso_BD_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }
        }

        public void Insertar(Grid01 asignaciones, Grid01 descuentos)
        {

            string SqlInsertar = @"INSERT INTO Sueldos (
                                  id_usuario, fecha, sueldo_bruto, mes, anno)
                                  VALUES ("
                                  + Id_usuario.Trim()
                                  + ", Convert (Date, '" + Fecha + "', 103)"
                                  + ", " + Sueldo_bruto.Trim().Replace(",", ".")
                                  + ", " + Mes
                                  + ", " + Anno
                                  + ")";

            _BD.InicioTransaccion();
            _BD.Insertar(SqlInsertar);
            InsertarAsignaciones(asignaciones);
            InsertarDescuentos(descuentos);
            if (_BD.FinalTransaccion() == BE_Acceso_BD_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }



        }
        private void InsertarAsignaciones(Grid01 asignaciones)
        {
            string SqlInsertarAsig = @"INSERT INTO SueldosAsignaciones (
                                        id_usuario, fecha,mes, anno, id_asignacion, cantidad, monto) VALUES
                                      (" + Id_usuario
                                      + ", Convert (Date, '" + Fecha + "', 103)"
                                      + ", " + Mes
                                      + ", " + Anno;

            foreach (DataGridViewRow row in asignaciones.Rows)
            {
                string ValoresMoviles = "";

                ValoresMoviles = ", " + asignaciones.Rows[0].Cells[0].Value.ToString()
                                + ", " + asignaciones.Rows[0].Cells[2].Value.ToString()
                                 + ", " + asignaciones.Rows[0].Cells[3].Value.ToString().Replace(",", ".")+ ")";

                _BD.Insertar(SqlInsertarAsig + ValoresMoviles);
            }
        }
        private void InsertarDescuentos(Grid01 descuento)
        {
            string SqlInsertarDESC = @"INSERT INTO SueldosDescuentos (
                                        id_usuario, fecha,mes,anno,id_descuento, cantidad, monto) VALUES
                                      (" + Id_usuario
                                       + ", Convert (Date, '" + Fecha + "', 103)"
                                      + ", " + Mes
                                      + ", " + Anno;

            foreach (DataGridViewRow row in descuento.Rows)
            {
                string ValoresMoviles = "";
                
                ValoresMoviles = ", " + descuento.Rows[0].Cells[0].Value.ToString()
                                + ", " + descuento.Rows[0].Cells[2].Value.ToString()
                                 + ", " + descuento.Rows[0].Cells[3].Value.ToString().Replace(",", ".") + ")";

                _BD.Insertar(SqlInsertarDESC + ValoresMoviles);
            }
        }
        public DataTable SueldosLiquidados(string id_usuario, string mes, string anno)
        {
            string SqlSelect = @"SELECT s.id_usuario, u.apellido, u.nombre, s.sueldo_bruto 
                                   , s.mes,s.anno      
                                   FROM Sueldos s JOIN usuario u
                                              ON s.id_usuario = u.usuario_id
                                WHERE s.id_usuario = " + id_usuario
                                 + " AND s.mes = " + mes
                                 + " AND s.anno = " + anno;

            return _BD.EjecutarSelect(SqlSelect);
        }
        


    }

   
}
