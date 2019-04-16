namespace LibraryItems
{
    partial class Patron_Form
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
            this.components = new System.ComponentModel.Container();
            this.patronNameTextBox = new System.Windows.Forms.TextBox();
            this.patronNameLabel = new System.Windows.Forms.Label();
            this.patronIDLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.patronIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // patronNameTextBox
            // 
            this.patronNameTextBox.Location = new System.Drawing.Point(127, 44);
            this.patronNameTextBox.Name = "patronNameTextBox";
            this.patronNameTextBox.Size = new System.Drawing.Size(153, 26);
            this.patronNameTextBox.TabIndex = 0;
            this.patronNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PatronText_Validating);
            this.patronNameTextBox.Validated += new System.EventHandler(this.PatronText_Validated);
            // 
            // patronNameLabel
            // 
            this.patronNameLabel.AutoSize = true;
            this.patronNameLabel.Location = new System.Drawing.Point(21, 47);
            this.patronNameLabel.Name = "patronNameLabel";
            this.patronNameLabel.Size = new System.Drawing.Size(55, 20);
            this.patronNameLabel.TabIndex = 2;
            this.patronNameLabel.Text = "Name:";
            // 
            // patronIDLabel
            // 
            this.patronIDLabel.AutoSize = true;
            this.patronIDLabel.Location = new System.Drawing.Point(21, 109);
            this.patronIDLabel.Name = "patronIDLabel";
            this.patronIDLabel.Size = new System.Drawing.Size(30, 20);
            this.patronIDLabel.TabIndex = 3;
            this.patronIDLabel.Text = "ID:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(25, 185);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 37);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(188, 185);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 37);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // patronIDTextBox
            // 
            this.patronIDTextBox.Location = new System.Drawing.Point(127, 106);
            this.patronIDTextBox.Name = "patronIDTextBox";
            this.patronIDTextBox.Size = new System.Drawing.Size(153, 26);
            this.patronIDTextBox.TabIndex = 4;
            // 
            // Patron_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 272);
            this.Controls.Add(this.patronIDTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.patronIDLabel);
            this.Controls.Add(this.patronNameLabel);
            this.Controls.Add(this.patronNameTextBox);
            this.Name = "Patron_Form";
            this.Text = "Patron_Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.PatronText_Validating);
            this.Validated += new System.EventHandler(this.PatronText_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronNameTextBox;
        private System.Windows.Forms.Label patronNameLabel;
        private System.Windows.Forms.Label patronIDLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox patronIDTextBox;
    }
}