using System;
using System.Collections;
using System.Collections.Generic;
using Lab3Plugins;

namespace Lab3Plugins.Data
{
    public class University : IEnumerable<IUniversityMember>
    {
        private List<IUniversityMember> members = new List<IUniversityMember>();

        public void AddMember(IUniversityMember member)
        {
            members.Add(member);
        }

        public void AddMembers(params IUniversityMember[] newMembers)
        {
            foreach (var member in newMembers)
            {
                AddMember(member);
            }
        }

        public void AddMembers(List<IUniversityMember> newMembers)
        {
            foreach (var member in newMembers)
            {
                AddMember(member);
            }
        }

        public void RemoveMember(IUniversityMember member)
        {
            members.Remove(member);
        }

        public IEnumerator<IUniversityMember> GetEnumerator()
        {
            return members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IUniversityMember this[int index]
        {
            get { return members[index]; }
            set { members[index] = value; }
        }
    }
}
