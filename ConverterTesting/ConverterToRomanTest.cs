using ConverterNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterNumber
{
    [TestClass]
    public class ConverterToRomanTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // datos

            int arabic = 9;
            string roman = "V";

            var result =ConverterArabicToRoman.ConverterToRoman(arabic);

            Assert.AreEqual(roman, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // datos

            int arabic = 9;
            string roman = "IX";

            var result = ConverterArabicToRoman.ConverterToRoman(arabic);

            Assert.AreEqual(roman, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // datos

            int arabic = 569;
            string roman = "DLXIX";

            var result = ConverterArabicToRoman.ConverterToRoman(arabic);

            Assert.AreEqual(roman, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // datos

            int arabic = 569;
            string roman = "DLIX";

            var result = ConverterArabicToRoman.ConverterToRoman(arabic);

            Assert.AreEqual(roman, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // datos

            int arabic = 69;
            string roman = "LXIX";

            var result = ConverterArabicToRoman.ConverterToRoman(arabic);

            Assert.AreEqual(roman, result);
        }
    }
}
