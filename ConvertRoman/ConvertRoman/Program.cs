using System;
using System.Collections.Generic;

namespace ConvertRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir las variables de entrada
            String entero, romano;
            int converted;

            // Input del usuario y conversión a entero
            Console.WriteLine("Ingresa un número menor a 3999: ");
            entero = Console.ReadLine();
            converted = Convert.ToInt32(entero);

            // Validar si el valor es menor a 4000
            if (converted < 4000)
            {
                // Funcion para convertir a números romanos
                romano = ConvertRoman(converted);
                Console.WriteLine("Valor en Romano: " + romano);
            }
            // No aceptar valores mayores de 3999
            else
            {
                Console.WriteLine("El valor no puede ser mayor a 3999");
            }
        }
        public static String ConvertRoman(int number)
        {
            // Creación de las variables tipo arreglo para definir las letras romanas y su valor 
            // ** También se puede hacer con un diccionario
            int[] numerosEnteros = new int[]
            {
                1,4,5,9,10,40,50,100,400,500,900,1000
            };
            String[] letrasRomanas = new String[]
            {
                "i", "iv", "v", "ix", "x", "xl", "l","xc","c","cd","d","cm","m"
            };
            string resultado = "";

            // For para repasar los arreglos y definir qué valor tienen 
            for (int i = 0; i < letrasRomanas.Length; i++)
            {
                // Si el número es 0, deja de hacer la iteración 
                if (number != 0)
                {
                    // Aquí está la lógica para de la función. Se valida si el número input es mayor al número actual del arreglo
                    while (number >= numerosEnteros[i])
                    {
                        // Se va eliminando al número inputado hasta llegar a 0 mientras el número sea mayor o igual al del arreglo
                        number -= numerosEnteros[i];
                        // Aquí se define cuál número romano tiene y se va añadiendo letra por letra con cada iteración
                        resultado += letrasRomanas[i];
                    }
                }
            }
            return resultado;
        }
    }
}
