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

    private int ValidarCadena(string cadena)
    {
        throw new NotImplementedException();
    }
}