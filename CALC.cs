using System;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            Console.WriteLine("Calculadora");

            while (continuar)
            {
               
                Console.Write("\nIntroduce el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Entrada no válida. Por favor, introduce un número.");
                    continue;
                }

                Console.Write("Elige una operación (+, -, *, /): ");
                string operacion = Console.ReadLine();

                Console.Write("Introduce el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Entrada no válida.");
                    continue;
                }

                double resultado = 0;
                bool operacionValida = true;

                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                            operacionValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Operación no reconocida.");
                        operacionValida = false;
                        break;
                }

                if (operacionValida)
                {
                    Console.WriteLine($"\n> Resultado: {num1} {operacion} {num2} = {resultado}");
                }

                Console.Write("\n¿Quieres hacer otro cálculo? (s/n): ");
                if (Console.ReadLine().ToLower() != "s")
                {
                    continuar = false;
                }
            }

           
        }
    }
}
