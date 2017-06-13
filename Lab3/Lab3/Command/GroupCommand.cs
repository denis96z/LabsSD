using System;
using Lab3Plugins.Data;
using Lab3Plugins;

namespace Lab3.Command
{
    abstract class GroupCommand : ICommand
    {
        protected Group receiver = null;

        public GroupCommand(Group group)
        {
            receiver = group ?? throw new ArgumentNullException();
        }

        public abstract void Execute();
        public abstract void Undo();
    }

    class EditGroupNameCommand : GroupCommand
    {
        private string oldName = null;
        private string newName = null;

        public EditGroupNameCommand(Group group,
            string name) : base(group)
        {
            oldName = group.Name;
            newName = name ?? throw new ArgumentNullException();
        }

        public override void Execute()
        {
            receiver.Name = newName;
        }

        public override void Undo()
        {
            receiver.Name = oldName;
        }
    }

    class AddGroupMemberCommand : GroupCommand
    {
        private IPerson newMember = null;

        public AddGroupMemberCommand(Group group,
            IPerson member) : base(group)
        {
            newMember = member ?? throw new ArgumentNullException();
        }

        public override void Execute()
        {
            receiver.AddMember(newMember);
        }

        public override void Undo()
        {
            receiver.RemoveMember(newMember);
        }
    }

    class RemoveGroupMemberCommand : GroupCommand
    {
        private IPerson oldMember = null;

        public RemoveGroupMemberCommand(Group group,
            IPerson member) : base(group)
        {
            oldMember = member ?? throw new ArgumentNullException();
        }

        public override void Execute()
        {
            receiver.RemoveMember(oldMember);
        }

        public override void Undo()
        {
            receiver.AddMember(oldMember);
        }
    }
}
