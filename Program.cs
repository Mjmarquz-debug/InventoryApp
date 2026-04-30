// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;
var nombreDeUsuario = Environment.UserName();

void MostrarBanner()
{
    Console.WriteLine("===============================================");
    Console.WriteLine("SISTEMA DE INVENTARIO");
    Console.WriteLine("===============================================");
      Console.WriteLine("Hola {nombreDeUsuario}, bienvenido al sistema de inventario!");
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



int cantidadProductos = {Productos};
decimal valorTotalInventario = {sumInventario};
bool inventarioCargado = true;
string nombreDelSistema = "Sistema de Inventario";

Console.WriteLine($"Bienvenido al {nombreDelSistema}!");
Console.WriteLine($"Ingrese nombre de usuario: {nombreDeUsuario}");
string? nombreDeUsuarioInput = Console.ReadLine();
Console.WriteLine($"Actualmente hay {cantidadProductos} productos en el inventario.");
Console.WriteLine($"El valor total del inventario es: ${valorTotalInventario:N2}");
Console.WriteLine($"Inventario cargado: {inventarioCargado ? "Sí" : "No"}");

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

MostrarBanner();


Console.Write("Ingrese un comando o ingrese salir para terminar: ");
string? entrada = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada) || entrada.ToLower() == "salir")
{
    Console.WriteLine("Saliendo del programa...");
    Environment.Exit(0);
}

Console.WriteLine();
Console.WriteLine("Estado: Proyecto inicializado");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Agregar CLI y configuracion de repo GitHub");