using System;
using System.Collections;
using System.Collections.Generic;
using Lab3Plugins;

namespace Lab3Plugins.Data
{
    public class Group : IUniversityMember, IEnumerable<IPerson>
    {
        public string Name { get; set; }
        public List<IPerson> Members { get; private set; } = new List<IPerson>();

        public Group(string name)
        {
            Name = name;
        }

        public void AddMember(IPerson newMember)
        {
            Members.Add(newMember);
        }

        public void AddMembers(params IPerson[] newMembers)
        {
            foreach (var member in newMembers)
            {
                AddMember(member);
            }
        }

        public void AddMembers(List<IPerson> newMembers)
        {
            foreach (var member in newMembers)
            {
                AddMember(member);
            }
        }

        public int GetMemberIndex(IPerson member)
        {
            return Members.IndexOf(member);
        }

        public void RemoveMember(IPerson member)
        {
            Members.Remove(member);
        }

        public void RemoveMemberByIndex(int index)
        {
            Members.RemoveAt(index);
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            return Members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return "Группа: " + Name;
        }

        public IPerson this[int index]
        {
            get { return Members[index]; }
            set { Members[index] = value; }
        }
    }
}
