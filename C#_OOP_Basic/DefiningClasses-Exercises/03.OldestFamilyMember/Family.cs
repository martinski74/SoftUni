
using System.Collections.Generic;
using System.Linq;

namespace _03.OldestFamilyMember
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMembers()
        {
            return this.members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
        }
    }
}
