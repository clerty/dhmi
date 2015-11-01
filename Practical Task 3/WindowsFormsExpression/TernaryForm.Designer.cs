namespace WindowsFormsExpression
{
    partial class TernaryForm
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
            this.a = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.aField = new System.Windows.Forms.TextBox();
            this.xField = new System.Windows.Forms.TextBox();
            this.yField = new System.Windows.Forms.TextBox();
            this.zField = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(16, 15);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(22, 13);
            this.a.TabIndex = 0;
            this.a.Text = "a =";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(16, 37);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(21, 13);
            this.x.TabIndex = 1;
            this.x.Text = "x =";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(16, 59);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(21, 13);
            this.y.TabIndex = 2;
            this.y.Text = "y =";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(16, 81);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(21, 13);
            this.z.TabIndex = 3;
            this.z.Text = "z =";
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(43, 12);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(100, 20);
            this.aField.TabIndex = 4;
            this.aField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.aField_KeyUp);
            // 
            // xField
            // 
            this.xField.Location = new System.Drawing.Point(43, 34);
            this.xField.Name = "xField";
            this.xField.Size = new System.Drawing.Size(100, 20);
            this.xField.TabIndex = 5;
            this.xField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.xField_KeyUp);
            // 
            // yField
            // 
            this.yField.Location = new System.Drawing.Point(43, 56);
            this.yField.Name = "yField";
            this.yField.Size = new System.Drawing.Size(100, 20);
            this.yField.TabIndex = 6;
            this.yField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.yField_KeyUp);
            // 
            // zField
            // 
            this.zField.Location = new System.Drawing.Point(43, 78);
            this.zField.Name = "zField";
            this.zField.ReadOnly = true;
            this.zField.Size = new System.Drawing.Size(100, 20);
            this.zField.TabIndex = 7;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(149, 15);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 35);
            this.calc.TabIndex = 8;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(149, 59);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 35);
            this.exit.TabIndex = 9;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TernaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 113);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.zField);
            this.Controls.Add(this.yField);
            this.Controls.Add(this.xField);
            this.Controls.Add(this.aField);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TernaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s calculate!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.TextBox aField;
        private System.Windows.Forms.TextBox xField;
        private System.Windows.Forms.TextBox yField;
        private System.Windows.Forms.TextBox zField;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button exit;
        
        
    }
}