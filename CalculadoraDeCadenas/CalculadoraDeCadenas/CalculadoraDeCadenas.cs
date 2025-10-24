using AwesomeAssertions;

namespace CalculadoraDeCadenas;

public class CalculadoraDeCadenas
{
    [Fact]
    public void Si_Envio_Cadena_Vacia_Retorno_0()
    {
        //Arrange
        string cadena = "";
        
        //Act
        int resultado = ValidarCadena(cadena);
        
        //Assert
        resultado.Should().Be(0);
    }

    [Fact]
    public void Si_Envio_Un_Numero_Retorno_El_Mismo_Numero()
    {
        //Arrange
        string cadena = "6";
        
        //Act
        int  resultado = ValidarCadena(cadena);
        
        //Assert
        resultado.Should().Be(6);
    }
    private int ValidarCadena(string cadena)
    {
        return 0 ;
    }
}