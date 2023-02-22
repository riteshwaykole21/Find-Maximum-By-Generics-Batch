using FindMaximum;
namespace FindMaxIntTest
{
    public class Tests
    {
        FindMaxGenrics<int> genericsMethodForInt = new FindMaxGenrics<int>();
        FindMaxGenrics<double> genericsMethodForFloat = new FindMaxGenrics<double>();
        FindMaxGenrics<string> genricsMethodFoeSrring = new FindMaxGenrics<string>();


        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldreturnFirstMax()
        {
            double result = genericsMethodForFloat.FindMaxValue(20.40f, 10.50f, 17.67f);
            Assert.AreEqual(20.40f, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldreturnSecondMax()
        {
            double result = genericsMethodForFloat.FindMaxValue(10.45f, 20.78f, 17.65f);
            Assert.AreEqual(20.78f, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldreturnThirdMax()
        {
            double result = genericsMethodForFloat.FindMaxValue(10.65f, 17.34f, 20.25);
            Assert.AreEqual(20.25f, result);
        }

    }
}
