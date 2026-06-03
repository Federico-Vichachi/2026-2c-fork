namespace Clase4.POO.Entidades;

public interface IAtaque
{
    public string Nombre { get; set; }
    public int Daño { get; set; }
}

public class AtaqueBasico : IAtaque
{
    public string Nombre { get; set; }
    public int Daño { get; set; }
    public AtaqueBasico(string nombre, int daño)
    {
        Nombre = nombre;
        Daño = daño;
    }
}
