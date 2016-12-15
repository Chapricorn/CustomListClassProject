using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{

    [TestClass]
    public class GenericMemberTest
    {

     
        [TestMethod]
        public void Test_AddElement()
        {
            // Arrange
            int expected = 5;

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddItem("Chue");
            list1.AddItem("Evee");
            list1.AddItem("Jessienee");
            list1.AddItem("Chloe");
            list1.AddItem("Yosmine");
            int actual = list1.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_RemoveItem()
        {
            // Arrange
            int expected = 4;

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddItem("Chue");
            list1.AddItem("Evee");
            list1.AddItem("Jessienee");
            list1.AddItem("Chloe");
            list1.AddItem("Yosmine");
            list1.RemoveItem("Evee");
            int actual = list1.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test_ToString()
        {
            // Arrange
            string expected = "12345";

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddItem("1");
            list1.AddItem("2");
            list1.AddItem("3");
            list1.AddItem("4");
            list1.AddItem("5");
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
            list1.AddItem("1");
            list1.AddItem("2");
            list1.AddItem("3");
            list1.AddItem("4");
            list1.AddItem("5");
            Boolean actual = false;

            if (list1.Count() > 0)
            {
                actual = true;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test_CheckCount()
        {
            // Arrange
            Boolean expected = false;

            // Act
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddItem("1");
            list1.AddItem("2");
            list1.AddItem("3");
            list1.AddItem("4");
            list1.AddItem("5");
            Boolean actual = true;

            if (list1.Count() > 0)
            {
                actual = false;
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

            [TestMethod]
            public void Test_AddMemberNames()
            {
                //arrange
                string expected = "Chue Jessienee";

                // Act
                Member member = new Member();
                member.name = "Chue Jessienee";
                string actual = member.name;

                // assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Test_AddNumberAndMemberName()
            {
                //arrange
                string expected = "1 Chue";

                // Act
                Member member = new Member();
                member.name = "1 Chue";
                string actual = member.name;

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test_SubtractMember()
            {
                // Arrange
                string expected = "1245";

                // Act
                GenericMember<string> list1 = new GenericMember<string>();
                list1.AddItem("1");
                list1.AddItem("2");
                list1.AddItem("4");
                list1.AddItem("5");
                string actual = list1.ToString();

                //Assert
                Assert.AreEqual(expected, actual);
            }

        }

    }
}
