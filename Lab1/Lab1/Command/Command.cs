using System;
using System.Collections.Generic;

namespace Lab1
{
    /// <summary>
    /// Представляет интерфейс для команды.
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Запускает выполнение команды.
        /// </summary>
        void Execute();
        /// <summary>
        /// Отменяет команду.
        /// </summary>
        void Undo();
    }

    /// <summary>
    /// Команда.
    /// </summary>
    abstract class Command<T> : ICommand
        where T : class
    {
        /// <summary>
        /// Исполнитель.
        /// </summary>
        protected T Receiver { get; private set; }

        /// <summary>
        /// Создает экземпляр класса Command для заданного исполнителя.
        /// </summary>
        public Command(T receiver)
        {
            this.Receiver = receiver ??
                throw new ArgumentNullException("receiver");
        }

        public abstract void Execute();
        public abstract void Undo();
    }

    /// <summary>
    /// Определяет набор команд для выполнения как единой команды.
    /// </summary>
    abstract class ComplexCommand<T> : Command<T>
        where T : class
    {
        /// <summary>
        /// Список команд для выполнения.
        /// </summary>
        private List<Command<T>> commands = new List<Command<T>>();

        /// <summary>
        /// Создает экземпляр класса ComplexCommand для заданного исполнителя.
        /// </summary>
        public ComplexCommand(T receiver,
            params Command<T>[] commands) : base(receiver)
        {
            foreach (var command in commands)
            {
                this.commands.Add(command);
            }
        }

        public override void Execute()
        {
            foreach (var command in this.commands)
            {
                command.Execute();
            }
        }

        public override void Undo()
        {
            foreach (var command in this.commands)
            {
                command.Undo();
            }
        }
    }
}