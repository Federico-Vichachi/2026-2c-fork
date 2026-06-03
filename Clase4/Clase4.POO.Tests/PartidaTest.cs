using Clase4.POO.Entidades;
using Clase4.POO.Entidades.Personajes;

namespace Clase4.POO.Tests;

public class PartidaTest
{
    [Fact]
    public void EjecutarTurnosPartida()
    {
        var elfo = new Elfo();
        var hechicero = new Hechicero();

        do
        {
            elfo.EjecutarAtaqueBasico(hechicero);
            
            if(hechicero.Derrotado)
                break;

            hechicero.EjecutarAtaqueBasico(elfo);
            
            if (elfo.Derrotado)
                break;

        } while (!elfo.Derrotado && !hechicero.Derrotado);

        Assert.True(hechicero.Derrotado);
    }

    [Fact]
    public void EjecutarHabilidadesPartida()
    {
        var elfo = new Elfo();
        elfo.Mana = 100000;

        var hechicero = new Hechicero();
        hechicero.Mana = 100000;
        do
        {
            var habilidadesElfo = elfo.ObtenerHabilidadesDisponibles();
            var habilidadElfo = habilidadesElfo.FirstOrDefault();

            elfo.EjecutarHabilidad(habilidadElfo, hechicero);

            if (hechicero.Derrotado)
                break;

            var habilidadesHechicero = hechicero.ObtenerHabilidadesDisponibles();
            var habilidadHechicero = habilidadesHechicero.FirstOrDefault();

            hechicero.EjecutarHabilidad(habilidadHechicero, elfo);

            if (elfo.Derrotado)
                break;

            habilidadElfo.TurnosPendientesParaEjecutar -= 1;
            habilidadHechicero.TurnosPendientesParaEjecutar -= 1;
        } while (!elfo.Derrotado && !hechicero.Derrotado);

        Assert.True(hechicero.Derrotado);
    }
}
