using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editorial_Porfido.Clasess
{
    class Grid01 : DataGridView
    {
        /// <summary>
        /// Esta función permite formatear la grilla, con el siguiente formato
        /// dentro del parametro de entrada como texto
        /// (texto cabecera, ancho;... texto cabecar, ancho)
        /// </summary>
        /// <param name="formato"></param>
        public void Formatear (string formato)
        {
            string[] datos_columna = formato.Split(';');
            //int cantida_columnas = datos_columna.Length;
            for (int i = 0; i < datos_columna.Length; i++)
            {
                string[] datos = datos_columna[i].Split(',');
                this.Columns.Add("columna" + i.ToString(), datos[0].ToString());
                this.Columns[i].Width = int.Parse(datos[1].ToString());
            }
        }
    }
}
