namespace _9.CicloWile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"contador:: {contador} - acumulador: {acumulador}");
                contador++;

            }

            Console.WriteLine($"la suma de los primeros 5 numeros es: + {acumulador}");
        }
    }
}
