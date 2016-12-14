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
    public class MemberTest
    {
        [TestMethod]
        public void Test_AddAge()
        {
            //arrange
            int expected = 10;

            // Act
            Member member = new Member();
            member.age = 10;
            int actual = member.age;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddName()
        {
            //arrange
            string expected = "john";

            // Act
            Member member = new Member();
            member.name = "john";
            string actual = member.name;

            // assert
            Assert.AreEqual(expected, actual);
        }



    }
}
