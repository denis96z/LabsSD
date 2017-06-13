using Lab3Plugins;
using Lab3Plugins.Data;
using Lab3.GUI;
using Lab3.Manager;
using Lab3.Command;

namespace Lab3.Task
{
    class TaskManager : IManager
    {
        private University university = new University();
        private PluginsManager pluginsManager = null;

        private CommandsManager commandsManager = null;
        private InterfaceManager uiManager = null;

        public TaskManager(UI ui, PluginsManager pManager)
        {
            commandsManager = new CommandsManager();
            uiManager = new InterfaceManager(ui, university);
            pluginsManager = pManager;
        }

        public void LoadData(string fileName)
        {
            university = new IO.XMLFileManager(fileName, pluginsManager).LoadData();
            commandsManager = new CommandsManager();
            uiManager.University = university;
            uiManager.UpdateUI();
        }

        public void SaveData(string fileName)
        {
            new IO.XMLFileManager(fileName, pluginsManager).SaveData(university);
        }

        public void AddUniversityMember(IUniversityMember member)
        {
            ICommand command = new AddUniversityMemberCommand(university, member);
            commandsManager.Execute(command);
            uiManager.UpdateUI();
        }

        public void RemoveSelectedUniversityMember()
        {
            if (uiManager.UniversityMemberSelected)
            {
                IUniversityMember uMember = university[uiManager.UniversityMemberIndex];
                ICommand command = new RemoveUniversityMemberCommand(university, uMember);
                commandsManager.Execute(command);
                uiManager.UpdateUI();
            }
        }

        public void RemoveSelectedGroupMember()
        {
            if (uiManager.GroupMemberSelected &&
                university[uiManager.UniversityMemberIndex] is Group)
            {
                Group group = university[uiManager.UniversityMemberIndex] as Group;
                IPerson person = group[uiManager.GroupMemberIndex];
                ICommand command = new RemoveGroupMemberCommand(group, person);
                commandsManager.Execute(command);
                uiManager.UpdateUI();
            }
        }

        public void AddGroupMember(IPerson member)
        {
            if (uiManager.UniversityMemberSelected &&
                university[uiManager.UniversityMemberIndex] is Group)
            {
                AddGroupMemberCommand command = new AddGroupMemberCommand(
                    university[uiManager.UniversityMemberIndex] as Group, member);
                commandsManager.Execute(command);
                uiManager.UpdateUI();
            }
        }

        public void ModifyData()
        {
            ICommand command = null;
            if (uiManager.UniversityMemberAttributeSelected)
            {
                IPerson member = (IPerson)university[uiManager.UniversityMemberIndex];
                string attributeName = member.GetAttributeName(uiManager.UniversityMemberAttributeIndex);
                command = new EditPersonAttributeCommand(member,
                    attributeName, uiManager.ReadAttribute(attributeName));
            }
            else if (uiManager.GroupMemberAttributeSelected)
            {
                IPerson member = (university[uiManager.UniversityMemberIndex] as Group)
                    [uiManager.GroupMemberIndex];
                string attributeName = member.GetAttributeName(uiManager.GroupMemberAttributeIndex);
                command = new EditPersonAttributeCommand(member,
                    attributeName, uiManager.ReadAttribute(attributeName));
                commandsManager.Execute(command);
            }
            else if (uiManager.UniversityMemberSelected && !uiManager.GroupMemberSelected &&
                university[uiManager.UniversityMemberIndex] is Group)
            {
                Group group = university[uiManager.UniversityMemberIndex] as Group;
                command = new EditGroupNameCommand(group, uiManager.ReadAttribute("Группа"));
            }

            if (command != null)
            {
                commandsManager.Execute(command);
                uiManager.UpdateUI();
            }
        }

        public void ApplyUniversityActionPlugin(IUniversityActionPlugin plugin)
        {
            plugin.ApplyTo(university);
            uiManager.UpdateUI();
        }

        public void ApplyGroupActionPlugin(IGroupActionPlugin plugin)
        {
            if (uiManager.UniversityMemberSelected && !uiManager.GroupMemberSelected &&
                university[uiManager.UniversityMemberIndex] is Group)
            {
                plugin.ApplyTo(university[uiManager.UniversityMemberIndex] as Group);
                uiManager.UpdateUI();
            }
        }

        public void UndoLastChange()
        {
            if (commandsManager.Undo())
            {
                uiManager.UpdateUI();
            }
        }

        public void RedoLastChange()
        {
            if (commandsManager.Redo())
            {
                uiManager.UpdateUI();
            }
        }
    }
}
