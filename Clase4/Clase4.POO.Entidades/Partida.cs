namespace Clase4.POO.Entidades;

public class Partida
{
    public Personaje Jugador1 { get; }
    public Personaje Jugador2 { get; }
    public Partida(Personaje jugador1, Personaje jugador2)
    {
        Jugador1 = jugador1;
        Jugador2 = jugador2;
    }

    public int TurnoActual { get; set; } = 0;
    public int MaximoTurnos { get; set; } = 50;
}