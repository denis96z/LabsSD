using System;

namespace Lab1
{
    /// <summary>
    /// Представляет информацию о человеке.
    /// </summary>
    class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Создает экземпляр класса Person с указанными ФИО.
        /// </summary>
        public Person(string name, string middleName, string surname)
        {
            Name = name ?? throw new ArgumentNullException("name");
            MiddleName = middleName ?? throw new ArgumentNullException("middleName");
            Surname = surname ?? throw new ArgumentNullException("surname");
        }

        /// <summary>
        /// Возвращает строковое представление экземпляра в форме ФИО.
        /// </summary>
        public override string ToString()
        {
            return Surname + " " + Name + " " + MiddleName;
        }
    }
}