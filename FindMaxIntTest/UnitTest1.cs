using FindMaximum;
namespace FindMaxIntTest
{
    public class Tests
    {
        FindMaxGenrics<int> genericsMethodForInt = new FindMaxGenrics<int>();
        FindMaxGenrics<double> genericsMethodForFloat = new FindMaxGenrics<double>();
        FindMaxGenrics<string> genricsMethodForString = new FindMaxGenrics<string>();


        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldreturnFirstMax()
        {
           string result = genricsMethodForString.FindMaxValue("rit", "efg" , "hij");
            Assert.AreEqual("rit", result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldreturnSecondMax()
        {
            string result = genricsMethodForString.FindMaxValue("lop", "ryt", "lkj");
            Assert.AreEqual("ryt", result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldreturnThirdMax()
        {
            string result = genricsMethodForString.FindMaxValue("lop","aer", "ryt");
            Assert.AreEqual("ryt", result);
        }

    }
}
