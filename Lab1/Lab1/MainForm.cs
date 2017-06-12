using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager = null;

        public MainForm()
        {
            try
            {
                InitializeComponent();

                UI ui;
                ui.Groups = lbGroups;
                ui.GroupName = tbGroupName;
                ui.Students = lbStudents;
                ui.StudentName = tbStudentName;
                ui.StudentMiddleName = tbStudentMiddleName;
                ui.StudentSurname = tbStudentSurname;
                ui.Rating = nudRating;
                ui.GroupHead = cbHead;
                taskManager = new TaskManager(ui);

                #if DEBUG
                taskManager.LoadData(@"C:\Users\Денис\Downloads\groups.xml");
                #endif
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void miOpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ofdOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    taskManager.LoadData(ofdOpenDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }


        private void miSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    taskManager.SaveDate(sfdSaveDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.AddGroup("Новая Группа");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }


        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.RemoveSelectedGroup();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void btnAddStudent_Click(object sender, System.EventArgs e)
        {
            try
            {
                taskManager.AddStudent("Студент", "", "Новый");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.RemoveSelectedStudent();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void btnEditStudent_Click(object sender, System.EventArgs e)
        {
            EnableStudentChanges();
        }

        private void btnApplyStudentChanges_Click(object sender, System.EventArgs e)
        {
            try
            {
                taskManager.EditStudent(tbStudentName.Text, tbStudentMiddleName.Text,
                    tbStudentSurname.Text, (byte)nudRating.Value, cbHead.Checked);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK);
            }
            finally
            {
                DisableStudentChanges();
            }
        }

        private void EnableStudentChanges()
        {
            tbStudentName.Enabled = true;
            tbStudentMiddleName.Enabled = true;
            tbStudentSurname.Enabled = true;
            nudRating.Enabled = true;
            btnApplyStudentChanges.Enabled = true;
            cbHead.Enabled = true;
        }

        private void DisableStudentChanges()
        {
            tbStudentName.Enabled = false;
            tbStudentMiddleName.Enabled = false;
            tbStudentSurname.Enabled = false;
            nudRating.Enabled = false;
            btnApplyStudentChanges.Enabled = false;
            cbHead.Enabled = false;
        }

        private void miUndoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            taskManager.UndoLastChange();
        }

        private void miRedoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            taskManager.RedoLastChange();
        }

        private void tbGroupName_DoubleClick(object sender, EventArgs e)
        {
            if (!tbGroupName.ReadOnly)
            {
                taskManager.RenameSelectedGroup(tbGroupName.Text);
            }
        }
    }
}
