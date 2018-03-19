using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modul2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //int result = Program.DoYouNeedToSleep(22, 6);
            //Assert.AreEqual(8, result); //8 är önskat resultat


        }
        [TestMethod]
        public void TestMethod2()
        {
            //int result = Modul2.Program.MinAddition(-10, 7);
            //Assert.AreEqual(-3, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var result= Modul2.Program.ForeachEnterNames("a,b,Zelda");
            Assert.AreEqual(true,result);


        }
        [TestMethod]
        public void TestMethod4()
        {
            var result = Modul2.Program.EnterNumber2(20,30);
            Assert.AreEqual("Lower than", result);
            result = Modul2.Program.EnterNumber2(30, 30);
            Assert.AreEqual("Equal", result);
           

            
        }
        [TestMethod]
        public void TestMethod5()
        {
            var result = Modul2.Program.EnterNumber2(30, 30);
            Assert.AreEqual("Lower than", result);
            
            
        }

        [TestMethod]
        public void TestMethod6()
        {
            
            var result = Modul2.Program.EnterNumber2(50, 30);
            Assert.AreEqual("Higher than", result);


        }
        [TestMethod]
        public void TestMethod7()
        {
            
            var result = Modul2.Program.EnterNumber2(30, 30);
            Assert.AreEqual("Equal", result);
            

        }

    }
}
