namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arreglos unidimensionales
            //vectores

            int[] numeros=new int[5]; //el vector numeros tiene 5 pociciones 
            //los vectore siempre arrancan con el indice 0
            string[] nombres=new string[4];

            //asignar valores a las pocisiones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;
            //numeros[5] = 85; Erro de compilacion porque el indicfe numero 5 no existe, ya que el vector arranca desde el indice 0
            
            int[] numeros1 = new int[] { 5, 12, 4, 7, 9, 21};
            int[] numeros2 = { 5, 12, 4, 7, 9};
            // Se puede recorrer el vector llenarlo de datos o para recuperar los datos
            char[] caracter = new char[4];

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"ingrese el caracter para la posicion{i + 1}, con indice {i}:");
                caracter[i]=Convert.ToChar
                    (Console.ReadLine());
            }

            Console.WriteLine($"El vector caracter, en la posicion 3, tiene almacenado el dato: {caracter[2]}");//recuperar y mostrar un dato del vector

            for (int i = 0; i < 4;i++)
            {
                Console.WriteLine($"El vector caracter en la posicion {i + 1}, tiene anclado el dato: {caracter[i]}");
            }

            for (int i = 0; i < caracter.Length; i++) // .length devuelve el rango del vector
            {
                Console.Write(caracter[i] + " | ");
            }

            for (int i = 0; i < 4; i++ )
            { 
             Console.WriteLine($"ingrese los nombres para llenar el vector nombres: {nombres[0],nombres[1]}");
            }
        }
    }
}
