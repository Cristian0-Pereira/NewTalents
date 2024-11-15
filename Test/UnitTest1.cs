using New_Talents;

namespace Test;

public class UnitTest1
{
    public Calculator ConstructClass()
    {
        Calculator calc = new("02/02/2020");

        return calc;
    }

    [Theory]
    [InlineData( 1, 2, 3 )]
    [InlineData( 4, 5, 9 )]
    public void TestAdd(int val1, int val2, int result)
    {
        Calculator calc = ConstructClass();

        int calculatorResult = calc.Add(val1, val2);

         Assert.Equal(result, calculatorResult);
    }

    [Theory]
    [InlineData( 1, 2, 2 )]
    [InlineData( 4, 5, 20 )]
    public void TestMultiply(int val1, int val2, int result)
    {
        Calculator calc = ConstructClass();

        int calculatorResult = calc.Multiply(val1, val2);

         Assert.Equal(result, calculatorResult);
    }

    [Theory]
    [InlineData( 6, 2, 3 )]
    [InlineData( 5, 5, 1 )]
    public void TestDivide(int val1, int val2, int result)
    {
        Calculator calc = ConstructClass();

        int calculatorResult = calc.Divide(val1, val2);

         Assert.Equal(result, calculatorResult);
    }

    [Theory]
    [InlineData( 6, 2, 4 )]
    [InlineData( 5, 5, 0 )]
    public void TestSubtract(int val1, int val2, int result)
    {
        Calculator calc = ConstructClass();

        int calculatorResult = calc.Subtract(val1, val2);

         Assert.Equal(result, calculatorResult);
    }

    [Fact]
    public void TestDivisionByZero()
    {
        Calculator calc = ConstructClass();

        Assert.Throws<DivideByZeroException>(
            () => calc.Divide( 3, 0 )
        );
    }

    [Fact]
    public void TestHistoric()
    {
        Calculator calc = ConstructClass();

        calc.Add( 1, 4 );
        calc.Add( 3, 1 );
        calc.Add( 6, 6 );
        calc.Add( 4, 9 );

        var lista = calc.Historic();

        Assert.NotEmpty(calc.Historic());
        Assert.Equal(3, lista.Count);
    }
}