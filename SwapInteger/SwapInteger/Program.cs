using System;
/* 
 Autor: Hugo Oswaldo Ortiz Pantoja
 Descripción: Programa #6
     
*/
namespace SwapInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de las variables enteras y las de lectura
            String x, y;
            int ax, by;

            // Prompt para declaración de los inputs 
            Console.WriteLine("Dame el valor de X: ");
            x = Console.ReadLine();
            Console.WriteLine("Dame el valor de Y: ");
            y = Console.ReadLine();

            // Conversión de String a Entero
            ax = Convert.ToInt32(x);
            by = Convert.ToInt32(y);

            // En el caso de que las variables tengan el mismo valor, no lo convierte, porque da el mismo resultado
            if (ax == by)
                Console.WriteLine("La variable X y la variable Y son las mismas, no necesitan conversión");
            else
            {
                // Como funciona esta operación es modificar el valor de X con la suma de X + Y
                // Ej. Tenemos en la variable X = 30 y en la variable Y = 5 el resultado de X sería 35              
                ax += by;
                // En el siguiente paso se usa la misma lógica de modifcar la variable, ahora se restará el valor 
                // y se hará con la variable Y
                // Ej. Tenemos en la variable X = 35 (porque se modificó en el paso anterior) y en la variable Y = 5 
                // Ahora tendremos en la variable Y = 30, el valor inicial de X y la variable X seguirá con X = 35
                by = ax - by;
                // En este siguiente paso usaremos nuevamente la variable X para restar el valor de X 
                // con el valor de Y para poder tener el Swap completo
                // Ej. Y = 30 X = 35 con la resta quedaría en la variable de X = 5
                ax -= by;
                // Con este ejercicio, el valor inicial de X = 30 y el valor de Y = 5 se cambiaría para ser 
                // X = 5, Y = 30

                // Se imprime el antes y después de las variables
                Console.WriteLine("Antes - X:  " + x + " Y: " + y);
                Console.WriteLine("Después - X:  " + ax + " Y: " + by);
            }
        }
    }
}
