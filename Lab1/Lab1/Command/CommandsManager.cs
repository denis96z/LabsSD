using System.Collections.Generic;

namespace Lab1
{
    class CommandsManager
    {
        private Stack<ICommand> executedCommands = new Stack<ICommand>();
        private Stack<ICommand> cancelledCommands = new Stack<ICommand>();

        public void Execute(ICommand command)
        {
            command.Execute();
            executedCommands.Push(command);
            cancelledCommands.Clear();
        }

        public bool Undo()
        {
            if (executedCommands.Count > 0)
            {
                ICommand command = executedCommands.Pop();
                command.Undo();
                cancelledCommands.Push(command);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Redo()
        {
            if (cancelledCommands.Count > 0)
            {
                ICommand command = cancelledCommands.Pop();
                command.Execute();
                executedCommands.Push(command);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
