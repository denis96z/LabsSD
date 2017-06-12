using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
    class Group : IEnumerable<Student>
    {
        /// <summary>
        /// Название группы.
        /// </summary>
        public string Name { get; set; } = null;

        /// <summary>
        /// Список студентов.
        /// </summary>
        private List<Student> list = new List<Student>();
        /// <summary>
        /// Староста группы.
        /// </summary>
        public Student Head { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Group, который не содержит ни одного студента.
        /// </summary>
        public Group(string name)
        {
            Name = name ?? throw new ArgumentNullException("name");
        }

        /// <summary>
        /// Добавляет студента в конец списка.
        /// </summary>
        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        /// <summary>
        /// Добавляет нескольких студентов в конец списка.
        /// </summary>
        public void AddStudents(List<Student> students)
        {
            list.AddRange(students);
        }

        /// <summary>
        /// Удаляет из списка указанного студента.
        /// </summary>
        public void RemoveStudent(Student student)
        {
            list.Remove(student);
            if (student == Head)
            {
                Head = null;
            }
        }

        /// <summary>
        /// Удаляет из списка студента по указанным ФИО.
        /// </summary>
        public void Remove(string name, string middleName, string surname)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name && list[i].MiddleName ==
                    middleName && list[i].Surname == surname)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// Удаляет из списка студента по его индексу.
        /// </summary>
        public void Remove(int index)
        {
            list.RemoveAt(index);
        }

        /// <summary>
        /// Возвращает студента по его индексу в списке.
        /// </summary>
        public Student this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                list[index] = value;
            }
        }

        /// <summary>
        /// Возвращает студента по его фамилии.
        /// </summary>
        public Student this[string surname]
        {
            get
            {
                foreach (var student in list)
                {
                    if (student.Surname == surname)
                    {
                        return student;
                    }
                }

                return null;
            }
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
