using System;
using System.Collections;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de variables 
            String cadena1, cadena2;

            // Prompt para obtener Inputs 
            Console.WriteLine("Input de la cadena 1: ");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Input de la cadena 2:");
            cadena2 = Console.ReadLine();

            // Llamada a la función que compara una cadena con la otra para saber si es un anagrama.
            Boolean resultado = Comparar(cadena1, cadena2);
            
            // Resultado en tipo booleano que dice si fue un anagrama o no.
            if (resultado)
            {
                Console.WriteLine("Sí es un anagrama");
            }
            else
            {
                Console.WriteLine("No es un anagrama");
            }
        }
        public static Boolean Comparar(String cadena1, String cadena2)
        {
            // Creación de arreglos de lista para introducir todos los chars de la cadena inputada anteriormente.
            ArrayList arrayList1 = new ArrayList();
            ArrayList arrayList2 = new ArrayList();

            // Si no tienen el mismo tamaño las cadenas,automáticamente se elimina la posibilidad de ser un anagrama y se manda el valor de falso.
            if (cadena1.Length != cadena2.Length)
                return false;

            // Foreach que pasa los carácteres a los arreglos de lista de las cadenas inputadas. 
            foreach (char c in cadena1)
            {
                arrayList1.Add(c);
            }
            foreach (char c in cadena2)
            {
                arrayList2.Add(c);
            }

            // Esta fue una función que encontré con la libreria de Collections, en caso de no tener esta librería,
            // simplemente se hace el método de la burbuja para obtener el acomodo de los datos 
            arrayList1.Sort();
            arrayList2.Sort();

            // For para pasar los arreglos y se comparan cada carácter uno por uno para validar si son iguales, ya que ya están acomodados en la función anterior
            for (int i = 0; i < arrayList1.Count; i++)
            {
                // Se convierten a String porque sin ello no los interpreta de manera correcta. 
                if (arrayList1[i].ToString() != arrayList2[i].ToString())
                {
                    return false ;
                }
            }
            return true;
            
        }
    }
}
