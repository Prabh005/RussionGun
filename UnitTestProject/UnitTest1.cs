using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussionGun;
using System;

namespace UnitTestProject
{
  
    [TestClass]
    public class UnitTest1
    {
        GunClass Class = new GunClass();
        [TestMethod]
        public void LoadGun()
        {
            Class.Loadgun();
            Assert.IsTrue(Class.bullet == 1) ;
        }
        [TestMethod]
        public void Spin()
        {
            Class.Spin();
            Assert.IsTrue(Class.bullet < 6 && Class.bullet > 0);
        }
        
    }
}
