using System;
using System.Collections.Generic;

using Lab3Plugins;
using Lab3Plugins.Data;

namespace UniversityActionPlugins
{
    public class OrderBySurnamePlugin : IUniversityActionPlugin
    {
        public string ActionText { get; private set; } =
            "Отсортировать по фамилии";

        public void ApplyTo(University university)
        {
            foreach (var member in university)
            {
                if (member is Group)
                {
                    List<IPerson> gMembers = (member as Group).Members;
                    gMembers.Sort((x, y) =>
                    {
                        string xSurname = (string)x.GetAttributeValue("Surname");
                        string ySurname = (string)y.GetAttributeValue("Surname");
                        if (xSurname != null && ySurname != null)
                        {
                            return xSurname.CompareTo(ySurname);
                        }
                        else if (xSurname == null)
                        {
                            return 1;
                        }
                        return -1;
                    });
                }
            }
        }
    }
}
