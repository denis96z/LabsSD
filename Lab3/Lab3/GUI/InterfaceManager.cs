using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Lab3Plugins;
using Lab3Plugins.Data;

namespace Lab3.GUI
{
    struct UI
    {
        public TreeView University;
    }

    class InterfaceManager
    {
        private UI ui;
        public University University { get; set; }

        public InterfaceManager(UI ui, University university)
        {
            this.ui = ui;
            this.ui.University.AfterSelect += OnSelectedChanged;
            this.University = university;
        }

        public void UpdateUI()
        {
            ui.University.Nodes.Clear();
            foreach (var uMember in University)
            {
                if (uMember is IPerson)
                {
                    IPerson uPersonMember = uMember as IPerson;
                    TreeNode uPersonMemberNode =
                        new TreeNode(uPersonMember.ToString());
                    foreach (var attribute in uPersonMember)
                    {
                        uPersonMemberNode.Nodes.
                            Add(new TreeNode(attribute.Text + ": " + attribute.Value.ToString()));
                    }
                    ui.University.Nodes.Add(uPersonMemberNode);
                }
                else if (uMember is Group)
                {
                    Group uGroupMember = uMember as Group;
                    TreeNode uGroupMemberNode =
                        new TreeNode(uGroupMember.ToString());
                    foreach (var gMember in uGroupMember)
                    {
                        TreeNode gMemberNode = new TreeNode(gMember.ToString());
                        foreach (var attribute in gMember)
                        {
                            gMemberNode.Nodes.
                                Add(new TreeNode(attribute.Text + ": " + attribute.Value.ToString()));
                        }
                        uGroupMemberNode.Nodes.Add(gMemberNode);
                    }
                    ui.University.Nodes.Add(uGroupMemberNode);
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private void OnSelectedChanged(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = ui.University.SelectedNode;
            if (selected == null)
            {
                UniversityMemberIndex = -1;
                GroupMemberIndex = -1;
                UniversityMemberAttributeIndex = -1;
                GroupMemberAttributeIndex = -1;
                return;
            }

            TreeNode selectedParent = selected.Parent;
            if (selectedParent == null)
            {
                UniversityMemberIndex = selected.Index;
                GroupMemberIndex = -1;
                UniversityMemberAttributeIndex = -1;
                GroupMemberAttributeIndex = -1;
                return;
            }

            TreeNode selectedPreParent = selectedParent.Parent;
            if (selectedPreParent == null)
            {
                UniversityMemberIndex = selectedParent.Index;
                if (University[UniversityMemberIndex] is IPerson)
                {
                    UniversityMemberAttributeIndex = selected.Index;
                    GroupMemberIndex = -1;
                }
                else
                {
                    UniversityMemberAttributeIndex = -1;
                    GroupMemberIndex = selected.Index;
                }
                return;
            }

            UniversityMemberIndex = selectedPreParent.Index;
            GroupMemberIndex = selectedParent.Index;
            UniversityMemberAttributeIndex = -1;
            GroupMemberAttributeIndex = selected.Index;           
        }

        public string ReadAttribute(string attributeName)
        {
            return Interaction.InputBox(attributeName + ":", "Изменение данных");
        }

        public int UniversityMemberIndex { get; private set; }
        public int GroupMemberIndex { get; private set; }
        public int UniversityMemberAttributeIndex { get; private set; }
        public int GroupMemberAttributeIndex { get; private set; }

        public bool UniversityMemberSelected { get { return UniversityMemberIndex != -1; } }
        public bool GroupMemberSelected { get { return GroupMemberIndex != -1; } }
        public bool UniversityMemberAttributeSelected { get { return UniversityMemberAttributeIndex != -1; } }
        public bool GroupMemberAttributeSelected { get { return GroupMemberAttributeIndex != -1; } }
    }
}
