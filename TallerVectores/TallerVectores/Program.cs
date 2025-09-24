namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Vector; //declarando

            Vector = new int[15]; //inicializar
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < Vector.Length; i++) //lenght devuelve el rango y posiciones del vector

            {
                Console.WriteLine($"ingrese el numero entero para la posicion {i + 1}, con indice {i}");
                Vector[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = Vector[i];
                    menor = Vector[i];
                }
                else
                {
                    if (Vector[i] >mayor)
                    {
                        mayor=Vector[i];
                    }
                    if (Vector[i] < menor)
                    {
                        menor=Vector[i];
                    }
                }
            }
            Console.Clear();

            for (int i = 0;i < Vector.Length;i++)
            {
                Console.Write(Vector[i]+ " |");
            }

            Console.WriteLine($"el numero mayor es: {mayor}, el bumero menor es: {menor}");


            string[] Caracteres;  
            Caracteres = new string[Vector.Length];

            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine($"ingrese los caracteres que desee invertir");
                Caracteres[i] = string.Parse(Console.ReadLine());
            }
        }
    }
}
