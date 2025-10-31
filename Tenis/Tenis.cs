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

    [Fact]
    public void Gana_El_Primer_Jugador_Que_Tenga_Minimo_4_Puntos_Y_2_Puntos_Adicionales_A_Los_Del_Oponente()
    {
        //Arrange
        int puntosJugador1 = 4;
        int puntosJugador2 = 3;
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1, puntosJugador2);
        
        //Assert
        resultado.Should().Be((6,4));
    }
    
    private object ValidarPuntaje(int puntosJugador1, int puntosJugador2)
    {
        if (puntosJugador1 >= 4 && (puntosJugador1 - puntosJugador2) >= 2)
            return (puntosJugador1, puntosJugador2);
        
        if (puntosJugador2 >= 4 && (puntosJugador2 - puntosJugador1) >= 2)
            return (puntosJugador1, puntosJugador2);
        
        return (1,2);
    }
}