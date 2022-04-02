using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConceptos
{
    public static class ClaseEstatica
    {
        public static int ObtenerCantidadDePalabras(this string palabras)
        {
            int CantidadPalabras = 0;

            if (palabras == " ")
            {
                return 0;
            }
            else
            {
                var ListaPalabaras = palabras.Split(' ');
                foreach (string palabra in ListaPalabaras)
                {
                    CantidadPalabras++;
                }
            }

            return CantidadPalabras;
            
        }

        public static int ObtenerCantidadDePalabras(this string palabras,char Separador)
        {
            int CantidadPalabras = 0;

            if (palabras == " ")
            {
                return 0;
            }
            else
            {
                var ListaPalabaras = palabras.Split(Separador);
                foreach (string palabra in ListaPalabaras)
                {
                    CantidadPalabras++;
                }
            }

            return CantidadPalabras;
        }
        public static decimal CalcularDiferenciaFechas(this DateTime Fecha1,DateTime Fecha2)
        {
            double diferenciaDouble = Math.Sqrt(Math.Pow(Fecha1.Second - Fecha2.Second,2));
            decimal diferenciaDecimal = (decimal)diferenciaDouble / 60;

            return diferenciaDecimal;
        }
        public static double ObtenerPromedioDeEnteros(this List<int> ListaEnteros)
        {
            return ListaEnteros.Average();
        }

        public static bool EsPar(this int numero)
        {
            return (numero % 2 == 0);
        }
        public static int ObtenerSumaParesPorDiferenciaImpares(this List<int> ListaEnteros)
        {
            int SumaPares = 0;
            int DiferenciaImpares = 0;

            foreach (int Entero in ListaEnteros)
            {
                if (Entero.EsPar())
                {
                    SumaPares += Entero;
                }
                else
                {
                    DiferenciaImpares -= Entero;
                }
            }

            return SumaPares * DiferenciaImpares;
        }


    }
}
