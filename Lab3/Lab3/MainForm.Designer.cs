namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvUniversity = new System.Windows.Forms.TreeView();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.miUniversity = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddUniversityMember = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveUniversityMember = new System.Windows.Forms.ToolStripMenuItem();
            this.miGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddGroupMember = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveGroupMember = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfdDataDialog = new System.Windows.Forms.SaveFileDialog();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvUniversity
            // 
            this.tvUniversity.Location = new System.Drawing.Point(12, 27);
            this.tvUniversity.Name = "tvUniversity";
            this.tvUniversity.Size = new System.Drawing.Size(560, 322);
            this.tvUniversity.TabIndex = 0;
            this.tvUniversity.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvUniversity_MouseDoubleClick);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEdit,
            this.miUniversity,
            this.miGroup});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(584, 24);
            this.msMainMenu.TabIndex = 1;
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miSave,
            this.toolStripMenuItem1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(152, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(152, 22);
            this.miSave.Text = "Сохранить";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "Выход";
            // 
            // miEdit
            // 
            this.miEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUndo,
            this.miRedo});
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(59, 20);
            this.miEdit.Text = "Правка";
            // 
            // miUndo
            // 
            this.miUndo.Name = "miUndo";
            this.miUndo.Size = new System.Drawing.Size(152, 22);
            this.miUndo.Text = "Отменить";
            this.miUndo.Click += new System.EventHandler(this.miUndo_Click);
            // 
            // miRedo
            // 
            this.miRedo.Name = "miRedo";
            this.miRedo.Size = new System.Drawing.Size(152, 22);
            this.miRedo.Text = "Вернуть";
            this.miRedo.Click += new System.EventHandler(this.miRedo_Click);
            // 
            // miUniversity
            // 
            this.miUniversity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddUniversityMember,
            this.miRemoveUniversityMember});
            this.miUniversity.Name = "miUniversity";
            this.miUniversity.Size = new System.Drawing.Size(88, 20);
            this.miUniversity.Text = "Университет";
            // 
            // miAddUniversityMember
            // 
            this.miAddUniversityMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddGroup});
            this.miAddUniversityMember.Name = "miAddUniversityMember";
            this.miAddUniversityMember.Size = new System.Drawing.Size(183, 22);
            this.miAddUniversityMember.Text = "Добавить";
            // 
            // miAddGroup
            // 
            this.miAddGroup.Name = "miAddGroup";
            this.miAddGroup.Size = new System.Drawing.Size(152, 22);
            this.miAddGroup.Text = "Группа";
            this.miAddGroup.Click += new System.EventHandler(this.miAddGroup_Click);
            // 
            // miRemoveUniversityMember
            // 
            this.miRemoveUniversityMember.Name = "miRemoveUniversityMember";
            this.miRemoveUniversityMember.Size = new System.Drawing.Size(183, 22);
            this.miRemoveUniversityMember.Text = "Удалить выбранное";
            this.miRemoveUniversityMember.Click += new System.EventHandler(this.miRemoveUniversityMember_Click);
            // 
            // miGroup
            // 
            this.miGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddGroupMember,
            this.miRemoveGroupMember});
            this.miGroup.Name = "miGroup";
            this.miGroup.Size = new System.Drawing.Size(58, 20);
            this.miGroup.Text = "Группа";
            // 
            // miAddGroupMember
            // 
            this.miAddGroupMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddStudent});
            this.miAddGroupMember.Name = "miAddGroupMember";
            this.miAddGroupMember.Size = new System.Drawing.Size(183, 22);
            this.miAddGroupMember.Text = "Добавить";
            // 
            // miAddStudent
            // 
            this.miAddStudent.Name = "miAddStudent";
            this.miAddStudent.Size = new System.Drawing.Size(152, 22);
            this.miAddStudent.Text = "Студент";
            this.miAddStudent.Click += new System.EventHandler(this.miAddStudent_Click);
            // 
            // miRemoveGroupMember
            // 
            this.miRemoveGroupMember.Name = "miRemoveGroupMember";
            this.miRemoveGroupMember.Size = new System.Drawing.Size(183, 22);
            this.miRemoveGroupMember.Text = "Удалить выбранное";
            this.miRemoveGroupMember.Click += new System.EventHandler(this.miRemoveGroupMember_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tvUniversity);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvUniversity;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miUniversity;
        private System.Windows.Forms.ToolStripMenuItem miGroup;
        private System.Windows.Forms.ToolStripMenuItem miAddUniversityMember;
        private System.Windows.Forms.ToolStripMenuItem miAddGroup;
        private System.Windows.Forms.ToolStripMenuItem miRemoveUniversityMember;
        private System.Windows.Forms.ToolStripMenuItem miAddGroupMember;
        private System.Windows.Forms.ToolStripMenuItem miAddStudent;
        private System.Windows.Forms.ToolStripMenuItem miRemoveGroupMember;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miUndo;
        private System.Windows.Forms.ToolStripMenuItem miRedo;
        private System.Windows.Forms.OpenFileDialog ofdDataDialog;
        private System.Windows.Forms.SaveFileDialog sfdDataDialog;
    }
}

