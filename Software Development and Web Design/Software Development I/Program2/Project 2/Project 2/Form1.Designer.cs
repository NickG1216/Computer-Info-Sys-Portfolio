namespace Project_2
{
    partial class Form1
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
            this.okButton = new System.Windows.Forms.Button();
            this.freshmanRButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRButton = new System.Windows.Forms.RadioButton();
            this.juniorRButton = new System.Windows.Forms.RadioButton();
            this.seniorRButton = new System.Windows.Forms.RadioButton();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.classStandingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(225, 355);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 40);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // freshmanRButton
            // 
            this.freshmanRButton.AutoSize = true;
            this.freshmanRButton.Location = new System.Drawing.Point(49, 141);
            this.freshmanRButton.Name = "freshmanRButton";
            this.freshmanRButton.Size = new System.Drawing.Size(106, 24);
            this.freshmanRButton.TabIndex = 1;
            this.freshmanRButton.TabStop = true;
            this.freshmanRButton.Text = "Freshman";
            this.freshmanRButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRButton
            // 
            this.sophomoreRButton.AutoSize = true;
            this.sophomoreRButton.Location = new System.Drawing.Point(49, 183);
            this.sophomoreRButton.Name = "sophomoreRButton";
            this.sophomoreRButton.Size = new System.Drawing.Size(117, 24);
            this.sophomoreRButton.TabIndex = 2;
            this.sophomoreRButton.TabStop = true;
            this.sophomoreRButton.Text = "Sophomore";
            this.sophomoreRButton.UseVisualStyleBackColor = true;
            // 
            // juniorRButton
            // 
            this.juniorRButton.AutoSize = true;
            this.juniorRButton.Location = new System.Drawing.Point(49, 225);
            this.juniorRButton.Name = "juniorRButton";
            this.juniorRButton.Size = new System.Drawing.Size(77, 24);
            this.juniorRButton.TabIndex = 3;
            this.juniorRButton.TabStop = true;
            this.juniorRButton.Text = "Junior";
            this.juniorRButton.UseVisualStyleBackColor = true;
            // 
            // seniorRButton
            // 
            this.seniorRButton.AutoSize = true;
            this.seniorRButton.Location = new System.Drawing.Point(49, 268);
            this.seniorRButton.Name = "seniorRButton";
            this.seniorRButton.Size = new System.Drawing.Size(80, 24);
            this.seniorRButton.TabIndex = 4;
            this.seniorRButton.TabStop = true;
            this.seniorRButton.Text = "Senior";
            this.seniorRButton.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(45, 43);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(274, 20);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Enter the first letter of your last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(349, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // classStandingLabel
            // 
            this.classStandingLabel.AutoSize = true;
            this.classStandingLabel.Location = new System.Drawing.Point(172, 112);
            this.classStandingLabel.Name = "classStandingLabel";
            this.classStandingLabel.Size = new System.Drawing.Size(217, 20);
            this.classStandingLabel.TabIndex = 7;
            this.classStandingLabel.Text = "Choose Your Class Standing:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 461);
            this.Controls.Add(this.classStandingLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.seniorRButton);
            this.Controls.Add(this.juniorRButton);
            this.Controls.Add(this.sophomoreRButton);
            this.Controls.Add(this.freshmanRButton);
            this.Controls.Add(this.okButton);
            this.Name = "Form1";
            this.Text = "Project 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton freshmanRButton;
        private System.Windows.Forms.RadioButton sophomoreRButton;
        private System.Windows.Forms.RadioButton juniorRButton;
        private System.Windows.Forms.RadioButton seniorRButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label classStandingLabel;
    }
}

