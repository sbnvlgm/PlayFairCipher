using Coursework_iss;

namespace TestPlayfairCipher
{
   
    public class Tests
    {
        Playfair plt;
        [SetUp]
        public void Setup()
        {
            String key = "ADF";
            plt = new Playfair(key);
        }

        [Test]
        public void Test1()
        {
            string expected = "CLLMHV";
            string actual = plt.Encode("APPLEX");
            Assert.AreEqual(expected, actual); //сравнение значений - то, что должно получится и то, что считает программа.
        }
        public void TestEng()
        {
            string expected = "CATX";
            string actual = plt.Encode("EDFY");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestBb()
        {
            string expected = Convert.ToString("LMBVBDGT");
            string actual = plt.Encode(Convert.ToString("PLAYFAIR"));
            Assert.AreEqual(expected, actual);
        }

    }
}