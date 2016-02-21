namespace WindowsFormsExpression
{
    partial class ChooseGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.info = new System.Windows.Forms.Label();
            this.group1 = new System.Windows.Forms.RadioButton();
            this.group2 = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(-2, 9);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(282, 13);
            this.info.TabIndex = 0;
            this.info.Text = "Какую из представленных групп функций выполнять?";
            // 
            // group1
            // 
            this.group1.AutoSize = true;
            this.group1.Location = new System.Drawing.Point(12, 25);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(127, 17);
            this.group1.TabIndex = 1;
            this.group1.TabStop = true;
            this.group1.Text = "Бинарные операции";
            this.group1.UseVisualStyleBackColor = true;
            this.group1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // group2
            // 
            this.group2.AutoSize = true;
            this.group2.Location = new System.Drawing.Point(12, 48);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(133, 17);
            this.group2.TabIndex = 2;
            this.group2.TabStop = true;
            this.group2.Text = "Тернарные операции";
            this.group2.UseVisualStyleBackColor = true;
            this.group2.CheckedChanged += new System.EventHandler(this.group2_CheckedChanged);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(197, 26);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 39);
            this.next.TabIndex = 3;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // ChooseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.next);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseGroupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор группы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.RadioButton group1;
        private System.Windows.Forms.RadioButton group2;
        private System.Windows.Forms.Button next;
    }
}