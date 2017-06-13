using System;

namespace Lab3Plugins
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public abstract class PersonCommand : ICommand
    {
        protected IPerson receiver = null;

        public PersonCommand(IPerson person)
        {
            receiver = person ?? throw new ArgumentNullException();
        }

        public abstract void Execute();
        public abstract void Undo();
    }

    public class EditPersonAttributeCommand : PersonCommand
    {
        private string attributeName = null;
        private object oldValue = null;
        private object newValue = null;

        public EditPersonAttributeCommand(IPerson person,
            string attribute, object value) : base(person)
        {
            attributeName = attribute ?? throw new ArgumentNullException();
            oldValue = person.GetAttributeValue(attributeName);
            newValue = value ?? throw new ArgumentNullException();
        }

        public override void Execute()
        {
            receiver.SetAttributeValue(attributeName, newValue);
        }

        public override void Undo()
        {
            receiver.SetAttributeValue(attributeName, oldValue);
        }
    }
}
