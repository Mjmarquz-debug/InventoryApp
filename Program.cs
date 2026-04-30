using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

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

int cantidadProductos = 0;

Console.WriteLine($"Ingrese nombre de usuario:  ");
string? nombreDeUsuarioInput = Console.ReadLine();

string nombreFinal = string.IsNullOrWhiteSpace(nombreDeUsuarioInput) 
? "Usuario"
: nombreDeUsuarioInput;

Console.WriteLine($"Hola {nombreFinal}, bienvenido al sistema de inventario!");

Console.WriteLine($"Actualmente hay {cantidadProductos} productos en el inventario.");

Console.WriteLine("Quieres agregar productos al inventario? (s/n)");
bool? respuestaInventario = Console.ReadLine()?.ToLower() == "si" ? true : false;

if (respuestaInventario == true)
{
    Console.WriteLine("¡Genial! Vamos a agregar productos al inventario.");
    Console.Write("Ingrese una cantidad: ");
    string? cantidadInput = Console.ReadLine();
        if (int.TryParse(cantidadInput, out int cantidad))
            {
            Console.WriteLine($"Cantidad ingresada: {cantidad}");
            cantidadProductos = cantidad;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero.");
            }
}
else
{
    Console.WriteLine("No hay problema. Puedes agregar productos más tarde.");

}

MostrarBanner(nombreFinal);


Console.WriteLine();
Console.WriteLine("Quieres ayuda? (s/n)");
bool? respuestaAyuda = Console.ReadLine()?.ToLower() == "si" ? true : false;
Console.WriteLine();
if (respuestaAyuda == true)
{
    MostrarAyuda();
}
else
{
    Console.WriteLine("No hay problema. Puedes solicitar ayuda más tarde.");
}


Console.Write("Ingrese un comando o ingrese salir para terminar: ");
string? entrada = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Saliendo del programa...");
    Environment.Exit(0);
}