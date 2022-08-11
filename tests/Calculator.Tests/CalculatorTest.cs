using CalculatorProgram;

namespace CalculatorTests
{
    public class CalculatorTest
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void ShouldDoAddition()
        {
            Assert.Equal(4, Calculator.DoOperation(2, 2, "a"));
        }

        [Fact]
        public void ShouldDoBigitAddition()
        {
            Assert.Equal(60848641735671, Calculator.DoOperation(85161, 60848641650510, "a"));
        }

        [Fact]
        public void ShouldDoSubstraction()
        {
            Assert.Equal(-5, Calculator.DoOperation(10, 15, "s"));
        }

        [Fact]
        public void ShouldDoMultiplication()
        {
            Assert.Equal(70, Calculator.DoOperation(10, 7, "m"));
        }

        [Fact]
        public void ShouldDoDivision1()
        {
            Assert.Equal(3, Calculator.DoOperation(15, 5, "d"));
        }

        [Fact]
        public void ShouldDoDivision2()
        {
            Assert.Equal(6, Calculator.DoOperation(12, 2, "d"));
        }

        [Fact]
        public void ShouldDoDivision3()
        {
            Assert.Equal(18/3, Calculator.DoOperation(18, 3, "d"));
        }

        [Fact]
        public void ShouldNotDoDivision()
        {
            Assert.Equal(Double.NaN, Calculator.DoOperation(6, 0, "d"));
        }

        [Fact]
        public void ShouldNotDoOperation1()
        {
            Assert.Equal(Double.NaN, Calculator.DoOperation(10, 4, ""));
        }

        [Fact]
        public void ShouldNotDoOperation2()
        {
            Assert.Equal(Double.NaN, Calculator.DoOperation(9, 8, "as"));
        }
    }
}