using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            //GenericMember<int> customList = new GenericMember<int>();


            GenericMember customList = new GenericMember();

         object[] myArray = new object[5];
            myArray[0] = " Chue ";
            myArray[1] = " Evee ";
            myArray[2] = " Jessienee ";
            myArray[3] = " Chloe ";
            myArray[4] = " Yosmine ";

            //myArray[4] = " Chue ";



            //customList.membersArray = myArray;
            customList.AddItem(myArray);

            //(10 points): As a developer, I want the custom list class to be iterable.
            for (int i = 0; i < customList.membersArray.Length; i++)
            {
                Console.WriteLine(customList.membersArray[i]);
            }
            Console.ReadLine();

            // Add Age to the list
            customList.age = 10;

            // Create a list of members.
            List<Member> members = new List<Member>();
            Member myMember = new Member();
            myMember.name = "Joe";
            myMember.age = 30;
            members.Add(myMember);
 


            //members.Add(" Chue "        , MemberAge = 33 );
            //members.Add(" Evee "        , MemberAge = 15 );
            //members.Add(" Jessienee "   , MemberAge = 12 );
            //members.Add(" Chloe "       , MemberAge = 10 );
            //members.Add(" Yosmine "     , MemberAge = 9  );



            //Console.WriteLine(" All the Members in this Family ");
            //Console.WriteLine(" \n ");
            //foreach (GenericMember aMember in members)
            //{
            //    Console.WriteLine(aMember);
            //}

            //Console.WriteLine("\n Member Number [3] is: {0}", members[3]);
            //Console.WriteLine("\n First Member Age (33): {0}",
            //members.Contains(new GenericMember { MemberName = " Chue ", MemberAge = 33 }));

            //// Insert a new item at position 2.
            //Console.WriteLine("\n Add Member Number: (2) to List. ");
            //members.Insert(2, new GenericMember() { MemberName = " Evee ", MemberAge = 15 });



            //foreach (GenericMember aMember in members)
            //{
            //    Console.WriteLine(aMember);
            //}



            //Console.WriteLine("\n Remove Member with Age: (9)");


            //members.Remove(new GenericMember() { MemberAge = 9, MemberName = " Yosmine " });

            //Console.WriteLine();
            //foreach (GenericMember aMember in members)
            //{
            //    Console.WriteLine(aMember);
            //}
            //Console.WriteLine("\n Remove Member Number: (3)");

            //members.RemoveAt(3);

            //Console.WriteLine();
            //foreach (GenericMember aMember in members)
            //{
            //    Console.WriteLine(aMember);
            //}
            //Console.ReadKey();

            //int age = 33;

            //GenericMember<int> ageOfMember = new GenericMember<int>(age);
            //Console.WriteLine(" Testing GenericMember Class with Int");
            //ageOfMember.Print();
            //Console.ReadKey();


            //GenericMember<string> nameOfMember = new GenericMember<string>(" Chue ");
            //Console.WriteLine(" Testing GenericMember Class with String");
            //nameOfMember.Print();
            //ageOfMember.Print();
            //Console.ReadKey();

        }
    }
}
