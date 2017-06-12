using System;

namespace Lab1
{
    abstract class GroupCommand : Command<Group>
    {
        public GroupCommand(Group receiver) : base(receiver) { }
    }

    class RenameGroupCommand : GroupCommand
    {
        private string oldName = null;
        private string newName = null;

        public RenameGroupCommand(Group receiver,
            string newName) : base(receiver)
        {
            this.oldName = receiver.Name;
            this.newName = newName ??
                throw new ArgumentNullException("newName");
        }

        public override void Execute()
        {
            this.Receiver.Name = newName;
        }

        public override void Undo()
        {
            this.Receiver.Name = oldName;
        }
    }

    class AddStudentCommand : GroupCommand
    {
        private Student newStudent = null;

        public AddStudentCommand(Group group,
            Student student) : base(group)
        {
            this.newStudent = student ??
                throw new ArgumentNullException("student");
        }

        public override void Execute()
        {
            this.Receiver.AddStudent(this.newStudent);
        }

        public override void Undo()
        {
            this.Receiver.RemoveStudent(this.newStudent);
        }
    }

    class RemoveStudentCommand : GroupCommand
    {
        private Student oldStudent = null;
        private ChangeHeadCommand changeHeadCommand = null;

        public RemoveStudentCommand(Group group,
            Student student) : base(group)
        {
            this.oldStudent = student ??
                throw new ArgumentNullException("student");
            this.changeHeadCommand = new ChangeHeadCommand(group, null);
        }

        public override void Execute()
        {
            this.Receiver.RemoveStudent(this.oldStudent);
            this.changeHeadCommand.Execute();
        }

        public override void Undo()
        {
            this.changeHeadCommand.Undo();
            this.Receiver.AddStudent(this.oldStudent);
        }
    }

    class ChangeHeadCommand : GroupCommand
    {
        private Student previousHead = null;
        private Student newHead = null;

        public ChangeHeadCommand(Group group,
            Student newHead) : base(group)
        {
            this.previousHead = group.Head;
            this.newHead = newHead;
        }

        public override void Execute()
        {
            this.Receiver.Head = this.newHead;
        }

        public override void Undo()
        {
            this.Receiver.Head = this.previousHead;
        }
    }
}