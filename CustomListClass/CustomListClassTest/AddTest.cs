using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_ToList_ListNotEmpty()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange

            //Act
            myList.Add(45);

            //Assert
            Assert.IsNotNull(myList);
        }

        [TestMethod]
        public void Add_IntToList_FirstIndex()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int result = 45;

            //Act
            myList.Add(45);

            //Assert
            Assert.AreEqual(result, myList[0]);
        }

        [TestMethod]
        public void Add_MultipleToList_IndexThree()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int result = 6;

            //Act
            myList.Add(9);
            myList.Add(8);
            myList.Add(7);
            myList.Add(6);
            myList.Add(5);

            //Assert
            Assert.AreEqual(result, myList[3]);
        }

        [TestMethod]
        public void Add_UsingLoop_IndexNine()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange
            int num = 10;
            int result = 9;

            //Act
            for (int i = 0; i < num; i++)
            {
                myList.Add(i);
            }

            //Assert
            Assert.AreEqual(result, myList[9]);
        }


        [TestMethod]
        public void Add_String_IndexOne()
        {
            MyList<string> myList = new MyList<string>();

            //Arrange
            string result = "MommyFinger";

            //Act
            myList.Add("DaddyFinger");
            myList.Add(result);
            myList.Add("BabyFinger");

            //Assert
            Assert.AreEqual(result, myList[1]);
        }

        [TestMethod]
        public void Add_Object_IndexOne()
        {
            MyList<Player> playerList = new MyList<Player>();

            //Arrange
            Player playerListOne = new Player("James");
            Player playerListTwo = new Player("Lebron");

            //Act
            playerList.Add(playerListOne);
            playerList.Add(playerListTwo);


            //Assert
            Assert.AreEqual(playerListTwo, playerList[1]);
        }

        [TestMethod]
        public void Remove_ReturnFalse_UnableToRemove()
        {
            MyList<int> myList = new MyList<int>();

            //Arrange

            //Act
            myList.Remove[0];

            //Assert
            Assert.IsTrue(false);
        }
    }
}
