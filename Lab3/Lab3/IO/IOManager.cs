using System;
using System.Xml;
using Lab3Plugins.Data;
using Lab3.Manager;
using Lab3Plugins;

namespace Lab3.IO
{
    interface IIOManager
    {
        University LoadData();
        void SaveData(University university);
    }

    abstract class FileManager : IIOManager
    {
        protected string FileName { get; set; } = null;
        protected PluginsManager pluginsManager = null;

        public FileManager(string fileName, PluginsManager pManager)
        {
            FileName = fileName;
            pluginsManager = pManager;
        }

        public abstract University LoadData();
        public abstract void SaveData(University university);
    }

    class XMLFileManager : FileManager
    {
        private XmlDocument xDocument = new XmlDocument();

        public XMLFileManager(string fileName,
            PluginsManager pManager) : base(fileName, pManager) { }

        public override University LoadData()
        {
            xDocument.Load(FileName);

            XmlNode xRoot = xDocument.DocumentElement;
            if (xRoot.Name != "University")
            {
                throw new XmlException();
            }

            University university = new University();
            foreach (XmlNode xNode in xRoot)
            {
                var member = LoadUniversityMembers(xNode);
                if (member == null)
                {
                    continue;
                }
                university.AddMember(member);
            }

            return university;
        }

        private IUniversityMember LoadUniversityMembers(XmlNode xUniversityMember)
        {
            if (xUniversityMember.Name == "Group")
            {
                string name = xUniversityMember.Attributes["Name"].Value;
                if (name == null)
                {
                    throw new XmlException();
                }
                Group group = new Group(name);
                LoadGroup(xUniversityMember, group);
                return group;
            }

            foreach (Type uType in pluginsManager.UniversityPlugins)
            {
                if (xUniversityMember.Name == uType.Name)
                {
                    return (IUniversityMember)LoadPerson(xUniversityMember, uType);
                }
            }

            return null;
        }

        public void LoadGroup(XmlNode xGroup, Group group)
        {
            foreach (XmlNode xGroupMember in xGroup)
            {
                if (xGroupMember.Name == "Student")
                {
                    group.AddMember(LoadPerson(xGroupMember, new Student().GetType()));
                    continue;
                }
                foreach (Type t in pluginsManager.GroupPlugins)
                {
                    if (t.Name == xGroupMember.Name)
                    {
                        group.AddMember(LoadPerson(xGroupMember, t));
                        break;
                    }
                }
            }
        }

        public IPerson LoadPerson(XmlNode xPerson, Type personType)
        {
            IPerson person = (IPerson)Activator.CreateInstance(personType);
            foreach (XmlNode xAttribute in xPerson)
            {
                foreach (var attribute in person)
                {
                    if (attribute.Name == xAttribute.Name)
                    {
                        person.SetAttributeValue(attribute.Name, xAttribute.InnerText);
                        break;
                    }
                }
            }
            return person;
        }

        public override void SaveData(University university)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Async = false;

            using (XmlWriter writer = XmlWriter.Create(FileName))
            {
                writer.WriteStartElement("University");

                foreach (var uMember in university)
                {
                    if (uMember is Group)
                    {
                        writer.WriteStartElement("Group");
                        writer.WriteAttributeString("Name", (uMember as Group).Name);
                        foreach (var gMember in (uMember as Group))
                        {
                            WritePerson(gMember);
                        }
                        writer.WriteEndElement();
                    }
                    else
                    {
                        WritePerson(uMember as IPerson);
                    }
                }

                void WritePerson(IPerson person)
                {
                    writer.WriteStartElement(person.GetType().Name);
                    foreach (var pAttribute in person)
                    {
                        writer.WriteElementString(pAttribute.Name, pAttribute.Value.ToString());
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }
        }
    }
}
