using System;
using System.Windows.Forms;

namespace Lab1
{
    /// <summary>
    /// Представляет пользовательский интерфейс для отображения данных.
    /// </summary>
    struct UI
    {
        public ListBox Groups;

        public TextBox GroupName;
        public ListBox Students;

        public TextBox StudentName;
        public TextBox StudentMiddleName;
        public TextBox StudentSurname;
        public NumericUpDown Rating;
        public CheckBox GroupHead;
    }

    class InterfaceManager : IManager
    {
        private UI ui;

        public University University { get; set; } = null;
        public int SelectedGroupIndex { get; private set; } = -1;
        public int SelectedStudentIndex { get; private set; } = -1;

        private void OnGroupSelected(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem == null)
            {
                SelectedGroupIndex = -1;
            }
            else
            {
                SelectedGroupIndex = listBox.SelectedIndex;
                UpdateGroup();
            }
        }

        private void OnStudentSelected(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem == null)
            {
                SelectedStudentIndex = -1;
            }
            else
            {
                SelectedStudentIndex = listBox.SelectedIndex;
                UpdateStudent();
            }
        }

        private void OnGroupNameModified(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (GroupSelected)
            {
                textBox.ReadOnly = !textBox.ReadOnly;
            }
        }

        private void OnHeadChanged(object sender, EventArgs e)
        {
            /*if (StudentSelected)
            {
                (sender as CheckBox).Checked = true;
            }*/
        }

        public InterfaceManager(UI ui, University university = null)
        {
            this.ui = ui;
            University = university == null ? new University() : university;

            ui.Groups.SelectedIndexChanged += OnGroupSelected;
            ui.GroupName.DoubleClick += OnGroupNameModified;
            ui.Students.SelectedIndexChanged += OnStudentSelected;
            ui.GroupHead.CheckedChanged += OnHeadChanged;

            ui.Rating.Minimum = Student.MIN_RATING;
            ui.Rating.Maximum = Student.MAX_RATING;
        }

        public bool GroupSelected
        {
            get { return SelectedGroupIndex != -1; }
        }

        public bool StudentSelected
        {
            get { return SelectedStudentIndex != -1; }
        }

        public void UpdateUI()
        {
            UpdateUniversity();
            UpdateGroup();
            UpdateStudent();
        }

        public void UpdateUniversity()
        {
            ClearUniversity();
            foreach (var group in University)
            {
                ui.Groups.Items.Add(group.Name);
            }
        }

        public void UpdateGroup()
        {
            ClearStudents();
            if (!GroupSelected)
            {
                return;
            }

            ui.GroupName.Text = University[SelectedGroupIndex].Name;
            foreach (var student in University[SelectedGroupIndex])
            {
                ui.Students.Items.Add(student.ToString() +
                    (University[SelectedGroupIndex].Head == student ? "\tC" : ""));
            }
        }

        public void UpdateStudent()
        {
            ClearStudent();
            if (!StudentSelected)
            {
                return;
            }

            Group group = University[SelectedGroupIndex];
            Student student = University[SelectedGroupIndex][SelectedStudentIndex];
            ui.StudentName.Text = student.Name;
            ui.StudentMiddleName.Text = student.MiddleName;
            ui.StudentSurname.Text = student.Surname;
            ui.Rating.Value = student.Rating;
            ui.GroupHead.Checked = group.Head == student;
        }

        private void ClearUniversity()
        {
            ui.Groups.Items.Clear();
        }

        private void ClearStudents()
        {
            ui.GroupName.Text = "";
            ui.Students.Items.Clear();
        }

        public void ClearStudent()
        {
            ui.StudentName.Text = "";
            ui.StudentMiddleName.Text = "";
            ui.StudentSurname.Text = "";
            ui.Rating.Value = 0;
            ui.GroupHead.Checked = false;
        }

        public void ClearUI()
        {
            ClearUniversity();
            ClearStudents();
            ClearStudent();
        }

        public void ClearSelection()
        {
            ui.Groups.SelectedIndex = -1;
            ui.Students.SelectedIndex = -1;
        }
    }
}