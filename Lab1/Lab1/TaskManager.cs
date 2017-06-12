namespace Lab1
{
    class TaskManager : IManager
    {
        private University university = new University();

        private CommandsManager commandsManager = null;
        private InterfaceManager uiManager = null;
        
        public TaskManager(UI ui)
        {
            commandsManager = new CommandsManager();
            uiManager = new InterfaceManager(ui);
        }

        public void LoadData(string fileName)
        {
            university = new IOManagerByExtensionSelector(fileName).GetManager().LoadData();
            commandsManager = new CommandsManager();
            uiManager.University = university;
            uiManager.UpdateUniversity();
        }

        public void SaveDate(string fileName)
        {
            new IOManagerByExtensionSelector(fileName).GetManager().SaveData(university);
        }

        public void AddGroup(string name)
        {
            Group group = new Group(name);
            ICommand command = new AddGroupCommand(university, group);
            commandsManager.Execute(command);
            uiManager.UpdateUI();
        }

        public void RemoveSelectedGroup()
        {
            if (uiManager.GroupSelected)
            {
                Group group = university[uiManager.SelectedGroupIndex];
                ICommand command = new RemoveGroupCommand(university, group);
                commandsManager.Execute(command);
                uiManager.ClearSelection();
                uiManager.UpdateUI();
            }
        }

        public void RenameSelectedGroup(string name)
        {
            if (uiManager.GroupSelected)
            {
                Group group = university[uiManager.SelectedGroupIndex];
                ICommand command = new RenameGroupCommand(group, name);
                commandsManager.Execute(command);
                uiManager.ClearSelection();
                uiManager.UpdateUI();
            }
        }

        public void AddStudent(string name, string middleName, string surname)
        {
            if (uiManager.GroupSelected)
            {
                Student student = new Student(name, middleName, surname);
                ICommand command = new AddStudentCommand(university[uiManager.SelectedGroupIndex], student);
                commandsManager.Execute(command);
                uiManager.UpdateUI();
            }
        }

        public void RemoveSelectedStudent()
        {
            if (uiManager.GroupSelected && uiManager.StudentSelected)
            {
                Group group = university[uiManager.SelectedGroupIndex];
                Student student = group[uiManager.SelectedStudentIndex];
                commandsManager.Execute(new RemoveStudentCommand(group, student));
                uiManager.ClearSelection();
                uiManager.UpdateUI();
            }
        }

        public void EditStudent(string name, string middleName, string surname, byte rating, bool isHead)
        {
            if (uiManager.StudentSelected)
            {
                Student student = university[uiManager.SelectedGroupIndex][uiManager.SelectedStudentIndex];
                commandsManager.Execute(new EditStudentCommand(student, name, middleName, surname, rating));
                if (isHead)
                {
                    Group group = university[uiManager.SelectedGroupIndex];
                    commandsManager.Execute(new ChangeHeadCommand(group, student));
                }
                uiManager.UpdateUI();
            }
        }

        public void UndoLastChange()
        {
            if (commandsManager.Undo())
            {
                uiManager.ClearUI();
                uiManager.UpdateUI();
            }
        }

        public void RedoLastChange()
        {
            if (commandsManager.Redo())
            {
                uiManager.ClearUI();
                uiManager.UpdateUI();
            }
        }
    }
}