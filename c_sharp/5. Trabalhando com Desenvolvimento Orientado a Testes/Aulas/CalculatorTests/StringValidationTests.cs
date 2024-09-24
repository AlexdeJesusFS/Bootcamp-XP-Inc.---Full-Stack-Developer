using System.Reflection;
using System.Runtime.CompilerServices;
using Calculator.Services;

namespace CalculatorTests;

public class StringValidationTest
{
    private StringValidation _stringValidation = new();

    [Fact]
    //padrão de nomenclatura MethodName_StateUnderTest_ExpectedBehavior (nome do metodo, estado antes do teste, comportamento esperado)
    public void CountCharacters_CountsCharactersInTheString_ReturnNumberOfCharacters()
    {
        //Arrange
        string text = "Lorym";

        //Act
        int result = _stringValidation.Countcharacters(text);

        //Assert
        Assert.Equal(5, result);
    }
}