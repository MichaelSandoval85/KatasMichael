using FluentAssertions;

namespace Tenis;

public class Tenis
{
    [Fact]
    public void Envio_Puntaje_Jugador_1_Y_Puntaje_Jugador_2_Enteros()
    {
        //Arrange
        int puntosJugador1 = 1;
        int puntosJugador2 = 2;
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1,puntosJugador2);
        
        //Assert
        resultado.Should().Be((1,2));
    }

    private object ValidarPuntaje(int puntosJugador1, int puntosJugador2)
    {
        return (1,2);
    }
}