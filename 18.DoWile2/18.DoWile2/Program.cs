namespace _18.DoWile2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numUsuarios = 0;
            string nombre = "";
            int numCuenta = 0;
            int saldo = 0;
            string bandera = "Y";
            double sumaSaldos = 0;

            do
            {
                nombre = "";
                numCuenta = 0;
                saldo = 0;
                numUsuarios++;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta, no debe tener ni puntos ni espacios");
                numCuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = Convert.ToInt32(Console.ReadLine());

                switch (saldo)
                {
                    case > 3000000:
                        Console.WriteLine($"Nombre: {nombre}; Número de cuenta: {numCuenta}; Saldo: {saldo}.");
                        Console.WriteLine("Es apto para el crédito");
                        sumaSaldos += saldo;
                        break;
                    case < 3000000:
                        Console.WriteLine($"Nombre: {nombre}; Número de cuenta: {numCuenta}; Saldo: {saldo}.");
                        Console.WriteLine("No es apto para el crédito");
                        sumaSaldos += saldo;
                        break;
                    default:
                        Console.WriteLine("Numero invalido");
                        break;
                }

                Console.WriteLine("quiere ingresar un nuevo usuario? Y: si, N: no");
                bandera = Console.ReadLine().ToLower();
            } while (bandera == "y");

            Console.WriteLine($"En numero de usuarios fue: {numUsuarios} ");
            Console.WriteLine($"{sumaSaldos / numUsuarios} fue el promedio de saldos");
        }
    }
}
