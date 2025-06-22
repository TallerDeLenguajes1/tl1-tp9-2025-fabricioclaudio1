using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.IO;

string? pathIngresado;

Console.WriteLine("Ingrese el path de un Directorio que desee analizar: ");
pathIngresado = Console.ReadLine();

while (Directory.Exists(pathIngresado) == false)
{
    Console.WriteLine("Por favor ingrese un path valido nuevamente: ");
    pathIngresado = Console.ReadLine();
}

Console.WriteLine($"--- Carpetas del directorio: {pathIngresado} ---");

foreach (var directorio in Directory.GetDirectories(pathIngresado))
{
    var info = new DirectoryInfo(directorio);
    Console.WriteLine($"{info.Name}");
}

foreach (var archivo in Directory.GetFiles(pathIngresado))
{
    var info = new FileInfo(archivo);
    Console.WriteLine($"{info.Name} {info.Length / 1000}.{info.Length % 1000}KB  ({info.LastWriteTime})");
}
List<string> datos = new List<string>();
string columnas = "Nombre del archivo;Tamaño del Archivo (KB);Fecha de Última Modificación";
datos.Add(columnas);
string pathRelativoDirectorio = @"..\..\tl1-tprepaso-2025-fabricioclaudio1\";
string pathRelativoArchivo = @"..\..\tl1-tprepaso-2025-fabricioclaudio1\reporte_archivos.csv";
if (Directory.Exists(pathRelativoDirectorio) && !File.Exists(pathRelativoArchivo))
{
    foreach (var archivo in Directory.GetFiles(pathRelativoDirectorio))
    {
        var info = new FileInfo(archivo);
        string arrayArchivo = $"{info.Name};{info.Length / 1000}.{info.Length % 1000};{info.LastWriteTime:dd/MM/yy}";
        datos.Add(arrayArchivo);
        
    }
    File.WriteAllLines(pathRelativoArchivo,datos);
}




