using System;
using System.Runtime.InteropServices;
using DIO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Collections.Generic;

Calculadora calc = new Calculadora();


Console.Write($"Digite o 1º valor: ");
double valor1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Digite o 2º valor: ");
double valor2 = Convert.ToInt32(Console.ReadLine());


calc.Potencia(valor1,valor2);

calc.Somar(valor1, valor2);

calc.Subtrair(valor1, valor2);

calc.Multiplicar(valor1, valor2);

calc.Dividir(valor1, valor2);

calc.Resto(valor1, valor2);



Console.ReadKey();