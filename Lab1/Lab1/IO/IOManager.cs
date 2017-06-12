using System;
using System.Xml;
using System.Collections.Generic;

namespace Lab1
{
    interface IIOManager
    {
        University LoadData();
        void SaveData(University university);
    }

    abstract class FileManager : IIOManager
    {
        protected string FileName { get; set; } = null;

        public FileManager(string fileName)
        {
            FileName = fileName;
        }

        public abstract University LoadData();
        public abstract void SaveData(University university);
    }

    class XMLFileManager : FileManager
    {
        private XmlDocument xDocument = new XmlDocument();

        public XMLFileManager(string fileName) : base(fileName) { }

        public override University LoadData()
        {
            xDocument.Load(FileName);

            XmlNode xRoot = xDocument.DocumentElement;
            if (xRoot.Name != "groups")
            {
                throw new XmlException("Illegal file structure.");
            }

            University groups = new University();
            foreach (XmlNode xGroup in xRoot)
            {
                groups.AddGroup(LoadGroup(xGroup));
            }

            return groups;
        }

        private Group LoadGroup(XmlNode xGroup)
        {
            if (xGroup.Name != "group")
            {
                throw new XmlException("Illegal file structure.");
            }

            string name = xGroup.Attributes["name"].Value;
            if (name == null)
            {
                throw new XmlException("Illegal file structure.");
            }

            Group group = new Group(name);
            foreach (XmlNode xStudents in xGroup)
            {
                Student head = null;
                group.AddStudents(LoadStudents(xStudents, ref head));
                group.Head = head;
            }

            return group;
        }

        private List<Student> LoadStudents(XmlNode xStudents, ref Student head)
        {
            if (xStudents.Name != "students")
            {
                throw new XmlException("Illegal file structure.");
            }

            List<Student> students = new List<Student>();
            bool isHead = false;

            foreach (XmlNode xStudent in xStudents)
            {
                Student student = LoadStudent(xStudent, out isHead);
                students.Add(student);
                if (isHead)
                {
                    head = student;
                }
            }

            return students;
        }

        private Student LoadStudent(XmlNode xStudent, out bool isHead)
        {
            if (xStudent.Name != "student")
            {
                throw new XmlException("Illegal file structure.");
            }

            if (xStudent.Attributes["head"] == null)
            {
                isHead = false;
            }
            else
            {
                isHead = xStudent.Attributes["head"].Value == "true" ? true : false;
            }

            string name = null, surname = null, middleName = null;
            byte rating = 0;
            foreach (XmlNode xStudentField in xStudent)
            {
                switch (xStudentField.Name)
                {
                    case "name":
                        name = xStudentField.InnerText;
                        break;

                    case "middleName":
                        middleName = xStudentField.InnerText;
                        break;

                    case "surname":
                        surname = xStudentField.InnerText;
                        break;

                    case "rating":
                        rating = byte.Parse(xStudentField.InnerText);
                        break;

                    default:
                        throw new XmlException("Illegal file structure.");
                }
            }

            return new Student(name, middleName, surname, rating);
        }

        XmlWriter xWriter = null;

        public override void SaveData(University university)
        {
            xWriter = XmlWriter.Create(FileName);

            xWriter.WriteStartElement("groups");
            foreach (var group in university)
            {
                SaveGroup(group);
            }
            xWriter.WriteEndElement();

            xWriter.Close();
        }

        private void SaveGroup(Group group)
        {
            xWriter.WriteStartElement("group");
            xWriter.WriteAttributeString("name", group.Name);
            xWriter.WriteStartElement("students");
            foreach (var student in group)
            {
                SaveStudent(student, student == group.Head);
            }
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
        }

        private void SaveStudent(Student student, bool isHead)
        {
            xWriter.WriteStartElement("student");
            if (isHead)
            {
                xWriter.WriteAttributeString("head", "true");
            }
            xWriter.WriteElementString("surname", student.Surname);
            xWriter.WriteElementString("name", student.Name);
            xWriter.WriteElementString("middleName", student.MiddleName);
            xWriter.WriteElementString("rating", student.Rating.ToString());
            xWriter.WriteEndElement();
        }
    }
}
