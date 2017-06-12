using System;

namespace Lab1
{
    /// <summary>
    /// Представляет информацию о студенте.
    /// </summary>
    class Student : Person
    {
        /// <summary>
        /// Минимальное значение рейтинга студента.
        /// </summary>
        public const byte MIN_RATING = 0;
        /// <summary>
        /// Максимальное значение рейтинга студента.
        /// </summary>
        public const byte MAX_RATING = 100;

        /// <summary>
        /// Рейтинг студента.
        /// </summary>
        private byte rating = 0;

        /// <summary>
        /// Рейтинг.
        /// </summary>
        public byte Rating
        {
            get
            {
                return rating;
            }

            set
            {
                if (value < MIN_RATING || value > MAX_RATING)
                {
                    throw new Exception("Invalid value!");
                }
                rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Student с указанными ФИО и значением рейтинга.
        /// </summary>
        public Student(string name, string middleName,
            string surname, byte rating = MIN_RATING) : base(name, middleName, surname)
        {
            Rating = rating;
        }
    }
}
