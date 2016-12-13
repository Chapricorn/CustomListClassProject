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
            // Create a list of members.
            List<GenericMember> members = new List<GenericMember>();
         

            // Add members to the list.
            members.Add(new GenericMember() { MemberName = " Chue "     ,      MemberAge = 33      , MemberHobby = " Sewing "  });
            members.Add(new GenericMember() { MemberName = " Evee "     ,      MemberAge = 15      , MemberHobby = " Tennis"   });
            members.Add(new GenericMember() { MemberName = " Jessienee ",      MemberAge = 12      , MemberHobby = " Craft "   });
            members.Add(new GenericMember() { MemberName = " Chloe "    ,      MemberAge = 10      , MemberHobby = " Puzzle "  });
            members.Add(new GenericMember() { MemberName = " Yosmine "  ,      MemberAge = 9       , MemberHobby = " Art "     });

            // Write out the members in the list. This will call the overridden ToString method
            // in the Member class.
            Console.WriteLine(" All the Members in this Family ");
            Console.WriteLine(" \n ");
            foreach (GenericMember aMember in members)
            {
                Console.WriteLine(aMember);
            }

            Console.WriteLine("\n Member Number [3] is: {0}", members[3]);
            Console.WriteLine("\n First Member Age (33): {0}",
            members.Contains(new GenericMember { MemberName = " Chue ", MemberAge = 33 }));

            // Insert a new item at position 2.
            Console.WriteLine("\n Add Member Number: (2) to List. ");
            members.Insert(2, new GenericMember() { MemberName = " Evee ", MemberAge = 15 });


            //Console.WriteLine();
            foreach (GenericMember aMember in members)
            {
                Console.WriteLine(aMember);
            }

            

            Console.WriteLine("\n Remove Member with Age: (9)");


            members.Remove(new GenericMember() { MemberAge = 9, MemberName = " Yosmine " });

            Console.WriteLine();
            foreach (GenericMember aMember in members)
            {
                Console.WriteLine(aMember);
            }
            Console.WriteLine("\n Remove Member Number: (3)");
            // This will remove the part at index 3.
            members.RemoveAt(3);

            Console.WriteLine();
            foreach (GenericMember aMember in members)
            {
                Console.WriteLine(aMember);
            }
            Console.ReadKey();

        }
    }
}
