using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal_Alberto_Gomez_Garcia.Model
{
    public class Polinomio
    {
        public string Nombre { get => FormatearNombre(); }
        public List<double> Coeficientes { get; set; }

        public Polinomio(List<double> coeficientes)
        {
            this.Coeficientes = coeficientes;
        }
        
        public double Calcular(int x)
        {
            double resultado = 0;
            int maxExp = this.Coeficientes.Count - 1;

            foreach (var coef in Coeficientes)
            {
                resultado += coef * Math.Pow(x, maxExp);
                maxExp--;
            }


            return resultado;

        }

        private string FormatearNombre()
        {
            string nombre = "";
            //5x^5 + x^4 - 2x^3 + 10
            //{ 5, 1, -2, 0, 0, 10}
            int exponente = Coeficientes.Count - 1;

            foreach (var coef in Coeficientes)
            {
                switch (coef)
                {
                    case 0:
                        break;

                    default:
                        string signo = coef > 0 ? " + " : " - ";
                        //string signo = "";
                        //if(coef > 0)
                        //{
                        //    signo = " + ";
                        //}
                        //else
                        //{
                        //    signo = " - ";
                        //}
                        if (exponente == 0)
                        {
                            nombre += signo + Math.Abs(coef);
                        }else if(exponente == 1)
                        {
                            nombre += signo + Math.Abs(coef) + "x";
                        }
                        else
                        {
                            nombre += signo + Math.Abs(coef) + "x^" + exponente;
                        }

                        break;
                }
                
                exponente--;
            }

            //Ahora puede empezar por " + " o " - "

            nombre = nombre.Trim(); //Quita el primer espacio

            if (nombre.StartsWith("+ "))
                nombre = nombre.Substring(2);   //Si empieza por "+ " lo quita

            if (nombre.StartsWith("- "))
                nombre = nombre.Remove(1, 1);   //Si empieza por "- " solo quita el espacio

            return nombre;
        }
    }
}
