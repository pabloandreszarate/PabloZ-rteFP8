namespace ParcailArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Implemente un programa que permita a un usuario definir, llenar y analizar una matriz de números enteros, con el objetivo de obtener estadísticas numéricas específicas.
            Requisitos del programa:
            Definición de la matriz:
            Solicite al usuario ingresar el número de filas n y columnas m de la matriz.
            Ambos valores deben ser enteros mayores o iguales a 2 y menores o iguales a 10.
            Si el usuario ingresa valores fuera del rango, debe mostrarse un mensaje de error y volver a solicitar la entrada.
            Ingreso de elementos:
            Permita al usuario ingresar los elementos de la matriz manualmente, uno a uno, indicando la posición actual (fila, columna).
            Cada número debe ser un entero que puede ser positivo, negativo o cero.
            Visualización de la matriz:
            Una vez completado el ingreso, mostrar la matriz en pantalla con un formato tabular.
            Procesamiento y estadísticas:
            Calcular y mostrar en pantalla lo siguiente:
            La suma de todos los números pares ingresados en la matriz.
            La suma de todos los números impares.
            La cantidad de números negativos encontrados en la matriz.
            La cantidad total de ceros.
            El promedio general de todos los valores ingresados.
            Formato de salida:
            Cada resultado debe mostrarse con un mensaje descriptivo.
            Consideraciones técnicas:
            El cálculo del promedio debe considerar todos los elementos de la matriz.*/

            int filas = 0;
            int columnas = 0;
            int[,] matris = new int[filas, columnas];
            int sumaPares = 0;
            int sumaInpares = 0;
            int negativos = 0;
            int ceros = 0;
            int Suma = 0;
            int promedio = 0;

            do
            { 
            Console.WriteLine("ingrese el numero de columnas");
            columnas = int.Parse(Console.ReadLine());


            Console.WriteLine("ingrese el numero de filas");
            filas = int.Parse(Console.ReadLine());

                if (filas < 2 || filas > 10)
                {
                    Console.WriteLine("ingrese un numero de filas correxto");
                }
                
                if (columnas < 2 || columnas > 10)
                {
                    Console.WriteLine("ingrese un numero de columnas correcto");
                }
                
            } while (filas >= 2 || filas <= 10);

            Console.WriteLine("ingrese los numeros que estaran en la matris");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"posicion{i}, {j}");
                    matris[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matris");
            for(int i = 0;i < filas; i++)
            {
                for(int j = 0;j < columnas; j++)
                {
                    Console.WriteLine($"{matris[i,j]}");
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int numeros = matris[i,j];
                    Suma += numeros;

                    if (numeros % 2 == 0)
                    {
                        sumaPares += numeros;
                    }
                    else
                    {
                        sumaInpares += numeros;
                    }

                    if (numeros < 0)
                    {
                        negativos++;
                    }
                    
                    if(numeros == 0)
                    {
                        ceros++;
                    }
                }
            }
            int totalMatris = filas * columnas;

            promedio = Suma/totalMatris;

            Console.WriteLine($"La suma de todos los numeros pares de la matris es: {sumaPares}, la suma de todos los impares de la matris es: {sumaInpares}, la camntidad de numeros negativos de la mtris es: {negativos}, la cantidad de ceros de la matris es: {ceros}, el promedio de todos los numeros ingresados enn la matris es: {promedio}");
            
        }
    }
}
