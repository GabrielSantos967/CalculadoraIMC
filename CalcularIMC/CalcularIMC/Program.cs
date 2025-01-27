using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string peso = "";
            string altura = "";

            Console.WriteLine("###Calculo IMC###");

            Console.WriteLine("Coloque seu peso");

            peso = Console.ReadLine();

            Console.WriteLine("Coloque sua altura");

            altura = Console.ReadLine();

            double peso2 = double.Parse(peso);
            double altura2 = double.Parse(altura);

            double resultado = peso2 / (altura2 * altura2);

            Console.WriteLine(resultado.ToString("F"));

            if (resultado <= 18.5)
            {
                Console.WriteLine("Abaixo do normal");
            } else if (resultado >= 18.6 && resultado <= 24.9)
            {
                Console.WriteLine("Normal");

            } else if (resultado >= 25 && resultado <= 29.9)
            {
                Console.WriteLine("Sobrepeso");

            } else if (resultado >= 30 && resultado <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1");

            } else if (resultado >= 35 && resultado <= 39.9)
            {
                Console.WriteLine("Obesidade grau 2");

            } else
            {
                Console.WriteLine("Obesidade grau 3");
            }

            Console.ReadKey();
        }
    }
}
