
namespace Tag;

class Id3v1Tag
{
    // título, artista, álbum y año de la canción.
    private string? titulo;
    private string? artista;
    private string? album;
    private DateTime anio;

    public string? Titulo { get => titulo; set => titulo = value; }
    public string? Artista { get => artista; set => artista = value; }
    public string? Album { get => album; set => album = value; }
    public DateTime Anio { get => anio; set => anio = value; }

    public Id3v1Tag()
    {

    }

    
}