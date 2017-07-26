using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class CountTest
    {
        [TestMethod]
        public void Count_MultipleIndexes_ReturnCount()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int result = 4;

            //Act
            myList.Add(9);
            myList.Add(8);
            myList.Add(7);
            myList.Add(6);

            //Assert
            Assert.AreEqual(result, myList.Count);
        }

        [TestMethod]
        public void Count_UsingInitalizer_ReturnCount()
        {
            MyList<int> myList = new MyList<int>() { 0, 1, 2, 3, 4, 5 }; ;

            //Arrange
            int result = 6;

            //Act

            //Assert
            Assert.AreEqual(result, myList.Count);
        }

        [TestMethod]
        public void Count_String_ReturnCount()
        {
            MyList<string> myList = new MyList<string>();

            //Arrange
            int result = 5;

            //Act
            myList.Add("DaddyFinger");
            myList.Add("MommyFinger");
            myList.Add("BrotherFinger");
            myList.Add("SisterFinger");
            myList.Add("BabyFinger");

            //Assert
            Assert.AreEqual(result, myList.Count);
        }

        [TestMethod]
        public void Count_Object_ReturnCount()
        {
            MyList<Player> playerList = new MyList<Player>();
            
            //Arrange
            Player playerListOne = new Player("James");
            Player playerListTwo = new Player("Lebron");
            Player playerListThree = new Player("NBA");
            int result = 3;

            //Act
            playerList.Add(playerListOne);
            playerList.Add(playerListTwo);
            playerList.Add(playerListThree);

            //Assert
            Assert.AreEqual(result, playerList.Count);
        }

    }
}
