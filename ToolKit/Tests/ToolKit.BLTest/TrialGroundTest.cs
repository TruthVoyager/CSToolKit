using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolKit.BL;
//Example of a test script
//have to include the tested namespace in the refrences in the solution explorer and need to 
//use using 'ToolKit.BL'
namespace ToolKit.BLTest
{
    [TestClass]
    public class TrialGroundTest
    {
        [TestMethod]
        public void FullName()
        {
            //Arrange
            OverrideToStringOfBaseClass trial = new OverrideToStringOfBaseClass()
            {
                ObjName = "Truth",
                ObjLastName = "Voyager"
            };
            string expected = "Truth, Voyager";
            //Act
            string actual = trial.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameWithoutLastName()
        {
            //Arrange
            OverrideToStringOfBaseClass trial = new OverrideToStringOfBaseClass()
            {
                ObjName = "Truth"
            };
            string expected = "Truth";
            //Act
            string actual = trial.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
