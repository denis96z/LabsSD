namespace Lab1
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.cbHead = new System.Windows.Forms.CheckBox();
            this.btnApplyStudentChanges = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.lblStudentRating = new System.Windows.Forms.Label();
            this.tbStudentMiddleName = new System.Windows.Forms.TextBox();
            this.lblStudentMiddleName = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.gbGroupInfo = new System.Windows.Forms.GroupBox();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.ofdOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbUniversity = new System.Windows.Forms.GroupBox();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.msMainMenu.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.gbGroupInfo.SuspendLayout();
            this.gbUniversity.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileToolStripMenuItem,
            this.miEditToolStripMenuItem,
            this.miHelpToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(784, 24);
            this.msMainMenu.TabIndex = 1;
            // 
            // miFileToolStripMenuItem
            // 
            this.miFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenToolStripMenuItem,
            this.miSaveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.miExitToolStripMenuItem});
            this.miFileToolStripMenuItem.Name = "miFileToolStripMenuItem";
            this.miFileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.miFileToolStripMenuItem.Text = "Файл";
            // 
            // miOpenToolStripMenuItem
            // 
            this.miOpenToolStripMenuItem.Name = "miOpenToolStripMenuItem";
            this.miOpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.miOpenToolStripMenuItem.Text = "Открыть";
            this.miOpenToolStripMenuItem.Click += new System.EventHandler(this.miOpenToolStripMenuItem_Click);
            // 
            // miSaveAsToolStripMenuItem
            // 
            this.miSaveAsToolStripMenuItem.Name = "miSaveAsToolStripMenuItem";
            this.miSaveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.miSaveAsToolStripMenuItem.Text = "Сохранить как...";
            this.miSaveAsToolStripMenuItem.Click += new System.EventHandler(this.miSaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // miExitToolStripMenuItem
            // 
            this.miExitToolStripMenuItem.Name = "miExitToolStripMenuItem";
            this.miExitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.miExitToolStripMenuItem.Text = "Выход";
            // 
            // miEditToolStripMenuItem
            // 
            this.miEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUndoToolStripMenuItem,
            this.miRedoToolStripMenuItem});
            this.miEditToolStripMenuItem.Name = "miEditToolStripMenuItem";
            this.miEditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.miEditToolStripMenuItem.Text = "Правка";
            // 
            // miUndoToolStripMenuItem
            // 
            this.miUndoToolStripMenuItem.Name = "miUndoToolStripMenuItem";
            this.miUndoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.miUndoToolStripMenuItem.Text = "Отменить";
            this.miUndoToolStripMenuItem.Click += new System.EventHandler(this.miUndoToolStripMenuItem_Click);
            // 
            // miRedoToolStripMenuItem
            // 
            this.miRedoToolStripMenuItem.Name = "miRedoToolStripMenuItem";
            this.miRedoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.miRedoToolStripMenuItem.Text = "Вернуть";
            this.miRedoToolStripMenuItem.Click += new System.EventHandler(this.miRedoToolStripMenuItem_Click);
            // 
            // miHelpToolStripMenuItem
            // 
            this.miHelpToolStripMenuItem.Name = "miHelpToolStripMenuItem";
            this.miHelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.miHelpToolStripMenuItem.Text = "Справка";
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.nudRating);
            this.gbStudentInfo.Controls.Add(this.cbHead);
            this.gbStudentInfo.Controls.Add(this.btnApplyStudentChanges);
            this.gbStudentInfo.Controls.Add(this.btnEditStudent);
            this.gbStudentInfo.Controls.Add(this.lblStudentRating);
            this.gbStudentInfo.Controls.Add(this.tbStudentMiddleName);
            this.gbStudentInfo.Controls.Add(this.lblStudentMiddleName);
            this.gbStudentInfo.Controls.Add(this.tbStudentName);
            this.gbStudentInfo.Controls.Add(this.lblStudentName);
            this.gbStudentInfo.Controls.Add(this.tbStudentSurname);
            this.gbStudentInfo.Controls.Add(this.lblStudentSurname);
            this.gbStudentInfo.Location = new System.Drawing.Point(381, 326);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(391, 223);
            this.gbStudentInfo.TabIndex = 2;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студент";
            // 
            // nudRating
            // 
            this.nudRating.Enabled = false;
            this.nudRating.Location = new System.Drawing.Point(9, 151);
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(56, 20);
            this.nudRating.TabIndex = 11;
            // 
            // cbHead
            // 
            this.cbHead.AutoSize = true;
            this.cbHead.Enabled = false;
            this.cbHead.Location = new System.Drawing.Point(9, 177);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(73, 17);
            this.cbHead.TabIndex = 10;
            this.cbHead.Text = "Староста";
            this.cbHead.UseVisualStyleBackColor = true;
            // 
            // btnApplyStudentChanges
            // 
            this.btnApplyStudentChanges.Enabled = false;
            this.btnApplyStudentChanges.Location = new System.Drawing.Point(310, 194);
            this.btnApplyStudentChanges.Name = "btnApplyStudentChanges";
            this.btnApplyStudentChanges.Size = new System.Drawing.Size(75, 23);
            this.btnApplyStudentChanges.TabIndex = 9;
            this.btnApplyStudentChanges.Text = "Применить";
            this.btnApplyStudentChanges.UseVisualStyleBackColor = true;
            this.btnApplyStudentChanges.Click += new System.EventHandler(this.btnApplyStudentChanges_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(229, 194);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudent.TabIndex = 8;
            this.btnEditStudent.Text = "Изменить";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // lblStudentRating
            // 
            this.lblStudentRating.AutoSize = true;
            this.lblStudentRating.Location = new System.Drawing.Point(6, 135);
            this.lblStudentRating.Name = "lblStudentRating";
            this.lblStudentRating.Size = new System.Drawing.Size(51, 13);
            this.lblStudentRating.TabIndex = 7;
            this.lblStudentRating.Text = "Рейтинг:";
            // 
            // tbStudentMiddleName
            // 
            this.tbStudentMiddleName.Enabled = false;
            this.tbStudentMiddleName.Location = new System.Drawing.Point(9, 112);
            this.tbStudentMiddleName.Name = "tbStudentMiddleName";
            this.tbStudentMiddleName.Size = new System.Drawing.Size(295, 20);
            this.tbStudentMiddleName.TabIndex = 5;
            // 
            // lblStudentMiddleName
            // 
            this.lblStudentMiddleName.AutoSize = true;
            this.lblStudentMiddleName.Location = new System.Drawing.Point(6, 95);
            this.lblStudentMiddleName.Name = "lblStudentMiddleName";
            this.lblStudentMiddleName.Size = new System.Drawing.Size(57, 13);
            this.lblStudentMiddleName.TabIndex = 4;
            this.lblStudentMiddleName.Text = "Отчество:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Enabled = false;
            this.tbStudentName.Location = new System.Drawing.Point(9, 72);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(295, 20);
            this.tbStudentName.TabIndex = 3;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(6, 55);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(32, 13);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Имя:";
            // 
            // tbStudentSurname
            // 
            this.tbStudentSurname.Enabled = false;
            this.tbStudentSurname.Location = new System.Drawing.Point(9, 32);
            this.tbStudentSurname.Name = "tbStudentSurname";
            this.tbStudentSurname.Size = new System.Drawing.Size(295, 20);
            this.tbStudentSurname.TabIndex = 1;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(6, 16);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(59, 13);
            this.lblStudentSurname.TabIndex = 0;
            this.lblStudentSurname.Text = "Фамилия:";
            // 
            // gbGroupInfo
            // 
            this.gbGroupInfo.Controls.Add(this.lbStudents);
            this.gbGroupInfo.Controls.Add(this.btnAddStudent);
            this.gbGroupInfo.Controls.Add(this.btnRemoveStudent);
            this.gbGroupInfo.Controls.Add(this.tbGroupName);
            this.gbGroupInfo.Location = new System.Drawing.Point(381, 27);
            this.gbGroupInfo.Name = "gbGroupInfo";
            this.gbGroupInfo.Size = new System.Drawing.Size(391, 293);
            this.gbGroupInfo.TabIndex = 3;
            this.gbGroupInfo.TabStop = false;
            this.gbGroupInfo.Text = "Группа";
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(9, 45);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(295, 238);
            this.lbStudents.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(310, 231);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(310, 260);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Удалить";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(9, 19);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.ReadOnly = true;
            this.tbGroupName.Size = new System.Drawing.Size(295, 20);
            this.tbGroupName.TabIndex = 0;
            this.tbGroupName.DoubleClick += new System.EventHandler(this.tbGroupName_DoubleClick);
            // 
            // gbUniversity
            // 
            this.gbUniversity.Controls.Add(this.lbGroups);
            this.gbUniversity.Controls.Add(this.btnAddGroup);
            this.gbUniversity.Controls.Add(this.btnRemoveGroup);
            this.gbUniversity.Location = new System.Drawing.Point(12, 27);
            this.gbUniversity.Name = "gbUniversity";
            this.gbUniversity.Size = new System.Drawing.Size(363, 522);
            this.gbUniversity.TabIndex = 4;
            this.gbUniversity.TabStop = false;
            this.gbUniversity.Text = "Группы:";
            // 
            // lbGroups
            // 
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.Location = new System.Drawing.Point(6, 19);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(270, 498);
            this.lbGroups.TabIndex = 7;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(282, 465);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 6;
            this.btnAddGroup.Text = "Добавить";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Location = new System.Drawing.Point(282, 494);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGroup.TabIndex = 5;
            this.btnRemoveGroup.Text = "Удалить";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbUniversity);
            this.Controls.Add(this.gbGroupInfo);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.gbGroupInfo.ResumeLayout(false);
            this.gbGroupInfo.PerformLayout();
            this.gbUniversity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miUndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRedoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.GroupBox gbGroupInfo;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox tbStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label lblStudentMiddleName;
        private System.Windows.Forms.TextBox tbStudentMiddleName;
        private System.Windows.Forms.Label lblStudentRating;
        private System.Windows.Forms.Button btnApplyStudentChanges;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.OpenFileDialog ofdOpenDialog;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.CheckBox cbHead;
        private System.Windows.Forms.GroupBox gbUniversity;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
    }
}

