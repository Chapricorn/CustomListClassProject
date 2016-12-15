using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{

    [TestClass]
    public class GenericMemberTest
    {

        /// <summary>
        /// This Test Case is used for testing the AddElement() method
        /// </summary>
        [TestMethod]
        public void Test_AddElement()
        {
            // Arrange
            int expected = 3;

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddElement("string 1");
            list1.AddElement("string 2");
            list1.AddElement("string 3");
            int actual = list1.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///  This Test Case is used for testing the AddElement() method
        /// </summary>
        [TestMethod]
        public void Test_RemoveItem()
        {
            // Arrange
            int expected = 2;

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddElement("string 1");
            list1.AddElement("string 2");
            list1.AddElement("string 3");
            list1.RemoveItem("string 2");
            int actual = list1.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///  This Test Case is used for testing the ToString() method
        /// </summary>
        [TestMethod]
        public void Test_ToString()
        {
            // Arrange
            string expected = "123";

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddElement("1");
            list1.AddElement("2");
            list1.AddElement("3");
            string actual = list1.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_CheckForEmptyArray()
        {
            // Arrange
            Boolean expected = true;

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddElement("1");
            list1.AddElement("2");
            list1.AddElement("3");
            Boolean actual = false;

            // if there are elements in the list, let actual equal to true
            if (list1.Count() > 0)
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

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
}
