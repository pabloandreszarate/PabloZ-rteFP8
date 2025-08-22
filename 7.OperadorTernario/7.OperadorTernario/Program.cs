namespace _7.OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo usando el operador ternario que diga si una persona es mayor de edad o no

            int edad = 0;
            Console.WriteLine("ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine(edad >= 18 ? "La persona es mayor de edad" : "la persona no es mayor de dedad");

            //crear un algoritmo que permita ingresar 3 numeros enteros y mostrar pr pantalla cual es el mayor

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("ingrese el numero 1:");
            num1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 3:");
            num3 = Int32.Parse(Console.ReadLine());

            mayor = num1 > num2
                ? (num1 > num3 ? num1 : num3)
                : (num2>num3 ? num2 : num3);
            Console.WriteLine($"El numero mayor es {mayor}");
        }
    }
}
