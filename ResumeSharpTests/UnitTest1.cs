using JsonResumeSharp;
using JsonResumeSharp.Utils.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ResumeSharpTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           JsonResume jsonResume = new JsonResume();
            jsonResume.AddAward(new Award())
                 .AddWork(new Work())
                 .AddEducation(new Education())
                 .AddPublication(new Publication());

            JsonResume jsonResume = JsonResume.FromJson(jsonString);

            Assert.AreEqual(jsonResume.Works.Count, 1);
        }

       
    }
}
