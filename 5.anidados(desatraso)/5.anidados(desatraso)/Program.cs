namespace _5.anidados_desatraso_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"el numero {num1}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"el numero {num2}, es el mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {

                    Console.WriteLine($"el numero {num2}, es el mayor");

                }
                else
                {
                    Console.WriteLine($"el numero {num3}, es el mayor");
                }
            }
    }
}
