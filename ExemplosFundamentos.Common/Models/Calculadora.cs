using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Calculadora
    {
        public void somar ( int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void subtrair ( int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplicar ( int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
         public void dividir ( int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void potencia ( int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
        public void coseno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cos =  Math.Cos (radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(cos,4)}");
        }
        public void seno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double sen =  Math.Sin (radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(sen,4)}");
        }
        public void tangete (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tan =  Math.Tan (radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tan,4)}");
        }
        public void RaizQuadrada (double x)

        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}