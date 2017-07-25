using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_ConvertIntIntoOneString()
        {
            //Arrange
            MyList<int> myList = new MyList<int>(new int[] { 0, 1, 2, 3, 4, 5 });
            string result;
            string resultList = "012345";

            //Act
            result = myList.ToString();

            //Assert     
            Assert.AreEqual(resultList, result);
        }

        [TestMethod]
        public void ToString_ConvertStringIntoOneString()
        {
            //Arrange
            MyList<string> myList = new MyList<string>(new string[] { "a", "b", "c" });
            string result;
            string resultList = "abc";

            //Act
            result = myList.ToString();

            //Assert     
            Assert.AreEqual(resultList, result);
        }
    }
}
