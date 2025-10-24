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
    
    [Fact]
    public void Si_Envio_Una_Cadena_De_Numeros_Deben_Sumarse()
    {
        //Arrange
        string [] cadena = ["1,2,3,4"];
        
        //Act
        var  resultado = ValidarCadena(cadena);
        
        //Assert
        resultado.Should().Be(10);
    }
    private object ValidarCadena(object cadena)
    {
        return cadena == "" ? 0 :
            Convert.ToInt32(cadena) < 0 ? "No se pueden insertar numeros negativos" : Convert.ToInt32(cadena);
    }
}