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
        string cadena = "1,2,3,4";

        //Act
        var  resultado = ValidarCadena(cadena);

        //Assert
        resultado.Should().Be(10);
    }
    private object ValidarCadena(string cadena)
    {
        if (cadena.Contains(","))
        {
            string[] numeros = cadena.Split(',');
            int suma = 0;

            foreach (string numero in numeros)
            {
                int valor = Convert.ToInt32(numero);
                if (valor < 0)
                    return "No se pueden insertar numeros negativos";
                suma += valor;
            }

            return suma;
        }
        
        return cadena == "" ? 0 :
            Convert.ToInt32(cadena) < 0 ? "No se pueden insertar numeros negativos" : Convert.ToInt32(cadena);
    }
}