namespace LibraryItems
{
    partial class Book_Form
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.loanPeriodTxt = new System.Windows.Forms.TextBox();
            this.copyrightTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.publisherTxt = new System.Windows.Forms.TextBox();
            this.callNumTxt = new System.Windows.Forms.TextBox();
            this.titlelabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.loanLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.callNumLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(216, 12);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 26);
            this.titleTxt.TabIndex = 0;
            // 
            // loanPeriodTxt
            // 
            this.loanPeriodTxt.Location = new System.Drawing.Point(218, 147);
            this.loanPeriodTxt.Name = "loanPeriodTxt";
            this.loanPeriodTxt.Size = new System.Drawing.Size(100, 26);
            this.loanPeriodTxt.TabIndex = 3;
            // 
            // copyrightTxt
            // 
            this.copyrightTxt.Location = new System.Drawing.Point(216, 102);
            this.copyrightTxt.Name = "copyrightTxt";
            this.copyrightTxt.Size = new System.Drawing.Size(100, 26);
            this.copyrightTxt.TabIndex = 2;
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(216, 237);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 26);
            this.authorTxt.TabIndex = 5;
            // 
            // publisherTxt
            // 
            this.publisherTxt.Location = new System.Drawing.Point(216, 57);
            this.publisherTxt.Name = "publisherTxt";
            this.publisherTxt.Size = new System.Drawing.Size(100, 26);
            this.publisherTxt.TabIndex = 1;
            this.publisherTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // callNumTxt
            // 
            this.callNumTxt.Location = new System.Drawing.Point(216, 192);
            this.callNumTxt.Name = "callNumTxt";
            this.callNumTxt.Size = new System.Drawing.Size(100, 26);
            this.callNumTxt.TabIndex = 4;
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(47, 15);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(42, 20);
            this.titlelabel.TabIndex = 6;
            this.titlelabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(47, 240);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(61, 20);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(47, 60);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(78, 20);
            this.publisherLabel.TabIndex = 8;
            this.publisherLabel.Text = "Publisher:";
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Location = new System.Drawing.Point(47, 150);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(98, 20);
            this.loanLabel.TabIndex = 9;
            this.loanLabel.Text = "Loan Period:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(47, 105);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(118, 20);
            this.copyrightLabel.TabIndex = 10;
            this.copyrightLabel.Text = "Copyright Year:";
            // 
            // callNumLabel
            // 
            this.callNumLabel.AutoSize = true;
            this.callNumLabel.Location = new System.Drawing.Point(47, 195);
            this.callNumLabel.Name = "callNumLabel";
            this.callNumLabel.Size = new System.Drawing.Size(99, 20);
            this.callNumLabel.TabIndex = 11;
            this.callNumLabel.Text = "Call Number:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(30, 309);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 47);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(216, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 47);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Validating += new System.ComponentModel.CancelEventHandler(this.BookInputText_Validating);
            this.cancelButton.Validated += new System.EventHandler(this.BookInputText_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 406);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.callNumLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.loanLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.callNumTxt);
            this.Controls.Add(this.publisherTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.copyrightTxt);
            this.Controls.Add(this.loanPeriodTxt);
            this.Controls.Add(this.titleTxt);
            this.Name = "Book_Form";
            this.Text = "Book_Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox loanPeriodTxt;
        private System.Windows.Forms.TextBox copyrightTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox publisherTxt;
        private System.Windows.Forms.TextBox callNumTxt;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label callNumLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}