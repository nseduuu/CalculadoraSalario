namespace CalculadoraSalario.Tests;

public class CalculadoraSalarioTest
{
    [Fact]
    public void Should_Pay_5_Percent_INSS_Tax()
    {
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();
        double salarioBruto = 800;

        double inss = calculadoraSalario.GetDescontoInss(salarioBruto);
        double desconto = 40.0;

        Assert.Equal(desconto, inss);

    }

    [Fact]
    public void Should_Throw_Exception_When_Brute_Salary_Is_Less_Than_Zero() 
    {
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();
        double salarioNegativo = -400.0;

        Assert.Throws<Exception>(() => calculadoraSalario.GetDescontoInss(salarioNegativo));
    }

    [Fact]
    public void Should_Pay_10_Percent_INSS_Tax() 
    {
        CalculadoraSalario calculadoraSalario = new CalculadoraSalario();
        double salarioBruto = 1200;

        double inss = calculadoraSalario.GetDescontoInss(salarioBruto);
        double desconto = 120.0;

        Assert.Equal(desconto, inss);
    }
}