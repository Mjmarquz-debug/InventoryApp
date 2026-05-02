using System.Data.SqlTypes;
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;
int cantidadProductos = 0;
bool ejecutar = true;

void MostrarBanner(string nombreFinal)
{
    Console.WriteLine("===============================================");
    Console.WriteLine("SISTEMA DE INVENTARIO");
    Console.WriteLine("===============================================");
}

void MostrarAyuda()
{
    Console.WriteLine("USO: InventarioApp [comando] [opciones]");
    Console.WriteLine();
    Console.WriteLine("COMANDOS:");
    Console.WriteLine("  --help, -h      Muestra esta ayuda");
    Console.WriteLine("  --version, -v   Muestra la version del programa");
    Console.WriteLine();
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine(" dotnet run -- --help");
    Console.WriteLine(" dotnet run -- --version");
}

void MostrarInventario()
{
    Console.WriteLine("INVENTARIO ACTUAL:");
}

void AgregarProducto()
{
    Console.WriteLine("¿Quieres agregar productos al inventario? (si/no)");
    bool respuestaInventario = Console.ReadLine()?.ToLower() == "si";

    if (respuestaInventario)
    {
        Console.WriteLine("¡Genial! Vamos a agregar productos al inventario.");

        Console.Write("Ingrese el nombre del producto: ");
        string? nombreProducto = Console.ReadLine();

        Console.Write("Ingrese una cantidad: ");
        string? cantidadInput = Console.ReadLine();

        if (int.TryParse(cantidadInput, out int cantidad))
        {
            cantidadProductos += cantidad;
            Console.WriteLine($"Se agregaron {cantidad} unidades de {nombreProducto}.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ser un número entero.");
        }
    }
    else
    {
        Console.WriteLine("No hay problema. Puedes agregar productos más tarde.");
    }
}

while (ejecutar)
{
    Console.WriteLine("Ingrese nombre de usuario:");
    string? nombreInput = Console.ReadLine();

    string nombreFinal = string.IsNullOrWhiteSpace(nombreInput)
        ? "Usuario"
        : nombreInput;

    Console.WriteLine($"\nHola {nombreFinal}, bienvenido al sistema de inventario!\n");

    MostrarBanner(nombreFinal);

    Console.WriteLine($"Actualmente hay {cantidadProductos} productos en el inventario.\n");

    AgregarProducto();

    Console.WriteLine($"\nAhora hay {cantidadProductos} productos en el inventario.\n");

    // Opciones después de operar
    Console.WriteLine("¿Qué deseas hacer ahora?");
    Console.WriteLine("1. Volver al inicio");
    Console.WriteLine("2. Ver lista de productos");
    Console.WriteLine("3. Ver ayuda");
    Console.WriteLine("4. Salir");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            // No hace nada → el while reinicia
            break;
        case "2":
            MostrarInventario();
            break;
        case "3":
            MostrarAyuda();
            break;

        case "4":
            Console.WriteLine("Saliendo del programa...");
            ejecutar = false;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    Console.WriteLine("\n-----------------------------------------------\n");
}