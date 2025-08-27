namespace ParcialCondicionales
{
    internal class Program
    {
        static float Main(string[] args)
        {
            /*En una empresa de confecciones, al finalizar cada año se realiza una evaluación de desempeño para todos los empleados. Con base en esta evaluación, los trabajadores pueden obtener aumentos salariales. Las calificaciones posibles son limitadas y se consideran ciertos criterios para calcular el porcentaje de aumento.

            Requerimientos del programa

            Se debe desarrollar un programa en C# que permita (70%):

            Ingresar los siguientes datos del empleado:

            Nombre del empleado.
            Número de años trabajados en la empresa.
            Calificación del año actual (0.0, 0.4, 0.6, 1.0).
            Calificación del año anterior (debe ser uno de los mismos valores anteriores).

            2. Validar que las calificaciones ingresadas estén entre los valores permitidos.

            Si la calificación actual no corresponde a ninguno de los valores válidos (0.0, 0.4, 0.6, 1.0), el programa debe mostrar un mensaje de error y terminar inmediatamente.

            3. Calcular el promedio de las dos calificaciones (año actual y anterior).

            4. Según el número de años trabajados y el promedio de calificación, determinar el porcentaje de aumento salarial utilizando las siguientes reglas:

            añosTrabajados < 1  =   0%
            añosTrabajados > 5  =   30%
            0 < añosTrabajados <= 5 y 0 <= promedioCalificación < 0.4    =    5%
            0 < añosTrabajados <= 5 y 0.4 <= promedioCalificación < 0.6    =   10%
            0 < añosTrabajados <= 5 y 0.6 <= promedioCalificación <= 1.0   =   20%

             5. Todos los empleados tienen un sueldo base fijo de $2.500.000.
                El aumento se calcula como:  valorAumento = sueldoBase×(porcentajeAumento/100​)
                                   
            6. El programa debe mostrar al final:
            Nombre del empleado.
            Promedio de la calificación.
            Porcentaje de aumento aplicado.
            Valor del aumento en pesos.*/

            string nombre = "";
            int AñosTrabajo = 0;
            float CalificacionActual = 0;
            float CalificacionAnterior = 0;
            
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese cuantos años ha trabajado en la empresa:");
            AñosTrabajo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su calificacion actual:");
            CalificacionActual = Single.Parse(Console.ReadLine());

            if (CalificacionActual == (0.0, 0.4, 0.6, 1.0))
            {
                Console.WriteLine("Ingrese su calificacion del año anterior:");
                CalificacionAnterior = Single.Parse(Console.ReadLine());

                if (CalificacionAnterior == 0.0, 0.4, 0.6, 1.0))
                    {
                    Console.WriteLine($"El prodeio de sus calificaciones es: {(CalificacionActual + CalificacionAnterior) / 2}");
                    }
                else
                {
                    Console.WriteLine("ingrese un numero valido");
                }



                    

            }
            else
            {
                Console.WriteLine("ingrese un numero correcto");
            }


               
            




        }
    }
}
