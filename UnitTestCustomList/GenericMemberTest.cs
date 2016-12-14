using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{

    /// <summary>
    /// (20 points (2 points each)): As a developer, I want to create 10 unit tests for my project, 
    /// so that I can ensure the functionality is working properly.
    /// </summary>
    [TestClass]
    public class GenericMemberTest
    {
        [TestMethod]
        public void Test_AddItem()
        {
            //arrange

            int expectedCount= 5;

            object[] myArray = new object[5];
            myArray[0] = " Chue ";
            myArray[1] = " Evee ";
            myArray[2] = " Jessienee ";
            myArray[3] = " Chloe ";         
            myArray[4] = " Yosmine ";

            // Act
            GenericMember customList = new GenericMember();
            customList.AddItem(myArray);
            int actualCount = customList.membersArray.Length;

            // assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }



}
