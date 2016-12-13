using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;

namespace CustomListClass
{
    public class GenericMember/* : IEnumerable*/
    {
        //private string[] membersArray;
        //private List<string> membersList;


        public string familyMembers;
        public string memberName;
        public double memberAge;
        public double getNumber;

        double[] membersAge = { 33, 15, 12, 10, 9 };
      
        public GenericMember()
        {

        }
        //public FamilyMembers()
        //{
        //    Console.Write(" Members of this Family ");
        //}
        public string MemberName { get; set; }

        public int MemberAge { get; set; }

        public string MemberHobby { get; set; }

        public override string ToString()
        {
            return " Name: " + MemberName + " Age: " + MemberAge + " Hobby: " + MemberHobby;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            GenericMember objAsMember = obj as GenericMember;
            if (objAsMember == null) return false;
            else return Equals(objAsMember);
        }
        public int GetNumber()
        {
            return MemberAge;
        }
        public bool Equals(GenericMember other)
        {
            if (other == null) return false;
            return (this.MemberAge.Equals(other.MemberAge));
        }

        }
    }

