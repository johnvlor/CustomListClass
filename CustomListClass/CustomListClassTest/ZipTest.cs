using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void Zip_TwoIntList_CombineBothList()
        {
            //Arrange
            MyList<int> myListOne = new MyList<int>() { 1, 3, 5, 7 };
            MyList<int> myListTwo = new MyList<int>() { 2, 4, 6 };
            int result = 5;

            //Act
            MyList<int> newResultList = myListOne.Zip(myListTwo);

            //Assert     
            Assert.AreEqual(result, newResultList[4]);
        }

        [TestMethod]
        public void Zip_TwoIntList_ExtraIndexes()
        {
            //Arrange
            MyList<int> myListOne = new MyList<int>() { 1, 3, 5, 7, 9, 11 };
            MyList<int> myListTwo = new MyList<int>() { 2, 4, 6 };
            int result = 9;

            //Act
            MyList<int> newResultList = myListOne.Zip(myListTwo);

            //Assert     
            Assert.AreEqual(result, newResultList[7]);
        }

        [TestMethod]
        public void Zip_TwoIntList_ReturnCount()
        {
            //Arrange
            MyList<int> myListOne = new MyList<int>() { 1, 3, 5, 7 };
            MyList<int> myListTwo = new MyList<int>() { 2, 4, 6 };
            int result = 7;

            //Act
            MyList<int> newResultList = myListOne.Zip(myListTwo);

            //Assert     
            Assert.AreEqual(result, newResultList.Count);
        }

        [TestMethod]
        public void Zip_TwoStringList_CombineBothList()
        {
            //Arrange
            MyList<string> myListOne = new MyList<string>() { "a", "b", "c" };
            MyList<string> myListTwo = new MyList<string>() { "A", "B", "C" };
            string result = "B";

            //Act
            MyList<string> newResultList = myListOne.Zip(myListTwo);

            //Assert     
            Assert.AreEqual(result, newResultList[3]);
        }

        [TestMethod]
        public void Zip_TwoStringList_ReturnCount()
        {
            //Arrange
            MyList<string> myListOne = new MyList<string>() { "a", "b", "c" };
            MyList<string> myListTwo = new MyList<string>() { "A", "B", "C" };
            int result = 6;

            //Act
            MyList<string> newResultList = myListOne.Zip(myListTwo);

            //Assert     
            Assert.AreEqual(result, newResultList.Count);
        }

        [TestMethod]
        public void Zip_ExtraStringIndexes_ReturnCount()
        {
            //Arrange
            MyList<string> myListOne = new MyList<string>() { "a", "b", "c" };
            MyList<string> myListTwo = new MyList<string>() { "A", "B", "C", "X", "Y", "Z" };
            int result = 9;

            //Act
            MyList<string> newResultList = myListOne.Zip(myListTwo);

            //Assert     
            Assert.AreEqual(result, newResultList.Count);
        }

        [TestMethod]
        public void Zip_SwapListPosition_AddsOneIntoTwo()
        {
            //Arrange
            MyList<string> myListOne = new MyList<string>() { "a", "b", "c" };
            MyList<string> myListTwo = new MyList<string>() { "A", "B", "C", "X", "Y", "Z" };
            string result = "B";

            //Act
            MyList<string> newResultList = myListTwo.Zip(myListOne);

            //Assert     
            Assert.AreEqual(result, newResultList[2]);
        }

        [TestMethod]
        public void Zip_TwoObjectList_CombineBothList()
        {
            MyList<Player> playerList = new MyList<Player>();

            //Arrange
            Player playerOne = new Player("James");
            Player playerTwo = new Player("Lebron");

            MyList<Player> playerOneList = new MyList<Player>();
            MyList<Player> playerTwoList = new MyList<Player>();

            playerOneList.Add(playerOne);
            playerTwoList.Add(playerTwo);

            //Act
            playerList = playerOneList.Zip(playerTwoList);

            //Assert     
            Assert.AreEqual(playerTwo, playerList[1]);
        }
    }
}
