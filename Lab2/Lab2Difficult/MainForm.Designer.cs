namespace Lab2Difficult
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
            this.components = new System.ComponentModel.Container();
            this.tbLastTen = new System.Windows.Forms.TextBox();
            this.tmrNewValue = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbQueue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMinimum = new System.Windows.Forms.TextBox();
            this.tbMaximum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLastTen
            // 
            this.tbLastTen.Location = new System.Drawing.Point(12, 25);
            this.tbLastTen.Name = "tbLastTen";
            this.tbLastTen.Size = new System.Drawing.Size(391, 20);
            this.tbLastTen.TabIndex = 0;
            // 
            // tmrNewValue
            // 
            this.tmrNewValue.Tick += new System.EventHandler(this.tmrNewValue_Tick);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 3000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tbQueue
            // 
            this.tbQueue.Location = new System.Drawing.Point(12, 64);
            this.tbQueue.Name = "tbQueue";
            this.tbQueue.Size = new System.Drawing.Size(391, 20);
            this.tbQueue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Последние 10 значений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Очередь (обновляется каждые 3 секунды):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минимум (обновляется каждые 3 секунды):";
            // 
            // tbMinimum
            // 
            this.tbMinimum.Location = new System.Drawing.Point(12, 103);
            this.tbMinimum.Name = "tbMinimum";
            this.tbMinimum.Size = new System.Drawing.Size(128, 20);
            this.tbMinimum.TabIndex = 5;
            // 
            // tbMaximum
            // 
            this.tbMaximum.Location = new System.Drawing.Point(12, 142);
            this.tbMaximum.Name = "tbMaximum";
            this.tbMaximum.Size = new System.Drawing.Size(128, 20);
            this.tbMaximum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимум (обновляется каждые 3 секунды):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 177);
            this.Controls.Add(this.tbMaximum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMinimum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQueue);
            this.Controls.Add(this.tbLastTen);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 2 (усложненная)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLastTen;
        private System.Windows.Forms.Timer tmrNewValue;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TextBox tbQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMinimum;
        private System.Windows.Forms.TextBox tbMaximum;
        private System.Windows.Forms.Label label4;
    }
}

