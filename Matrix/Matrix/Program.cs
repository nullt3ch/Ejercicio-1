using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea la matriz y se ponen los valores que va a tener
            int[,] matrix = new int[,] 
            {
                {1,2,3},
                {4,0,6},
                {7,8,9}
            };

            // Se obtiene el tamaño de la matriz, tanto sus columnas como sus filas 
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            // Se imprime la matriz inicial antes de sus cambios 

            Console.WriteLine("Matriz inicial: ");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    // Se imprime el resultado del For (la matriz) 
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                // Se da un salto de línea para hacerlo más visible 
                Console.Write(Environment.NewLine);
            }
            // Se da un salto de línea para hacerlo más visible 
            Console.Write(Environment.NewLine);
            
            // Función para convertir la matriz 
            ConvertMatrix(matrix, rowLength, colLength);


            // Se vuelve a imprimir la matriz final ya convertida
            Console.WriteLine("Matriz convertida: ");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }
        public static void ConvertMatrix(int[,] matrix, int row, int col)
        {
            // En este for vamos a pasar por toda la matriz tanto sus filas como sus columnas
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    // Aquí es donde se define el valor de 0 (donde la función va a partir para poner sus filas y columnas iguales a 0) 
                    if (matrix[i, j] == 0)
                    {

                        // Función para cambiar el valor de las filas
                        ChangeRow(matrix, row, i);

                        // Función para cambiar el valor de las columnas
                        ChangeColumn(matrix, col, j);
                    }
                }
            }
            
            // Último For para remover el valor de -1 que se pone para convertirlo a 0 y finalizar con la matriz
            for (int n = 0; n < row; n++)
            {
                for (int m = 0; m < col; m++)
                {
                    if (matrix[m, n] == -1)
                    {
                        // Cambia el valor de -1 a 0 
                        matrix[m, n] = 0;
                    }
                }
            }
        }
        public static void ChangeRow(int[,] matrix, int row, int j)
        {

            // En esta función se cambian las filas determinados anteriormente con un -1 
            for (int y = 0; y < row; y++)
            {
                if (matrix[y, j] != 0)
                {

                    // Se crea una especie de valor "Temporal" que sería el -1 para después convertirlo en 0
                    matrix[y, j] = -1;
                }
            }
        }
        public static void ChangeColumn(int[,] matrix, int col, int i)
        {

            // En esta función se cambian las filas determinados anteriormente con un -1 
            for (int x = 0; x < col; x++)
            {
                if (matrix[i, x] != 0)
                {

                    // Se crea una especie de valor "Temporal" que sería el -1 para después convertirlo en 0
                    matrix[i, x] = -1;
                }
            }
        }
    }
}
