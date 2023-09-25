using net_calculator_tester;

namespace net_calculator_testerTests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddTestWithRandom(
            [Random(-1000f, 1000f, 10)] float num1,
            [Random(-1000f, 1000f, 10)] float num2
            )
        {
            float realSum = Calculator.Add(num1,num2);
            float expectedSum = num1 + num2;

            Assert.IsTrue(realSum == expectedSum, $"Expected {expectedSum}, got {realSum}");
        }

        [Test]
        public void SubtractTestWithRandom(
            [Random(-1000f, 1000f, 10)] float num1,
            [Random(-1000f, 1000f, 10)] float num2
            )
        {
            float realDifference = Calculator.Subtract(num1, num2);
            float expectedDifference = num1 - num2;

            Assert.IsTrue(realDifference == expectedDifference, $"Expected {expectedDifference}, got {realDifference}");
        }

        [Test]
        public void MultiplyTestWithRandom(
            [Random(-1000f, 1000f, 10)] float num1,
            [Random(-1000f, 1000f, 10)] float num2
            )
        {
            float realProduct = Calculator.Multiply(num1, num2);
            float expectedProduct = num1 * num2;

            Assert.IsTrue(realProduct == expectedProduct, $"Expected {expectedProduct}, got {realProduct}");
        }

        [Test]
        public void DivideTestWithRandom(
            [Random(-1000f, 1000f, 10)] float num1,
            [Random(-1000f, 1000f, 10)] float num2
            )
        {
            float realQuotient = Calculator.Divide(num1, num2);
            float expectedQuotient = num1 / num2;

            Assert.IsTrue(realQuotient == expectedQuotient, $"Expected {expectedQuotient}, got {realQuotient}");
        }

        [Test]
        public void DivideTestWithZeroDivisor([Random(-100f, 100f, 10)] float num1)
        {
            float num2 = 0f;

            Assert.Throws<System.ArgumentException>(() => { float quotient = Calculator.Divide(num1, num2); },$"Expected division by 0 exception, got a result instead");
        }
    }
}