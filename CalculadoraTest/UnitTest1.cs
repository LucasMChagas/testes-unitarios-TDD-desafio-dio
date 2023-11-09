using CalculadoraConsole;
namespace CalculadoraTest;

public class UnitTest1
{
    [Fact]
    public void DeveSomar1e2eRetornar3()
    {
        var calculadora = new Calculadora();
        
        int resultado = calculadora.Somar(1,2);

        Assert.Equal(3, resultado);
    }

    [Theory]
    [InlineData(5,5,10)]
    [InlineData(3,8,11)]
    [InlineData(11,12,23)]
    [InlineData(7,8,15)]
    [InlineData(20,24,44)]
    public void DeveSomar(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new Calculadora();

        int resultado = calculadora.Somar(num1,num2);

        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Theory]
    [InlineData(5,5,0)]
    [InlineData(3,8,-5)]
    [InlineData(11,12,-1)]
    [InlineData(7,8,-1)]
    [InlineData(20,24,-4)]
    public void DeveSubtrair(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new Calculadora();

        int resultado = calculadora.Subtrair(num1,num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(5,5,25)]
    [InlineData(3,8,24)]
    [InlineData(11,12,132)]
    [InlineData(7,8,56)]
    [InlineData(20,24,480)]
    public void DeveMultiplicar(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new Calculadora();

        int resultado = calculadora.Multiplicar(num1,num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(5,5,1)]
    [InlineData(3,8,0)]
    [InlineData(11,12,0)]
    [InlineData(7,8,0)]
    [InlineData(20,24,0)]
    public void DeveDividir(int num1, int num2, int resultadoEsperado)
    {
        var calculadora = new Calculadora();

        int resultado = calculadora.Dividir(num1,num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

}