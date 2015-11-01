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
            this.group1 = new System.Windows.Forms.Button();
            this.group2 = new System.Windows.Forms.Button();
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
            this.group1.Location = new System.Drawing.Point(1, 25);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(282, 23);
            this.group1.TabIndex = 1;
            this.group1.Text = "1. Бинарные функции.";
            this.group1.UseVisualStyleBackColor = true;
            this.group1.Click += new System.EventHandler(this.group1_Click);
            // 
            // group2
            // 
            this.group2.Location = new System.Drawing.Point(1, 54);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(282, 23);
            this.group2.TabIndex = 2;
            this.group2.Text = "2. Тернарные функции";
            this.group2.UseVisualStyleBackColor = true;
            this.group2.Click += new System.EventHandler(this.group2_Click);
            // 
            // ChooseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
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
        private System.Windows.Forms.Button group1;
        private System.Windows.Forms.Button group2;
    }
}