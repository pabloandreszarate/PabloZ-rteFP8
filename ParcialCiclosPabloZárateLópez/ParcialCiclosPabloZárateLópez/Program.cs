namespace ParcialCiclosPabloZárateLópez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un profesor tiene las calificaciones de 14 alumnos y necesita procesar la información para obtener un análisis general del curso. Las notas se encuentran en un rango de 0 a 10.
            El programa debe realizar las siguientes operaciones:
            Leer por teclado la nota de cada uno de los 14 estudiantes.
            Calcular el promedio de todas las notas.
            Identificar y mostrar cuál fue la nota mayor y la nota menor entre las ingresadas.
            Contar cuántos estudiantes aprobaron la asignatura (nota mayor o igual a 6.0).
            Mostrar por pantalla:
            El promedio general.
            La nota más alta.
            La nota más baja.
            La cantidad de aprobados en el curso.*/

            /*int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            int nota5 = 0;
            int nota6 = 0;
            int nota7 = 0;
            int nota8 = 0;
            int nota9 = 0;
            int nota10 = 0;
            int nota11 = 0;
            int nota12 = 0;
            int nota13 = 0;
            int nota14 = 0;

            do
            {
                Console.WriteLine("ingrese la nota numero 1");
                 nota1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 2");
                nota2 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 3");
                nota3 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 4");
                nota4 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 5");
                nota5 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 6");
                nota6 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 7");
                nota7 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 8");
                nota8 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 9");
                nota9 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 10");
                nota10 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 11");
                nota11 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 12");
                nota12 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 13");
                nota13 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la nota numero 14");
                nota14 = Int32.Parse(Console.ReadLine());


            } while (nota1 < nota2 < nota3 < nota4 < nota5 < nota6 < nota7 < nota8 < nota9 < nota10 < nota11 < nota12 < nota13 < nota14);

            if 
            {


            }*/

            int estudiantes = 0;
            Console.WriteLine("ingrese el numero de estudiantes (14)");
            estudiantes = Int32.Parse(Console.ReadLine());

            int aprobados = 0;
            int notaAlta = 0;
            int notaBaja = 0;
            int promedio = 0;
            int contador = 0;
            int totalNotas = 0;

            do
            {
                int nota = 1;
                string entrada;

                Console.WriteLine("ingrese la nota (0 a 10)");
                nota = Int32.Parse(Console.ReadLine());

                if (nota > 10 || nota < 0)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {

                    totalNotas += nota;
                    if (nota > notaAlta)
                    {
                        nota = notaAlta;
                    }

                    if (nota < notaBaja)
                    {
                        notaBaja = nota;
                    }

                    if (nota >= 6)
                    {
                        aprobados++;
                    }

                    contador++;
                }


            } while (contador == 14) ;

            promedio = totalNotas/ estudiantes;

                Console.WriteLine($"el promedio de notas fue: {promedio}");
                Console.WriteLine($"el total de estudiantes que pasaron fue:{aprobados}");
                Console.WriteLine($"la nota mas alta fue: {notaAlta}");
                Console.WriteLine($"la nota mas baja fue: {notaBaja}");

        }
    }
}
