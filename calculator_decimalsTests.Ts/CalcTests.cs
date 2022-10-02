using Xunit;
using System;
using calculator_decimals;

namespace calculator_decimalsTests.Ts
{
    public class CalcTests
    {
        [Fact]
        public void AdditionTestGood()
            {
                //ARRANGE
                double inputNumberOne = 99;
                double inputNumberTwo = 0;

                //ACT
                double result = calc.Addition(inputNumberOne, inputNumberTwo);

                //ASSERT
                Assert.Equal(99, result);
            }

        [Fact]
        public void AdditionTestGoodDecimal()
        {
            //ARRANGE
            double inputNumberOne = 1.3;
            double inputNumberTwo = 3.4;

            //ACT
            double result = calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(4.7, result);
        }

        [Fact]
        public void AdditionTestGoodNegativNumbers()
        {
            //ARRANGE
            double inputNumberOne = -5.1;
            double inputNumberTwo = -3.4;

            //ACT
            double result = calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(-8.5, result);
        }
        [Theory]
        [InlineData(new double[4] { 1.1, -2.2, 5, 9 })]
        [InlineData(new double[5] { 1.1, -3.3, 5, 7, 8.8 })]
        public void AdditionArr(double[] arr)
        {
            //ARRANGE
            double result;
            double resultTest = 0;

            //ACT
            for (int i = 0; i < arr.Length; i++)
            {
                resultTest += arr[i];
            }
            result = calc.Addition(arr);

            //ASSERT
            Assert.Equal(resultTest, result);
        }
        [Fact]
        public void SubtractionTestOne()
        {
            //ARRANGE
            double inputNumberOne = 99;
            double inputNumberTwo = 45.5;

            //ACT
            double result = calc.subtraction(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(53.5, result);
        }
        [Theory]
        [InlineData(new double[4] { 1.1, -2.2, 5, 9 })]
        [InlineData(new double[5] { 1.1, -3.3, 5, 7, 8.8 })]

        public void SubtractionTestArr(double[] arr)
        {
            //ARRANGE
            double result;
            double resultTest = arr[0];

            //ACT
            for (int i = 1; i < arr.Length; i++)
            {
                resultTest -= arr[i];
            }
            result = calc.subtraction(arr);

            //ASSERT
            Assert.Equal(resultTest, result);
        }
    }
}