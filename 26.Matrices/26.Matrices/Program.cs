namespace _26.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2]; //matris de dos espacios y dos columnas
            string[,] nombres = new string[2, 3]; //Rango=6 posiciones

            //asignacion de datos
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;

            //otra forma de inicializar matrices
            string[,] apellidos =
            {
                {"Zárate", "lópez" },
                {"Cardona", "rios" },
                {"Mejia","Cano" }
            };

            //recuperar datos
            Console.WriteLine(apellidos[1, 1]);

            //recorrer matrices - almacenar datos
            char[,] caracteres = new char[3, 2];

            for (int i = 0; i < 2; i++) //recorrer las filas
            {
                for (int j = 0; j < 2; j++) //recorrer las columnas de cada una de las filas
                {
                    Console.WriteLine($"Ingrese le caracter para la posicion con indices {i}, {j}:");
                    caracteres[i, j]=char.Parse(Console.ReadLine());
                }
            }

            //recorrer matrices - recuperar datos
            for (int i = 0; i < caracteres.GetLength(0); i++) // .GetLength(0) devuelve el numero de filas
            {
                for (int j = 0;j < caracteres.GetLength(1); j++) // .GetLength(1) devuelve el numero de columnas
                {
                    //Console.WriteLine($"caracter posicion {i}, {j}: {caracteres[i,j]}");
                    Console.Write($"{caracteres[i, j]} |");
                }
                Console.WriteLine();
            }

            //Rango de la matris
            Console.WriteLine(caracteres.Length);


        }
    }
}
