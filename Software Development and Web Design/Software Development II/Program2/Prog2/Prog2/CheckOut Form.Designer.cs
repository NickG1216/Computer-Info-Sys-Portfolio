namespace LibraryItems
{
    partial class CheckOut_Form
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
            this.itemLabel = new System.Windows.Forms.Label();
            this.patronLabel = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.patronBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(40, 25);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(94, 20);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Select Item:";
            // 
            // patronLabel
            // 
            this.patronLabel.AutoSize = true;
            this.patronLabel.Location = new System.Drawing.Point(40, 121);
            this.patronLabel.Name = "patronLabel";
            this.patronLabel.Size = new System.Drawing.Size(109, 20);
            this.patronLabel.TabIndex = 1;
            this.patronLabel.Text = "Select Patron:";
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(44, 69);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(382, 28);
            this.itemBox.TabIndex = 2;
            this.itemBox.SelectedIndexChanged += new System.EventHandler(this.itemBox_SelectedIndexChanged);
            // 
            // patronBox
            // 
            this.patronBox.FormattingEnabled = true;
            this.patronBox.Location = new System.Drawing.Point(44, 164);
            this.patronBox.Name = "patronBox";
            this.patronBox.Size = new System.Drawing.Size(241, 28);
            this.patronBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(165, 215);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 43);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(299, 215);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 43);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CheckOut_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 283);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.patronBox);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.patronLabel);
            this.Controls.Add(this.itemLabel);
            this.Name = "CheckOut_Form";
            this.Text = "Check Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label patronLabel;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.ComboBox patronBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}