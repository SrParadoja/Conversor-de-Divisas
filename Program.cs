//Hola y buen día a la persona que esté leyendo este comentario, el presente programa es un
//Conversor de moneda(también es válido como divisa ya que es un universal) que toma una cantidad en pesos colombianos e imprime el equivalente en dólares y euros

using System;

namespace CurrencyConversion
{
    class Program
    {
        // Definimos las tasas de cambio como constantes
        const decimal COP_A_USD = 4000m;  // 1 USD = 4000 COP
        const decimal COP_A_EUR = 4500m;  // 1 EUR = 4500 COP

        static void Main(string[] args)
        {
            // No es necesario el comentario, pero siempre es agradable un mensaje de bienvenida
            Console.WriteLine("¡Bienvenido al Grandioso Conversor de Divisas!");

            // Esta es una variable para almacenar el valor ingresado por el usuario
            decimal montoPesosColombianos = 0;

            // Bucle para asegurar que se ingrese un valor válido
            while (true)
            {
                Console.Write("Holi y Por favor, ingrese un monto en pesos colombianos (COP): ");

                string input = Console.ReadLine() ?? ""; // Asegura que no sea null

                // Condicional que intenta convertir la entrada a un número decimal
                if (decimal.TryParse(input, out montoPesosColombianos) && montoPesosColombianos > 0)
                {
                    // Si la entrada es válida y mayor que 0, culmina el bucle
                    break;
                }
                else
                {
                    // Si la entrada no es válida, se muestra un mensaje de error
                    Console.WriteLine("Error: Ingrese un número válido mayor que cero.");
                }
            }

            // Realizamos las conversiones de COP a USD y EUR
            decimal montoDólares = montoPesosColombianos / COP_A_USD;
            decimal montoEuros = montoPesosColombianos / COP_A_EUR;

            // Se Muestran los resultados de las conversiones
            Console.WriteLine("\nResultados de la conversión:");
            Console.WriteLine($"- {montoPesosColombianos} COP equivalen a {montoDólares:F2} USD.");
            Console.WriteLine($"- {montoPesosColombianos} COP equivalen a {montoEuros:F2} EUR.");

            // Mensaje final
            Console.WriteLine("\n¡Muchísimas Gracias por usar mi programita! Puedes pulsar cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
