using Exception_PracticeProblems;

namespace PersonAgesUnitTesting
{

    [TestClass]
    public class UnitTest1
    {
        PersonAge age = new PersonAge();
        [TestMethod]
        public void TestMethod_ToCheck_Children_Age()
        {
            string child = age.AgeCategory(10);
            Assert.AreEqual(child, "Children");
        }
        [TestMethod]
        public void TestMethod_ToCheck_Youth_Age()
        {
            string youth = age.AgeCategory(22);
            Assert.AreEqual(youth, "Youth");
        }
        [TestMethod]
        public void TestMethod_ToCheck_Adults_Age()
        {
            string adult = age.AgeCategory(29);
            Assert.AreEqual(adult, "Adult");
        }
        [TestMethod]
        public void TestMethod_ToCheck_Seniors_Age()
        {
            string senior = age.AgeCategory(80);
            Assert.AreEqual(senior, "Seniors");
        }
        [TestMethod]
        public void TestMethod_ToCheck_InValidAge_ShouldReturn_NullAge()
        {
            try
            {
                int agelimit = default;
                string result = age.AgeCategory(agelimit);
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "Age is Null");
            }
        }
    }
}