using System;
using System.Collections;

namespace RepeatedCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            ArrayList arrayList = new ArrayList();
            String cadena, resultado = "";

            // Input de usuario para la cadena 
            Console.WriteLine("Cadena para validar las incidencias: ");
            cadena = Console.ReadLine();

            // Foreach para pasar cada carácter al arreglo de lista
            foreach (char c in cadena)
            {
                arrayList.Add(c);
            }
            
            // Acomodar de menor a mayor el valor del arreglo 
            arrayList.Sort();
            
            // For para pasar cada valor del arreglo 
            for(int i = 0; i < arrayList.Count; i++)
            {
                // Variable para contar las incidencias 
                int count = 0;

                // For para comparar en el mismo arreglo cuantas veces está el caracter 
                for (int j = 0; j < arrayList.Count; j++)
                {
                    // If para validar que siga siendo el mismo valor, para ver las incidencias del mismo 
                    if(arrayList[i].ToString() == arrayList[j].ToString())
                    {
                        // Aumento a la cuenta
                        count++;
                        // Aumento al For primero para saltarse los caracteres que ya están usados 
                        i = j;
                    }
                        
                }
                // Añadir el resultado a una variable con la letra y su cuenta de incidencias 
                resultado += arrayList[i].ToString() + count;
               
            }

            // Si el resultado es menor a la cadena inicial, se imprime el resultado
            if(resultado.Length < cadena.Length)
            {
                Console.WriteLine(resultado);
            }
            // Si el resultado es mayor a la cadena inicial, se imprime la cadena inicial
            else
            {
                Console.WriteLine(cadena);
            }
            

        }
    }
}
