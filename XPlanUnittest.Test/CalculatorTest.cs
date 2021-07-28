using Moq;
using XPlanUnittest.App;
using Xunit;

namespace XPlanUnittest.Test
{
    public class CalculatorTest
    {
        private Calculator calculator;
        private Mock<ICalculatorService> myMock;
        public CalculatorTest()
        {
            myMock = new Mock<ICalculatorService>();
            this.calculator = new Calculator(myMock.Object);
        }

        [Fact]
        public void AddTest()
        {
            ////Arrange
            //int a = 7;
            //int b = 8;
            //var calculator = new Calculator();

            ////Act
            //var total = calculator.Add(a, b);

            ////Assert
            ////Assert.Equal<int>(15, total);
            //Assert.DoesNotContain("Serhat", "Serhat ÜR");

            //Assert.Matches("^dog", "dog dog");

            //Assert.Empty(new List<string>() { "Serhat" });

            //Assert.InRange(10, 1, 9);

            //Assert.Single(new List<string>() { "one","two" });

            //Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());

            //Assert.NotNull(null);

            //Assert.Equal("Serhat", "Serhat");
            //Assert.NotEqual("Serhat", "Serhat");

            Assert.Equal<int>(13, 13);
        }


        [Theory]
        [InlineData(4,8,12)]
        [InlineData(1, 11, 12)]
        public void Add_Values_ReturnSumValue(int a,int b,int expectedNumber)
        {
            myMock.Setup(x => x.Add(a, b)).Returns(expectedNumber);

            var resultNumber = calculator.Add(a, b);

            Assert.Equal(expectedNumber, resultNumber);
        }

        [Theory]
        [InlineData(4, 8, 32)]
        [InlineData(1, 11, 11)]
        public void Multiplication_Values_ReturnSumValue(int a, int b, int expectedNumber)
        {
            myMock.Setup(x => x.Multiplication(a, b)).Returns(expectedNumber);

            var resultNumber = calculator.Multiplication(a, b);

            Assert.Equal(expectedNumber, resultNumber);
        }
    }
}
