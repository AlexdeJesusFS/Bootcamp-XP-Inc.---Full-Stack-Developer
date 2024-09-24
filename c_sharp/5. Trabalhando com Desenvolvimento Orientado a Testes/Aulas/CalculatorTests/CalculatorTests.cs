using System.Reflection;
using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private CalculatorImp _calculator = new();

    [Fact]
    //padrão de nomenclatura MethodName_StateUnderTest_ExpectedBehavior (nome do metodo, estado antes do teste, comportamento esperado)
    public void Sum_WhenAddingTwoPositiveNumbers_ReturnsCorrectSum()
    {
        //Arrange
        float n1 = 10;
        float n2 = 8;

        //Act
        float result = _calculator!.Sum(n1, n2);

        //Assert
        Assert.Equal(18, result);
    }

    [Fact]
    public void IsPair_CheckIfNumberIsEven_ReturnTrueIfIsEven()
    {
        //Arrange
        int n = 2;

        //Act
        bool result = _calculator.IsPair(n);

        //Assert
        Assert.True(result);
    }

    [Theory]
    //Arrange
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8})]
    public void IsPair_CheckIfNumbersIsEven_ReturnTrueIfIsEven(int[] numbers)
    {
        //Act and Assert
        Assert.All(numbers, number => Assert.True(_calculator.IsPair(number)));
    }

}