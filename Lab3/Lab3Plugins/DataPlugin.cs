using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3Plugins
{
    public struct PersonAttribute
    {
        public string Name;
        public string Text;
        public string Type;
        public object Value;
    }

    public interface IPerson : IEnumerable<PersonAttribute>
    {
        string Text { get; }
        string GetAttributeName(int index);
        void SetAttributeValue(string attributeName, object attributeValue);
        object GetAttributeValue(string attributeName);
    }

    public interface IGroupMember { }
    public interface IUniversityMember { }
}
