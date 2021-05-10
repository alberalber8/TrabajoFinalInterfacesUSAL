using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal_Alberto_Gomez_Garcia.Model
{
    public class ParDatos
    {
        public string Nombre { get; set; }
        public int X { get; set; }
        public double Y { get; set; }


        public ParDatos(string name, int xParam, double yParam)
        {
            Nombre = name;
            X = xParam;
            Y = yParam;
        }
    }
}
