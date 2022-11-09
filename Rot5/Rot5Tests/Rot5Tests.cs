namespace Rot5Tests
{
    [TestClass]
    public class Rot5Tests
    {
        [TestMethod]
        public void Rot5Test_SimpleTest_ShouldPass()
        {
            string original = "56";

            Assert.AreEqual("01", Rot5.Encrypt(original));
        }

        [TestMethod]
        public void Rot5Test_RunningTwiceShouldGoBackToOrigial_ShouldPass()
        {
            string original = "ROT56/_ROT56";

            Assert.AreEqual(original, Rot5.Encrypt(Rot5.Encrypt(original)), "Running Rot5 twice should return the origial string");
        }

        [TestMethod]
        public void Rot5Test_NoDigits_ShouldBeUnchanged_ShouldPass()
        {
            string original = "AMSTERDAM";

            Assert.AreEqual(original, Rot5.Encrypt(original), "Just text should be ungchanged");
        }

        [DataTestMethod]
        [DataRow("9*6=42", "4*1=97")]
        [DataRow("0123456789", "5678901234")]
        public void Rot5Test_Mathematics_ShouldPass(string original, string result)
        {
            Assert.AreEqual(result, Rot5.Encrypt(original), "This should work");
        }
    }
}