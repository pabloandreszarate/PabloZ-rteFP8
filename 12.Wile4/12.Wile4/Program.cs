namespace _12.Wile4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int suma = 0;

            while (contador <=99)
            {
                suma += contador;
                Console.WriteLine($"{contador} - {suma} ");
                contador += 2;
                Console.WriteLine($"la suma de todos los numeros impares hasta 99 es {suma}");
            }
        }
    }
}
