using System;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            String hora, minutos;

            // Ingresar la hora y los minutos 
            Console.WriteLine("Ingresa la hora (1 - 12): ");
            hora = Console.ReadLine();
            Console.WriteLine("Ingresa la hora (1 - 59): ");
            minutos = Console.ReadLine();

            // Convertir las horas y minutos a enteros 
            int horaEntera = Convert.ToInt32(hora);
            int minutosEntera = Convert.ToInt32(minutos);

            // Validar que la hora no sea mayor a 12 y los minutos mayores a 60 o que sean menores a 0 
            if (horaEntera > 12 || minutosEntera > 60 || horaEntera < 0 || minutosEntera < 0)
            {
                Console.WriteLine("El número ingresado no es correcto (Hora 1-12) (Minutos 1-59)");
            }
            else
            {
                // Resultado de la función Angulo
                int resultado = Angulo(horaEntera, minutosEntera);
                Console.WriteLine("El ángulo entre la hora y los minutos es de: " + resultado);
            }
        }
        public static int Angulo(int hora, int minutos)
        {
            // Definición y cálculo de los ángulos
            // La hora se calcula sobre 30, aquí se obtiene la posición de la manecilla de la hora  
            int horaAngulo = hora * 30; 

            // Los minutos se multiplican por 6, se obtiene con esto el ángulo de la manecilla de los minutos
            int minutosAngulo = 6 * minutos;

            // Aquí con la función absolute nos da el valor final de ángulo, con la resta entre la hora y los minutos 
            int resultado = System.Math.Abs(horaAngulo - minutosAngulo) ;
            return resultado;
        }
    }
}
