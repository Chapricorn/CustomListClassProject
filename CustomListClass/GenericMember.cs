using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;


namespace CustomListClass
{
    public class GenericMember<T> : IEnumerable<T>
    {

        // Declare variables
        T[] MemberArrays;
        int i;
        public bool remove;
        public string toString;


        /// <summary>
        /// constructor
        /// </summary>
        public GenericMember()
        {
            MemberArrays = new T[0];
            remove = true;
        }
        public int Capacity { get; set; }


        public T[] myArray { get; private set; }

        public int MyArray()
        {
            //myArray = new T[Capacity];
            int result = 0;
            if (myArray.Length > 5)
            {
                result = 5;
            }
            else if (myArray.Length < 0)
            {
                result = 0;
            }
            return result;
        }

        public T[] memberArrays { get; set; }
        public int age;

        public bool value;

        public int Count()
        {
            int count = 0;
            if (MemberArrays != null)
            {
                foreach (object memArray in MemberArrays)
                {
                    count++;
                }
                return count;
            }
            else
            {
                return 0;
            }
        }


        public GenericMember(int age)
        {
            this.age = age;
        }


        //public List<Member> memberList { get; set;}


        public void AddItem()
        {
            int count = 0;
            Capacity++;
            //MemberArrays = newMemberArrays;

            T[] newMemberArrays = new T[MemberArrays.Length + 1];
            for (i = 0; i < MemberArrays.Length; i++)
            {
                newMemberArrays[i] = MemberArrays[i];
            }
            T myNewArray = default(T);
            newMemberArrays[MemberArrays.Length] = myNewArray;
            MemberArrays = newMemberArrays;
        }


        public void AddElement(T element)
        {
            int count = 0;
            T[] newElements = new T[Count() + 1];
            if (MemberArrays != null)
            {
                foreach (T elem in MemberArrays)
                {
                    newElements[count] = elem;
                    count++;
                }
                newElements[count] = element;
            }
            else
            {
                newElements[0] = element;
            }
            MemberArrays = newElements;
        }
        //public void InsertMemberList(List<Member> T memberArrays)
        //{
        //    memberList = memberListItem;

        //}

        public void RemoveItem(T removedItem)
        {
            T[] removeFromList = new T[MemberArrays.Length - 1];
            for (i = 0; i <= removeFromList.Length; i++)
            {
                if (remove)
                {
                    if (MemberArrays[i].Equals(removedItem))
                    {
                        remove = false;
                    }
                    else
                    {
                        removeFromList[i] = MemberArrays[i];
                    }
                }

                else
                {
                    removeFromList[i - 1] = MemberArrays[i];
                }

            }
            MemberArrays = removeFromList;
        }

        public static GenericMember<T> operator +(GenericMember<T> myArray, GenericMember<T> myMember)
        {
            GenericMember<T> combinedGenericMember = new GenericMember<T>();
            foreach (T member in myArray.MemberArrays)
            {
                combinedGenericMember.AddItem();
            }
            foreach (T member in myMember.MemberArrays)
            {
                combinedGenericMember.AddItem();
            }
            return combinedGenericMember;
        }




        public static GenericMember<T> operator - (GenericMember<T> myArray, GenericMember<T> myMember)
        {
            foreach (T member in myMember)
            {
                myArray.RemoveItem(member);
            }
            return myArray;
        }
        public void Display()
        {
            if (MemberArrays != null)
            {
                foreach (object member in MemberArrays)
                {
                    Console.WriteLine(member);
                }
            }
            else
            {
                Console.WriteLine("List is Null");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (i = 0; i < MemberArrays.Length; i++)
            {
                yield return MemberArrays[i];

            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Print()
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Convert MemberArrays to a String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string convertedString = "";
            foreach (T element in MemberArrays)
            {
                convertedString += element;
            }
            return convertedString;
        }
    }
}


