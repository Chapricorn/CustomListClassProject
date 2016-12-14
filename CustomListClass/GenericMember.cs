using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;


namespace CustomListClass
{
    public class GenericMember<T> : IEnumerable
    {
        T[] elements;

        public GenericMember()
        {
            elements = new T[0];
        }

        //public int[] membersArray;
        public object[] membersArray { get; set; }
        public int age;
       
        public bool value;


        public int Capacity { get; set; }

        //public GenericMember()
        //{
        //    membersArray = new T[Capacity];
        //}

        public GenericMember(int age)
        {
            this.age = age;
        }


        //public List<Member> memberList { get; set;}


        public void AddItem(object[] myArray)
        {
            Capacity ++;
            membersArray = myArray;
        }

        //public void InsertMemberList(List<Member> memberListItem)
        //{
        //    memberList = memberListItem;
        //}

        public bool Remove(T toRemoveItem)
        {
            if (elements.Count() > 0)
            {
                T[] newElements = new T[Count() - 1];
                int count = 0;
                bool found = false;
                int foundIndex = 0;
                foreach (T element in elements)
                {
                    if (element.Equals(toRemoveItem))
                    {
                        found = true;
                        foundIndex = count;
                    }
                    count++;
                }
                if (found)
                {
                    count = 0;
                    int newCount = 0;
                    foreach (T element in elements)
                    {
                        if (count != foundIndex)
                        {
                            newElements[newCount] = element;
                            count++;
                            newCount++;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    elements = newElements;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
        //public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        //{

        //}
        //public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        //{

        //}
        //public IEnumerator<T> GetEnumerator()
        //{

        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{

        //}

        public void Print()
        {
            Console.WriteLine(value);
        }

    }


