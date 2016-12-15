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

            // Add element to the list

            GenericMember<string> mylist = new GenericMember<string>();
            mylist.AddElement("string 1");
            mylist.AddElement("string 2");
            mylist.AddElement("string 3");
            int actual = mylist.Count();

            Console.WriteLine(" These are the elements from AddElement List: ");
            foreach (string element in mylist)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            
            // Add "A B and C" to the List
            GenericMember<string> removeList = new GenericMember<string>();
            removeList.AddElement("A");
            removeList.AddElement("B");
            removeList.AddElement("C");

            Console.WriteLine(" These are the element before removed one element from  List: ");
            foreach (string element in removeList)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            // Remove "B" from the List
            removeList.RemoveItem("B");

            Console.WriteLine(" These are the element after removed B element from  List: ");
            foreach (string element in removeList)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            // Convert Array Name removeList to a String
            GenericMember<string> list1 = new GenericMember<string>();
            list1.AddElement("1");
            list1.AddElement("2");
            list1.AddElement("3");
            Console.WriteLine(" These are the element in the list before convert to a String : ");
            foreach (string element in list1)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();


            // Convert list1 to a String
            string myString = list1.ToString();


            Console.WriteLine(" This is the result from ToString() Method: ");
           
            Console.WriteLine(myString);
        


        }
    }
}
