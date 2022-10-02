using System
Imports Xunit

Namespace CalcTests
    Public Class UnitTest1
    
        [Fact]
        public void AdditionTestGood()
        {
            //ARRANGE
            double inputNumberOne = 99;
            double inputNumberTwo = 0;

            //ACT
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(99, result);
        }
        

