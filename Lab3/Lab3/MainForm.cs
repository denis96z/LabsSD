using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;

using Lab3Plugins.Data;
using Lab3.GUI;
using Lab3.Task;
using Lab3.Manager;
using Lab3Plugins;

namespace Lab3
{
    public partial class MainForm : Form
    {
        TaskManager taskManager = null;
        PluginsManager pluginsManager = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void miAddPluginUniversityMember_Click(object sender, EventArgs e)
        {
            try
            {
                string type = (sender as ToolStripMenuItem).Name.Substring(2);
                IUniversityMember member = (IUniversityMember)Activator.CreateInstance(pluginsManager[type]);
                taskManager.AddUniversityMember(member);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miAddPluginGroupMember_Click(object sender, EventArgs e)
        {
            try
            {
                string type = (sender as ToolStripMenuItem).Name.Substring(2);
                IPerson member = (IPerson)Activator.CreateInstance(pluginsManager[type]);
                taskManager.AddGroupMember(member);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tvUniversity_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                taskManager.ModifyData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdDataDialog.ShowDialog() == DialogResult.OK)
                {
                    taskManager.LoadData(ofdDataDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.AddUniversityMember(new Group("NewGroup"));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
}

        private void miAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.AddGroupMember(new Student());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miUndo_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.UndoLastChange();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miRedo_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.RedoLastChange();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                pluginsManager = new PluginsManager();
                pluginsManager.LoadPlugins();

                ManageSettings();
                LoadUniversityPlugins();
                LoadGroupPlugins();
                LoadUniversityActionPlugins();
                LoadGroupActionPlugins();

                UI ui;
                ui.University = tvUniversity;
                taskManager = new TaskManager(ui, pluginsManager);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // ---------------------------------------------------------------------------------------------
        // Загрузка и подключение плагинов.
        // ---------------------------------------------------------------------------------------------

        private void LoadUniversityPlugins()
        {
            foreach (Type uPlugin in pluginsManager.UniversityPlugins)
            {
                ToolStripItem newItem = new ToolStripMenuItem(uPlugin.Name);
                newItem.Name = "mi" + uPlugin.Name;
                newItem.Click += miAddPluginUniversityMember_Click;

                ((msMainMenu.Items["miUniversity"] as ToolStripMenuItem).
                    DropDownItems["miAddUniversityMember"] as ToolStripMenuItem).DropDownItems.Add(newItem);
            }
        }

        private void LoadGroupPlugins()
        {
            foreach (Type gPlugin in pluginsManager.GroupPlugins)
            {
                ToolStripItem newItem = new ToolStripMenuItem(gPlugin.Name);
                newItem.Name = "mi" + gPlugin.Name;
                newItem.Click += miAddPluginGroupMember_Click;

                ((msMainMenu.Items["miGroup"] as ToolStripMenuItem).
                    DropDownItems["miAddGroupMember"] as ToolStripMenuItem).DropDownItems.Add(newItem);
            }
        }

        public void LoadUniversityActionPlugins()
        {
            foreach (Type uaPlugin in pluginsManager.UniversityActionPlugins)
            {
                string itemText = ((IUniversityActionPlugin)Activator.CreateInstance(uaPlugin)).ActionText;
                ToolStripItem newItem = new ToolStripMenuItem(itemText);
                newItem.Name = "mi" + uaPlugin.Name;
                newItem.Click += miUniversityActionPlugin_Click;

                (msMainMenu.Items["miUniversity"] as ToolStripMenuItem).DropDownItems.Add(newItem);
            }
        }

        public void LoadGroupActionPlugins()
        {
            foreach (Type gaPlugin in pluginsManager.GroupActionPlugins)
            {
                string itemText = ((IGroupActionPlugin)Activator.CreateInstance(gaPlugin)).ActionText;
                ToolStripItem newItem = new ToolStripMenuItem(itemText);
                newItem.Name = "mi" + gaPlugin.Name;
                newItem.Click += miGroupActionPlugin_Click;

                (msMainMenu.Items["miGroup"] as ToolStripMenuItem).DropDownItems.Add(newItem);
            }
        }

        // ---------------------------------------------------------------------------------------------
        // Настройки пользовательского интерфейса.
        // ---------------------------------------------------------------------------------------------

        private void ManageSettings()
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFileName = userFolder + "\\Lab3.ini";
            if (File.Exists(appFileName))
            {
                LoadUserSettings(appFileName);
            }
            else
            {
                SaveUserSettings(appFileName);
            }
        }

        private void LoadUserSettings(string appFileName)
        {
            INIManager iniManager = new INIManager(appFileName);
           
            miAddUniversityMember.Enabled = bool.Parse(iniManager.
                GetPrivateString("miAddUniversityMember", "Enabled"));
            miRemoveUniversityMember.Enabled = bool.Parse(iniManager.
                GetPrivateString("miRemoveUniversityMember", "Enabled"));

            miAddGroupMember.Enabled = bool.Parse(iniManager.
                GetPrivateString("miAddGroupMember", "Enabled"));
            miRemoveGroupMember.Enabled = bool.Parse(iniManager.
                GetPrivateString("miRemoveGroupMember", "Enabled"));
        }

        private void SaveUserSettings(string appFileName)
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            miAddUniversityMember.Enabled = hasAdministrativeRight ? true : false;
            miRemoveUniversityMember.Enabled = hasAdministrativeRight ? true : false;

            miAddGroupMember.Enabled = hasAdministrativeRight ? true : false;
            miRemoveGroupMember.Enabled = hasAdministrativeRight ? true : false;

            INIManager iniManager = new INIManager(appFileName);
            iniManager.WritePrivateString("miUniversity", "Enabled", miUniversity.Enabled.ToString());
            iniManager.WritePrivateString("miGroup", "Enabled", miGroup.Enabled.ToString());

            iniManager.WritePrivateString("miAddUniversityMember", "Enabled",
                miAddUniversityMember.Enabled.ToString());
            iniManager.WritePrivateString("miRemoveUniversityMember", "Enabled",
                miRemoveUniversityMember.Enabled.ToString());

            iniManager.WritePrivateString("miAddGroupMember", "Enabled",
                miAddGroupMember.Enabled.ToString());
            iniManager.WritePrivateString("miRemoveGroupMember", "Enabled",
                miRemoveGroupMember.Enabled.ToString());
        }

        // ---------------------------------------------------------------------------------------------
        // Обработка событий от элементов интерфейса.
        // ---------------------------------------------------------------------------------------------

        private void miUniversityActionPlugin_Click(object sender, EventArgs e)
        {
            try
            {
                string type = (sender as ToolStripMenuItem).Name.Substring(2);
                IUniversityActionPlugin plugin = (IUniversityActionPlugin)Activator.
                    CreateInstance(pluginsManager[type]);
                taskManager.ApplyUniversityActionPlugin(plugin);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miGroupActionPlugin_Click(object sender, EventArgs e)
        {
            try
            {
                string type = (sender as ToolStripMenuItem).Name.Substring(2);
                IGroupActionPlugin plugin = (IGroupActionPlugin)Activator.
                    CreateInstance(pluginsManager[type]);
                taskManager.ApplyGroupActionPlugin(plugin);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdDataDialog.ShowDialog() == DialogResult.OK)
                {
                    taskManager.SaveData(sfdDataDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miRemoveUniversityMember_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.RemoveSelectedUniversityMember();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void miRemoveGroupMember_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.RemoveSelectedGroupMember();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
