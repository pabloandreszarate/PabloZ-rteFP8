namespace _19.Dowile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int hombres = 0;
            int mujeres = 0;
            int estudiantes = 0;
            int mayoresEdad = 0;
            int menoresEdad = 0;
            int cantidad = 0;
            int genero = 0;

            do
            {
                Console.WriteLine("Ingrese su edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese su genero: 1 para hombre, 2 para mujer");
                genero = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    mayoresEdad++;
                }
                else
                {
                    menoresEdad++;
                }

                if (genero == 1)
                {
                    hombres++;
                }
                else if (genero == 2)
                {
                    mujeres++;
                }
                else
                {
                    Console.WriteLine("Ingrese un genero Valido");
                }
                estudiantes++;

            } while (estudiantes < cantidad);

            Console.WriteLine($"De los {cantidad} estudiantes, {mayoresEdad} son mayores de edad, {menoresEdad} son menores de edad, {hombres} son hombres y {mujeres} son mujeres");
        
        }
    }
}
