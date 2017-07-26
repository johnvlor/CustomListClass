using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void AddInt_IterateList_AssignsEachIndex()
        {
            //Arrange
            MyList<int> myList = new MyList<int>() { 0, 1, 2, 3, 4, 5 };
            int result = 5;

            //Act
            foreach (int number in myList)
            {
                result = number;
            }

            //Assert     
            Assert.AreEqual(result, myList[5]);
        }
    }
}
