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
            GenericMember<string> mylist = new GenericMember<string>();
            mylist.AddItem("Chue ");
            mylist.AddItem("Evee ");
            mylist.AddItem("Jessienee ");
            mylist.AddItem("Chloe ");
            mylist.AddItem("Yosmine ");
            int actual = mylist.Count();
            Console.WriteLine(" Family Member List: ");
            foreach (string element in mylist)

            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
    

            GenericMember<string> removeList = new GenericMember<string>();
            removeList.AddItem("Chue");
            removeList.AddItem("Evee");
            removeList.AddItem("Jessienee");
            removeList.AddItem("Chloe");
            removeList.AddItem("Yosmine");

            Console.WriteLine(" Before one Member is Removed: ");
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
            list1.AddItem("1");
            list1.AddItem("2");
            list1.AddItem("3");
            list1.AddItem("4");
            list1.AddItem("5");
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
            int[] MemberArrays = { 1, 2, 3, 4, 5 };
            string[] myList = { "Chue", "Evee", "Jessienee", "Chloe", "Yosmine" };

            var combinedList = list1.Zip(mylist, (first, second) => first + " " + second);

            foreach (var element in combinedList)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            //GenericMember<string> subtractOperator = new GenericMember<string>();

            //string subList1 = "Chue";
            //string subList2 = subList1 - "1";

            //Console.WriteLine(subList2);
            //Console.WriteLine();

        }
     
    }

}
