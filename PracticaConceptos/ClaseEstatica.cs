using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PracticaConceptos
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public double Saldo { get; set; }
        public Cliente(double saldo)
        {
            this.Saldo = saldo;
        }
        public static Cliente operator -(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.Cuit == cliente2.Cuit)
            {
                return new Cliente(Math.Sqrt(Math.Pow(cliente1.Saldo -cliente2.Saldo, 2)));
            }
            else
            {
                if (cliente1.Saldo > cliente2.Saldo)
                {
                    return new Cliente(cliente2.Saldo);
                }
                else
                {
                    return new Cliente(cliente1.Saldo);
                }
            }
        }
    }
    public static class Temperatura
    {
        public static double ConvertirCelsiusAFahrenheit(double Celcius)
        {
            return Celcius * 2.12;
        }
        public static double ConvertirFahrenheitACelcius(double Fahrenheit)
        {
            return Fahrenheit / 2.12;
        }
    }
    public static class Rectangulo
    {
        public static int CalcularPerimetro(int LadoA,int LadoB)
        {
            return 2 * LadoA + 2 * LadoB;
        }
        public static int CalcularArea(int Base,int Altura)
        {
            return Base * Altura;
        }
    }
    public class ResultadosDecimales
    {
        public int Entero { get; set; }
        public decimal Resultado { get; set; }
        public ResultadosDecimales(int entero)
        {
            this.Entero = entero;
        }
        public static decimal operator /(ResultadosDecimales resultadosDecimales,int entero)
        {
            decimal Resultado = Convert.ToDecimal(resultadosDecimales.Entero) / Convert.ToDecimal(entero);
            return Resultado;
        }
    }

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
        public static int RestaEnteros(this int entero1, int entero2)
        {
            return entero1 - entero2;
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

        public static DateTime ObtenerDateTime(this string Fecha)
        {
            try
            {
                DateTime nuevaFecha = Convert.ToDateTime(Fecha);
            }
            catch (Exception)
            {

                return DateTime.MinValue;
            }

            return Convert.ToDateTime(Fecha);
        }

        public static string InvertirString(this string palabra)
        {
            var Cadena = palabra.ToCharArray();
            Cadena.Reverse();
            return new string(Cadena);
        }

        public static string ObtenerStringSeparadoPorParametro(this string[] Cadena,char Separador)
        {
            string Resultado = "";

            foreach (string palabra in Cadena)
            {
                Resultado = Resultado + $"{palabra} {Separador}";
            }

            return Resultado;
        }

        public const string PatronCorreoElectronico = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        public static bool EsUnCorreoElectronico(this string Correo)
        {
            return Regex.IsMatch(Correo,PatronCorreoElectronico);
        }
        public const string PatronCuit = "/^([0-9]{11}|[0-9]{2}-[0-9]{8}-[0-9]{1})$/g";
        public static bool EsUnCuil(this string Cuit)
        {
            return Regex.IsMatch(Cuit, PatronCuit);
        }
    }
    
}
