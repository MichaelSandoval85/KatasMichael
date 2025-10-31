using FluentAssertions;

namespace Tenis;

public class Tenis
{
    [Fact]
    public void Envio_Puntaje_Jugador_1_Y_Puntaje_Jugador_2_Enteros()
    {
        //Arrange
        string puntosJugador1 = "4";
        string puntosJugador2 = "5";
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1,puntosJugador2);
        
        //Assert
        resultado.Should().Be(("1","2"));
    }

    [Fact]
    public void Gana_El_Primer_Jugador_Que_Tenga_Minimo_4_Puntos_Y_2_Puntos_Adicionales_A_Los_Del_Oponente()
    {
        //Arrange
        string puntosJugador1 = "0";
        string puntosJugador2 = "4";
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1, puntosJugador2);
        
        //Assert
        resultado.Should().BeEquivalentTo(("Ganador Jugador2","Forty"));
    }

    [Fact]
    public void Envio_Puntaje_De_Dos_Jugadores_Entre_0_Y_3_Retorno_Love_Fifteen_Thirty_Forty_Respectivamente()
    {
        //Arrange
        string puntosJugador1 = "0";
        string puntosJugador2 = "2";
        
        //Act
        var resultado = ValidarPuntaje(puntosJugador1, puntosJugador2);
        
        //Assert
        resultado.Should().BeEquivalentTo(("Jugador 1 Love", "Jugador 2 Thirty"));
    }

    [Fact]
    public void Envio_Puntaje_De_Dos_Jugadores_Si_Los_Dos_Puntajes_Son_De_Almenos_3_Puntos_Y_Son_Iguales_Retorno_Deuce()
    {
        //Arrange
        string puntosJugador1 = "3";
        string puntosJugador2 = "3";
        //Act
        var resultado = ValidarPuntaje(puntosJugador1, puntosJugador2);
        //Assert
        resultado.Should().BeEquivalentTo(("Resultado", "Deuce"));
    }
    private object ValidarPuntaje(string puntosJugador1, string puntosJugador2)
    {
        int jugador1Puntos = int.Parse(puntosJugador1);
        int jugador2Puntos = int.Parse(puntosJugador2);
        
        if (jugador1Puntos >= 4 && (jugador1Puntos - jugador2Puntos) >= 2)
            return ("Ganador Jugador1", ConvertirPuntos(puntosJugador1));
        
        if (jugador2Puntos >= 4 && (jugador2Puntos - jugador1Puntos) >= 2)
            return ("Ganador Jugador2", ConvertirPuntos(puntosJugador2));

        if(jugador1Puntos >= 3 && jugador2Puntos >= 3)
            if (jugador1Puntos == jugador2Puntos)
                return ("Resultado","Deuce");
        
        if (jugador1Puntos <= 3 || jugador2Puntos <= 3)
            return ("Jugador 1 " +  ConvertirPuntos(puntosJugador1), "Jugador 2 " + ConvertirPuntos(puntosJugador2));
        
        return ("1","2"); 
    }
    
    public object ConvertirPuntos(string puntos)
    {
        switch (puntos)
        {
            case "0":
                return "Love";
            case "1":
                return "Fifteen";
            case "2":
                return "Thirty";
            case "3":  
                return "Forty";
            
            default: return "Forty";
        }
    }
}