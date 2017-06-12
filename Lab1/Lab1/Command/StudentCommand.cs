using System;

namespace Lab1
{
    abstract class StudentCommand : Command<Student>
    {
        public StudentCommand(Student receiver) : base(receiver) { }
    }

    class EditStudentNameCommand : StudentCommand
    {
        private string previousName = null;
        private string newName = null;

        public EditStudentNameCommand(Student receiver,
            string newName) : base(receiver)
        {
            this.previousName = receiver.Name;
            this.newName = newName;
        }

        public override void Execute()
        {
            Receiver.Name = newName;
        }

        public override void Undo()
        {
            Receiver.Name = previousName;
        }
    }

    class EditStudentMiddleNameCommand : StudentCommand
    {
        private string previousMiddleName = null;
        private string newMiddleName = null;

        public EditStudentMiddleNameCommand(Student receiver,
            string newMiddleName) : base(receiver)
        {
            this.previousMiddleName = receiver.MiddleName;
            this.newMiddleName = newMiddleName;
        }

        public override void Execute()
        {
            Receiver.MiddleName = newMiddleName;
        }

        public override void Undo()
        {
            Receiver.MiddleName = previousMiddleName;
        }
    }

    class EditStudentSurnameCommand : StudentCommand
    {
        private string previousSurname = null;
        private string newSurname = null;

        public EditStudentSurnameCommand(Student receiver,
            string newSurname) : base(receiver)
        {
            this.previousSurname = receiver.Surname;
            this.newSurname = newSurname;
        }

        public override void Execute()
        {
            Receiver.Surname = newSurname;
        }

        public override void Undo()
        {
            Receiver.Surname = previousSurname;
        }
    }

    class EditStudentRatingCommand : StudentCommand
    {
        private byte previousRating = 0;
        private byte newRating = 0;

        public EditStudentRatingCommand(Student receiver,
            byte newRating) : base(receiver)
        {
            this.previousRating = receiver.Rating;
            this.newRating = newRating;
        }

        public override void Execute()
        {
            Receiver.Rating = newRating;
        }

        public override void Undo()
        {
            Receiver.Rating = previousRating;
        }
    }

    class EditStudentCommand : ComplexCommand<Student>
    {
        public EditStudentCommand(Student student, string newName,
            string newMiddleName, string newSurname, byte newRating) :
            base(student, new EditStudentNameCommand(student, newName),
                new EditStudentMiddleNameCommand(student, newMiddleName),
                new EditStudentSurnameCommand(student, newSurname),
                new EditStudentRatingCommand(student, newRating)) { }
    }
}
