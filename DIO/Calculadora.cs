using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    internal class Calculadora
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($" {x} + {y} = { x + y}");
        }
        public void Subtrair(double x, double y)
        {
            Console.WriteLine($" {x} - {y} = {x - y}");
        }
        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($" {x} X {y} = {x * y}");
        }
        public void Dividir(double x, double y)
        {
            Console.WriteLine($" {x} / {y} = {x / y}");
        }
        public void Resto(double x, double y)
        {
            Console.WriteLine($" {x} Resto {y} = {x % y}");
        }
        
        // Para fazer o cáuculo da potência e o cáuculo da raiz é necessário usar o Math.
        public void Potencia(double x, double y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($" {x}^{y} = {pot}");
        }
        
        public void Raiz(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine("O valor da raiz eh " + raiz);
        }
     }
}
