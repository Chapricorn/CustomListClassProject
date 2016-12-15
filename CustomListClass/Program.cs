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
            GenericMember<string> Capacity = new GenericMember<string>();
            Console.WriteLine("\nCapacity/Total Members: {0}", Capacity);
            Console.ReadLine();


            GenericMember<string> mylist = new GenericMember<string>();
            mylist.AddElement(" Chue ");
            mylist.AddElement(" Evee ");
            mylist.AddElement(" Jessienee ");
            mylist.AddElement(" Chloe ");
            mylist.AddElement(" Yosmine ");
            int actual = mylist.Count();

            Console.WriteLine(" Add Members to List: \n");
            foreach (string element in mylist)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

           
            GenericMember<string> removeList = new GenericMember<string>();
            removeList.AddElement("Chue");
            removeList.AddElement("Evee");
            removeList.AddElement("Jessienee");
            removeList.AddElement("Chloe");
            removeList.AddElement("Yosmine");

            Console.WriteLine(" All Members before one Member is Removed: ");
            foreach (string element in removeList)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
           
            removeList.RemoveItem("Evee");

            Console.WriteLine(" Member Named 'Evee' removed from  List: ");
            foreach (string element in removeList)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddElement("1");
            list1.AddElement("2");
            list1.AddElement("3");
            list1.AddElement("4");
            list1.AddElement("5");
            Console.WriteLine(" Number representing each Family members: ");
            foreach (string element in list1)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            string myString = mylist.ToString();

            Console.WriteLine(" Number converted to Names: ");
            {
                Console.WriteLine(myString);
            }
            Console.ReadLine();


            GenericMember<string> combinedGenericMember = new GenericMember<string>();
            Console.WriteLine(" Combined Number of Family Members with their Names: ");
            int[] MemberArrays = { 1, 2, 3, 4, 5};
            string[] myList = { "Chue", "Evee", "Jessienee", "Chloe", "Yosmine"};

            var combinedList = list1.Zip(mylist, (first, second) => first + " " + second);

            foreach (var element in combinedList)              
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            //GenericMember<string> addingOperator = new GenericMember<string>();
            
            //string list1 = "1", "2", "3", "4", "5";
            //string myList = 


            //var list1 = new[] { 1, 2, 3 };
            //var myList = new[] { "string 1", "string 2", "string 3" };
            //var combinedFiles = list1.Zip(list1, ()


        }
    }
}
