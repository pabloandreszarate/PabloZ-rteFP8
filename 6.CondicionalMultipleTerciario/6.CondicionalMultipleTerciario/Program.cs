namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ValorCompra = 0;
            float Descuento = 0;
            char dia = ' ';

            Console.WriteLine("ingrese el valor de la compra: ");
            ValorCompra =Single.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el dia de la semana: L: lunes, M: martes, X: miercoles, J: jueves, V: viernes, S: sabado, D: Domingo");
            dia=Convert.ToChar(Console.ReadLine());

            switch(dia)
            {
                case 'L':
                    Descuento=ValorCompra *0.1f;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 10%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                case 'M':
                    Descuento = ValorCompra * 0.15f;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 15%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                case 'X':
                    Descuento = ValorCompra * 0.1f;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 10%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                case 'J':
                    Descuento = ValorCompra * 0.15f;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 15%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                case 'V':
                    Descuento = ValorCompra * 0.2f;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 15%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                case 'S':
                    Descuento = ValorCompra * 0.2f;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 15%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                case 'D':
                    Descuento = 0;
                    Console.WriteLine($"el valor del descuento del dia de hoy es de 15%, el valor total de su compra es {ValorCompra - Descuento}");
                    break;

                default:
                    Console.WriteLine("ingrese un dia correcto");
                    break;


            }

        }
    }
}
