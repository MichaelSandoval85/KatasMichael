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
        var resultado = ValidarCadena(cadena);
        
        //Assert
        resultado.Should().Be(0);
    }

    [Fact]
    public void Si_Envio_Un_Numero_Retorno_El_Mismo_Numero()
    {
        //Arrange
        string cadena = "6";
        
        //Act
        var  resultado = ValidarCadena(cadena);
        
        //Assert
        resultado.Should().Be(6);
    }

    [Fact]
    public void Si_Envio_Numeros_Negativos_Retornar_Mensaje_Error()
    {
        //Arrange
        string cadena = "-6";
        
        //Act
        var  resultado = ValidarCadena(cadena);
        
        //Assert
        resultado.Should().Be("No se pueden insertar numeros negativos");
    }
    private object ValidarCadena(string cadena)
    {
        return cadena == "" ? 0 : int.Parse(cadena);
    }
}