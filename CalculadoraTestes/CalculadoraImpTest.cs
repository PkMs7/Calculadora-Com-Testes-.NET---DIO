using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraImpTest
{
    private CalculadoraImp _calc;

    public CalculadoraImpTest()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair10Com5ERetornar5()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int resultado = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveDividir10Com5ERetornar2()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int resultado = _calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void DeveMultiplicar10Com5ERetornar50()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int resultado = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DeveContarOlaERetornar3()
    {
        //Arrange
        string texto = "Olá";

        //Act
        int resultado = _calc.ContarCaracteres(texto);

        //Assert
        Assert.Equal(3, resultado);
    }

    //Arrange
    [Theory]
    [InlineData(2)] // Utilizado para testar vários cenários em uma função
    public void DeveIdentificarSe2ForParERetornarVerdadeiro(int num)
    {

        //Act
        bool resultado = _calc.IdentificarNumeroPar(num);

        //Assert
        Assert.True(resultado);
    }

    //Arrange
    [Theory]
    [InlineData(3)] // Utilizado para testar vários cenários em uma função
    public void DeveIdentificarQue3NaoPodeSerParERetornarFalso(int num)
    {

        //Act
        bool resultado = _calc.IdentificarNumeroPar(num);

        //Assert
        Assert.False(resultado);
    }

    //Arrange
    [Theory]
    [InlineData (new int[] {3})] // Utilizado para testar vários cenários em uma função com um array de cenários
    public void DeveIdentificarSe3ForImparERetornarVerdadeiro(int[] nums)
    {
        //Act e Assert
        Assert.All(nums, num => Assert.True(_calc.IdentificarNumeroImpar(num)));
    }

    //Arrange
    [Theory]
    [InlineData (new int[] {2})] // Utilizado para testar vários cenários em uma função com um array de cenários
    public void DeveIdentificarQue2NaoPodeSerImparERetornarFalso(int[] nums)
    {
        //Act e Assert
        Assert.All(nums, num => Assert.False(_calc.IdentificarNumeroImpar(num)));
    }

}