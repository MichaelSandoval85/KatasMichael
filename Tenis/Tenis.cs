using FluentAssertions;

namespace Tenis;

public class Tenis
{
    [Fact]
    public void Envio_Puntaje_Jugador_1_Y_Puntaje_Jugador_2_Enteros()
    {
        //Arrange
        string puntosJugador1 = "1";
        string puntosJugador2 = "2";
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1,puntosJugador2);
        
        //Assert
        resultado.Should().Be(("1","2"));
    }

    [Fact]
    public void Gana_El_Primer_Jugador_Que_Tenga_Minimo_4_Puntos_Y_2_Puntos_Adicionales_A_Los_Del_Oponente()
    {
        //Arrange
        string puntosJugador1 = "4";
        string puntosJugador2 = "6";
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1, puntosJugador2);
        
        //Assert
        resultado.Should().Be(("Jugador 2","6"));
    }
    
    private object ValidarPuntaje(string puntosJugador1, string puntosJugador2)
    {
        int jugador1Puntos = int.Parse(puntosJugador1);
        int jugador2Puntos = int.Parse(puntosJugador2);
        
        if (jugador1Puntos >= 4 && (jugador1Puntos - jugador2Puntos) >= 2)
            return ("Jugador 1", jugador2Puntos.ToString());
        
        if (jugador2Puntos >= 4 && (jugador2Puntos - jugador1Puntos) >= 2)
            return ("Jugador 2", jugador2Puntos.ToString());

        return ("1","2"); 
    }
}