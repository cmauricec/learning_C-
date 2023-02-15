using Xunit;
using MyMaxLib;
//Christopher Maurice
//Lab 3 
//Task 6 
namespace MyMaxLibTest;

public class UnitTest1
{
    [Fact]
    public void TestMaxNumber()
    {

        double a = 4; // arrange
        double b = 10; 
        double c = 5; 
        double number = 2; 
        double expected = 10;

        double actual = Max.Mymax(a, b, c, number); // act
        

        Assert.Equal(expected, actual); // assert
    }

    [Fact]
    public void TestMaxNumber2()
    {

        double a = 4; // arrange
        double b = 10; 
        double c = 15; 
        double number = 3; 
        double expected = 15;

        double actual = Max.Mymax(a, b, c, number); // act
        

        Assert.Equal(expected, actual); // assert
    }
}