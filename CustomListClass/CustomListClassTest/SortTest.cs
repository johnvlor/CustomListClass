using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void AscendingSort_IntList_GetIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { 4, 2, 12, 7, 1, 8, 0 };
            int result = 7;
            
            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[4]);
        }

        [TestMethod]
        public void AscendingSort_IntList_GetLastIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { 4, 2, 12, 7, 1, 8, 0 };
            int result = 12;

            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[6]);
        }

        [TestMethod]
        public void AscendingSort_StringList_GetIndex()
        {
            //Arrange
            MyList<string> mySortList = new MyList<string>() { "X", "Y", "Z", "b", "A", "B", "C", "a" };
            string result = "C";

            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[4]);
        }

        [TestMethod]
        public void AscendingSort_IntList_GetOneIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { 4 };
            int result = 4;

            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[0]);
        }

        [TestMethod]
        public void AscendingSort_EmptyIntList_GetIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { };
            int result = 0;

            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[0]);
        }

        [TestMethod]
        public void AscendingSort_StringList_GetLastIndex()
        {
            //Arrange
            MyList<string> mySortList = new MyList<string>() { "X", "Y", "Z", "b", "A", "B", "C", "a" };
            string result = "Z";

            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[7]);
        }

        [TestMethod]
        public void AscendingSort_EmptyStringList_GetIndex()
        {
            //Arrange
            MyList<string> mySortList = new MyList<string>() { };
            string result = null;

            //Act
            mySortList.AscendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[0]);
        }

        [TestMethod]
        public void DescendingSort_IntList_GetIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { 4, 2, 12, 7, 1, 8, 0 };
            int result = 2;

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[4]);
        }

        [TestMethod]
        public void DescendingSort_IntList_GetLastIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { 4, 2, 12, 7, 1, 8, 0 };
            int result = 0;

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[6]);
        }

        [TestMethod]
        public void DescendingSort_StringList_GetIndex()
        {
            //Arrange
            MyList<string> mySortList = new MyList<string>() { "X", "Y", "Z", "b", "A", "B", "C", "a" };
            string result = "B";

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[4]);
        }

        [TestMethod]
        public void DescendingSort_IntList_GetOneIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { 4 };
            int result = 4;

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[0]);
        }

        [TestMethod]
        public void DescendingSort_EmptyIntList_GetIndex()
        {
            //Arrange
            MyList<int> mySortList = new MyList<int>() { };
            int result = 0;

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[0]);
        }

        [TestMethod]
        public void DescendingSort_StringList_GetLastIndex()
        {
            //Arrange
            MyList<string> mySortList = new MyList<string>() { "X", "Y", "Z", "b", "A", "B", "C", "a" };
            string result = "a";

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[7]);
        }

        [TestMethod]
        public void DescendingSort_EmptyStringList_GetIndex()
        {
            //Arrange
            MyList<string> mySortList = new MyList<string>() { };
            string result = null;

            //Act
            mySortList.DescendingSort();

            //Assert
            Assert.AreEqual(result, mySortList[0]);
        }
    }
}
