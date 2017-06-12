using System.Collections;
using System.Collections.Generic;

namespace Lab1
{
    /// <summary>
    /// Представляет список групп.
    /// </summary>
    class University : IEnumerable<Group>
    {
        /// <summary>
        /// Список групп.
        /// </summary>
        private List<Group> list = new List<Group>();

        /// <summary>
        /// Инициализирует новый экземпляр класса University, который не содержит ни одной группы.
        /// </summary>
        public University() { }

        /// <summary>
        /// Добавляет группу в конец списка.
        /// </summary>
        public void AddGroup(Group group)
        {
            list.Add(group);
        }

        /// <summary>
        /// Удаляет группу из списка.
        /// </summary>
        public void RemoveGroup(Group group)
        {
            list.Remove(group);
        }

        /// <summary>
        /// Возвращает группу по ее индексу в списке.
        /// </summary>
        public Group this[int index]
        {
            get
            {
                return list[index];
            }
        }

        /// <summary>
        /// Возвращает группу по ее имени.
        /// </summary>
        public Group this[string name]
        {
            get
            {
                foreach (var group in list)
                {
                    if (group.Name == name)
                    {
                        return group;
                    }
                }

                return null;
            }
        }

        public IEnumerator<Group> GetEnumerator()
        {
            foreach (var group in list)
            {
                yield return group;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}