﻿using System;
using System.Collections;
using System.Collections.Generic;
using Lab3Plugins;

namespace UniversityPlugins
{
    public class Teacher : IPerson, IUniversityMember
    {
        public string Text { get; } = "Преподаватель";
        private PersonAttribute[] attributes = new PersonAttribute[5];

        public Teacher()
        {
            attributes[0].Name = "Name";
            attributes[0].Text = "Имя";
            attributes[0].Type = "System.String";
            attributes[0].Value = "";

            attributes[1].Name = "MiddleName";
            attributes[1].Text = "Отчество";
            attributes[1].Type = "System.String";
            attributes[1].Value = "";

            attributes[2].Name = "Surname";
            attributes[2].Text = "Фамилия";
            attributes[2].Type = "System.String";
            attributes[2].Value = "NewTeacher";

            attributes[3].Name = "Age";
            attributes[3].Text = "Возраст";
            attributes[3].Type = "System.Int32";
            attributes[3].Value = 0;

            attributes[4].Name = "WorkExperience";
            attributes[4].Text = "Трудовой стаж";
            attributes[4].Type = "System.Int32";
            attributes[4].Value = 0;
        }

        public string GetAttributeName(int index)
        {
            return attributes[index].Name;
        }

        public void SetAttributeValue(string attributeName, object attributeValue)
        {
            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Name == attributeName)
                {
                    attributes[i].Value = attributeValue;
                    return;
                }
            }
            throw new IndexOutOfRangeException();
        }

        public object GetAttributeValue(string attributeName)
        {
            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Name == attributeName)
                {
                    return attributes[i].Value;
                }
            }
            throw new ArgumentException();
        }

        public IEnumerator<PersonAttribute> GetEnumerator()
        {
            foreach (var attribute in attributes)
            {
                yield return attribute;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object this[string attributeName]
        {
            get { return GetAttributeValue(attributeName); }
            set { SetAttributeValue(attributeName, value); }
        }

        public override string ToString()
        {
            return Text + ": " + this["Surname"] + " " + this["Name"] + " " + this["MiddleName"];
        }
    }
}
