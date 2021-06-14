using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editorial_Porfido.Clasess;
using System.Windows.Forms;
using Editorial_Porfido.Clasess;

namespace Editorial_Porfido.Clasess
{
    class TratamientosEspeciales
    {
        public enum Resultado { correcto, error }
        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Text == "")
                    {
                        MessageBox.Show(((TextBox01)item).Pp_MensajeError);
                        ((TextBox01)item).Focus();
                        return Resultado.error;
                    }
                }

            }
            return Resultado.correcto;

        }
        public string RecuperarMes()
        {
            BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();
            return _BD.EjecutarSelect("SELECT DATEPART(MONTH, GETDATE())").Rows[0][0].ToString();
        }

        public string RecuperarAño()
        {
            BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();
            return _BD.EjecutarSelect("SELECT DATEPART(YEAR, GETDATE())").Rows[0][0].ToString();
        }

        public string RecuperarFecha()
        {
            BE_Acceso_BD_T _BD = new BE_Acceso_BD_T();
            return _BD.EjecutarSelect("select convert (char(10), getdate(), 103)").Rows[0][0].ToString();
        }

        public Resultado ValidarFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return Resultado.correcto;
            }
            catch (Exception)
            {
                return Resultado.error;
            }
        }
    }

}
