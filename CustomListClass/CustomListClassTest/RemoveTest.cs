using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_ReturnFalse_UnableToRemove()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange

            //Act
            myList.Remove(0);

            //Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Remove_FirstIndex_IndexZero()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int result = 8;

            //Act
            myList.Add(9);
            myList.Add(8);
            myList.Add(7);
            myList.Add(6);
            myList.Remove(9);

            //Assert
            Assert.AreEqual(result, myList[0]);
        }

        [TestMethod]
        public void Remove_ValueSeven_NewIndexTwo()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int result = 6;
            //Act
            myList.Add(9);
            myList.Add(8);
            myList.Add(7);
            myList.Add(6);
            myList.Remove(7);

            //Assert
            Assert.AreEqual(result, myList[2]);
        }

        [TestMethod]
        public void Remove_MultipleIndexes_OneIndexLeft()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int result = 8;

            //Act
            myList.Add(9);
            myList.Add(8);
            myList.Add(7);
            myList.Add(6);
            myList.Remove(9);
            myList.Remove(7);

            //Assert
            Assert.AreEqual(result, myList[0]);
        }

        [TestMethod]
        public void Remove_EmptyString_ReturnNullIndex()
        {
            MyList<string> myList = new MyList<string>();

            //Arrange
            string result = null;

            //Act
            myList.Remove(null);

            //Assert
            Assert.AreEqual(result, myList[0]);
        }

        [TestMethod]
        public void Remove_StringIndex_NewLastIndex()
        {
            MyList<string> myList = new MyList<string>();

            //Arrange
            string result = "BrotherFinger";

            //Act
            myList.Add("DaddyFinger");
            myList.Add("MommyFinger");
            myList.Add(result);
            myList.Add("SisterFinger");
            myList.Remove("SisterFinger");

            //Assert
            Assert.AreEqual(result, myList[2]);
        }

        [TestMethod]
        public void Remove_Object_NewIndexZero()
        {
            MyList<Player> playerList = new MyList<Player>();

            //Arrange
            Player playerListOne = new Player("James");
            Player playerListTwo = new Player("Lebron");

            //Act
            playerList.Add(playerListOne);
            playerList.Add(playerListTwo);
            playerList.Remove(playerListOne);

            //Assert
            Assert.AreEqual(playerListTwo, playerList[0]);
        }
    }
}
