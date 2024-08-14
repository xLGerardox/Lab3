public class MenuPrincipal
{
    static void Main(string[] args)
    {
        Tienda tienda = new Tienda();
        MostrarMenu(tienda);
    }

    static void MostrarMenu(Tienda tienda)
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Registrar Cliente Regular");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        RegistrarClienteRegular(tienda);
                        break;
                    case 2:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void RegistrarClienteRegular(Tienda tienda)
    {
        Console.Clear();
        Console.WriteLine("Registrar Cliente Regular");
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Correo Electrónico: ");
        string correo = Console.ReadLine();
        Console.Write("Dirección: ");
        string direccion = Console.ReadLine();

        ClienteRegular cliente = new ClienteRegular(nombre, correo, direccion);
        tienda.Clientes.Add(cliente);
        Console.WriteLine("Cliente registrado con éxito.");
    }
}
