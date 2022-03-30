namespace Moyneur_Course_Project_Part2
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HeathInsTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsTextBox = new System.Windows.Forms.TextBox();
            this.VacationTextBox = new System.Windows.Forms.TextBox();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.Pay1Label = new System.Windows.Forms.Label();
            this.Pay2Label = new System.Windows.Forms.Label();
            this.Pay1TextBox = new System.Windows.Forms.TextBox();
            this.Pay2TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hire Date";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(49, 413);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(210, 413);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(112, 35);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(158, 20);
            this.FirstNameTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(112, 73);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(158, 20);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(112, 104);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(158, 20);
            this.SSNTextBox.TabIndex = 12;
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(112, 140);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(158, 20);
            this.HireDateTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VacationTextBox);
            this.groupBox1.Controls.Add(this.LifeInsTextBox);
            this.groupBox1.Controls.Add(this.HeathInsTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(49, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 182);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benefits";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Health Insurance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Life Insurance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vacation Days:";
            // 
            // HeathInsTextBox
            // 
            this.HeathInsTextBox.Location = new System.Drawing.Point(126, 23);
            this.HeathInsTextBox.Name = "HeathInsTextBox";
            this.HeathInsTextBox.Size = new System.Drawing.Size(110, 20);
            this.HeathInsTextBox.TabIndex = 3;
            // 
            // LifeInsTextBox
            // 
            this.LifeInsTextBox.Location = new System.Drawing.Point(127, 75);
            this.LifeInsTextBox.Name = "LifeInsTextBox";
            this.LifeInsTextBox.Size = new System.Drawing.Size(109, 20);
            this.LifeInsTextBox.TabIndex = 4;
            // 
            // VacationTextBox
            // 
            this.VacationTextBox.Location = new System.Drawing.Point(126, 126);
            this.VacationTextBox.Name = "VacationTextBox";
            this.VacationTextBox.Size = new System.Drawing.Size(109, 20);
            this.VacationTextBox.TabIndex = 5;
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Checked = true;
            this.HourlyRadioButton.Location = new System.Drawing.Point(402, 38);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(55, 17);
            this.HourlyRadioButton.TabIndex = 15;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Hourly";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            this.HourlyRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(515, 38);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(54, 17);
            this.SalaryRadioButton.TabIndex = 16;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // Pay1Label
            // 
            this.Pay1Label.AutoSize = true;
            this.Pay1Label.Location = new System.Drawing.Point(337, 80);
            this.Pay1Label.Name = "Pay1Label";
            this.Pay1Label.Size = new System.Drawing.Size(63, 13);
            this.Pay1Label.TabIndex = 17;
            this.Pay1Label.Text = "Hourly Rate";
            // 
            // Pay2Label
            // 
            this.Pay2Label.AutoSize = true;
            this.Pay2Label.Location = new System.Drawing.Point(337, 120);
            this.Pay2Label.Name = "Pay2Label";
            this.Pay2Label.Size = new System.Drawing.Size(76, 13);
            this.Pay2Label.TabIndex = 18;
            this.Pay2Label.Text = "Hours Worked";
            // 
            // Pay1TextBox
            // 
            this.Pay1TextBox.Location = new System.Drawing.Point(444, 80);
            this.Pay1TextBox.Name = "Pay1TextBox";
            this.Pay1TextBox.Size = new System.Drawing.Size(98, 20);
            this.Pay1TextBox.TabIndex = 19;
            // 
            // Pay2TextBox
            // 
            this.Pay2TextBox.Location = new System.Drawing.Point(444, 120);
            this.Pay2TextBox.Name = "Pay2TextBox";
            this.Pay2TextBox.Size = new System.Drawing.Size(98, 20);
            this.Pay2TextBox.TabIndex = 20;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 497);
            this.Controls.Add(this.Pay2TextBox);
            this.Controls.Add(this.Pay1TextBox);
            this.Controls.Add(this.Pay2Label);
            this.Controls.Add(this.Pay1Label);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "Employee InputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox SSNTextBox;
        public System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox HeathInsTextBox;
        public System.Windows.Forms.TextBox LifeInsTextBox;
        public System.Windows.Forms.TextBox VacationTextBox;
        public System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label Pay1Label;
        private System.Windows.Forms.Label Pay2Label;
        public System.Windows.Forms.TextBox Pay1TextBox;
        public System.Windows.Forms.TextBox Pay2TextBox;
        public System.Windows.Forms.RadioButton HourlyRadioButton;
        public System.Windows.Forms.RadioButton SalaryRadioButton;
    }
}