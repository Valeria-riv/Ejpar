// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var zapa = new Zapatos();

zapa.id = 1;
zapa.modelo = "Zapatilla Deportiva";
zapa.talla = 42.5M;
zapa.estado = new Estados { id = 45, nombre = "Disponible" };
zapa.dispo = true;
zapa.fecha = DateTime.Now;

Console.WriteLine(zapa.modelo);
Console.WriteLine(zapa.estado.id);
Console.WriteLine(zapa.talla);

zapa.VideoJuegos = new List<VideoJuegos>();
zapa.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "GTA" });
zapa.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "DOOM" });



foreach (var elemento in zapa.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}


public class Zapatos
{
    public int id;
    public decimal talla;
    public string? modelo;
    public bool dispo;
    public Estados? estado;
    public DateTime fecha;
    public List<VideoJuegos>? VideoJuegos;
}

public class Tacones : Zapatos, IZapatos
{
    public decimal altura;
    public string? material;

    public bool guardar()
    {
      
        return true;
    }
}

public class Estados
{
    public int id;
    public string? nombre;
    public List<Zapatos>? zapatos;
}

public interface IZapatos
{
    bool guardar();
}
    
public class VideoJuegos
{
    public int Id;
    public string? Nombre;
}