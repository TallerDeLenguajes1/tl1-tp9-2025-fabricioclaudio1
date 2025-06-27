// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;

string path = "C:\\repo-taller\\tl1-tprepaso-2025-fabricioclaudio1\\Aerosmith.mp3";
byte[] buffer = new byte[128];
int bytesRead = 0;
string titulo;
string artista;
string album;
string anio;

using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    fs.Seek(-128, SeekOrigin.End);
    bytesRead = fs.Read(buffer, 0, buffer.Length);
}

titulo = Encoding.UTF8.GetString(buffer, 3, 30);
artista = Encoding.UTF8.GetString(buffer, 33, 30);
album = Encoding.UTF8.GetString(buffer, 63, 30);
anio = Encoding.UTF8.GetString(buffer, 93, 4);

if (bytesRead == 128 && buffer[0] == (byte)'T' && buffer[1] == (byte)'A' && buffer[2] == (byte)'G')
{
Console.WriteLine(@$"El archivo contiene una etiqueta ID3v1. Bytes leidos {bytesRead}
{titulo}
{artista}
{album}
{anio}
");
}
else
{
    Console.WriteLine("El archivo NO contiene una etiqueta ID3v1.");

}