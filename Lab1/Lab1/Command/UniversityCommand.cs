using System;

namespace Lab1
{
    abstract class UniversityCommand : Command<University>
    {
        public UniversityCommand(University receiver) : base(receiver) { }
    }

    class AddGroupCommand : UniversityCommand
    {
        private Group newGroup = null;

        public AddGroupCommand(University receiver,
            Group group) : base(receiver)
        {
            this.newGroup = group ??
                throw new ArgumentNullException("group");
        }

        public override void Execute()
        {
            this.Receiver.AddGroup(this.newGroup);
        }

        public override void Undo()
        {
            this.Receiver.RemoveGroup(this.newGroup);
        }
    }

    class RemoveGroupCommand : UniversityCommand
    {
        private Group oldGroup = null;

        public RemoveGroupCommand(University receiver,
            Group group) : base(receiver)
        {
            this.oldGroup = group ??
                throw new ArgumentNullException("group");
        }

        public override void Execute()
        {
            this.Receiver.RemoveGroup(this.oldGroup);
        }

        public override void Undo()
        {
            this.Receiver.AddGroup(this.oldGroup);
        }
    }
}