using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tools.Common;

namespace ToolKit.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "ArcticWolf";
            var expected = "Arctic Wolf";

            //Act
            var actual = source.addSpaces();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
