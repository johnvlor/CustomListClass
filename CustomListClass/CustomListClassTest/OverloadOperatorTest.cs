using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class OverloadOperatorTest
    {
        [TestMethod]
        public void AddInt_OverloadPlusOperator_CombinesBothList()
        {
            //Arrange
            MyList<int> myListOne = new MyList<int>() { 0, 1, 2, 3, 4, 5 };
            MyList<int> myListTwo = new MyList<int>() { 6, 7, 8, 9, 10 };
            int result = 8;

            //Act
            MyList<int> resultList = myListOne + myListTwo;

            //Assert     
            Assert.AreEqual(result, resultList[8]);
        }

        [TestMethod]
        public void AddString_OverloadPlusOperator_CombinesBothList()
        {
            //Arrange
            MyList<string> myListOne = new MyList<string>() { "a", "b", "c" };
            MyList<string> myListTwo = new MyList<string>() { "A", "B", "C" };
            string result = "B";

            //Act
            MyList<string> resultList = myListOne + myListTwo;

            //Assert     
            Assert.AreEqual(result, resultList[4]);
        }

        [TestMethod]
        public void AddObject_OverloadPlusOperator_CombinesBothList()
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
            playerList = playerOneList + playerTwoList;

            //Assert     
            Assert.AreEqual(playerTwoList, playerList[2]);
        }

        public void SubtractInt_OverloadMinusOperator_SubtractOneListFromAnother()
        {
            //Arrange
            MyList<int> myListOne = new MyList<int>() { 0, 1, 2, 3, 4, 5 };
            MyList<int> myListTwo = new MyList<int>() { 0, 1, 2 };
            int result = 4;

            //Act
            MyList<int> resultList = myListOne - myListTwo;

            //Assert     
            Assert.AreEqual(result, resultList[1]);
        }

        [TestMethod]
        public void SubtractString_OverloadMinusOperator_SubtractOneListFromAnother()
        {
            //Arrange
            MyList<string> myListOne = new MyList<string>() { "a", "b", "c", "d", "e", "f" };
            MyList<string> myListTwo = new MyList<string>() { "b", "d", "f" };
            string result = "e";

            //Act
            MyList<string> resultList = myListOne - myListTwo;

            //Assert     
            Assert.AreEqual(result, resultList[2]);
        }

        [TestMethod]
        public void SubractObject_OverloadMinusOperator_SubtractOneListFromAnothert()
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
            playerList = playerOneList - playerTwoList;

            //Assert     
            Assert.AreEqual(playerTwoList, playerList[2]);
        }
    }
}
