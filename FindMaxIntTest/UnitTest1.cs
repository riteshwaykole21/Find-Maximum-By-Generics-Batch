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
            int result = genericsMethodForInt.FindMaxValue(20, 10, 17);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldreturnSecondMax()
        {
            int result = genericsMethodForInt.FindMaxValue(10, 20, 17);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldreturnThirdMax()
        {
            int result = genericsMethodForInt.FindMaxValue(10, 17, 20);
            Assert.AreEqual(20, result);
        }

    }
}
