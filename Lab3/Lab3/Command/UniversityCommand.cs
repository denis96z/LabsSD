using System;
using Lab3Plugins.Data;
using Lab3Plugins;

namespace Lab3.Command
{
    abstract class UniversityCommand : ICommand
    {
        protected University receiver = null;

        public UniversityCommand(University university)
        {
            receiver = university ?? throw new ArgumentNullException();
        }

        public abstract void Execute();
        public abstract void Undo();
    }

    class AddUniversityMemberCommand : UniversityCommand
    {
        private IUniversityMember newMember = null;

        public AddUniversityMemberCommand(University university,
            IUniversityMember member) : base(university)
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

    class RemoveUniversityMemberCommand : UniversityCommand
    {
        private IUniversityMember oldMember = null;

        public RemoveUniversityMemberCommand(University university,
            IUniversityMember member) : base(university)
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
