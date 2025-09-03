namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13.Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.
El algoritmo debe escribir en pantalla: 
La cantidad de números introducidos que son mayores que 0
La cantidad de números introducidos menores que 0
La cantidad de números iguales a 0.*/

            /*int cantidadNumeros = Convert.ToInt32(Console.ReadLine);
            int contador = 0;

            while (cantidadNumeros <= contador)
            {
                Console.WriteLine("ingrese la cantidad de numeros que va a introducir");*/

            int rango = 0; 
            int contadorPares = 0;
            int contador = 1;

            Console.WriteLine("ingrese la cantidad de numeros a evaluar");
            rango=int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }

                contador++;
            }
            Console.WriteLine($"La cantidad de numeros pares de 1 hasta {rango} es: {contadorPares}");

            }
            
        }
    }
}
