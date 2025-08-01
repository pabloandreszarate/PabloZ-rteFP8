namespace _1.inicioVisualstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "pablo";
            const string iva = "19%";
            string apellidos = "Zárate López";
            Console.Write(nombre + " Bienvenido al curso de fundamentos programacion\n");
            nombre = "Andrés";
            //iva = "20%" no puedo cambiar el valorde iva por ser una constante
            Console.Write("\t" + nombre + " " + apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}
