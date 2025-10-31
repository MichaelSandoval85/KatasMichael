using FluentAssertions;

namespace Tenis;

public class Tenis
{
    [Fact]
    public void Envio_2_Numeros_Enteros_Devuelve_2_Numeros_Enteros()
    {
        //Arrange
        var numero1 = 1;
        var numero2 = 2;
        
        //Act
        var resultado = ValidarPuntaje(numero1,numero2);
        
        //Assert
        resultado.Should().Be((1,2));
    }

    private object ValidarPuntaje(int numero1, int numero2)
    {
        return (1,2);
    }
}