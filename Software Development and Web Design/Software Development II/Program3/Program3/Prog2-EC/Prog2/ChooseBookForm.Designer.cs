namespace LibraryItems
{
    partial class ChooseBookForm
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
            this.bookLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.itemCbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // bookLbl
            // 
            this.bookLbl.AutoSize = true;
            this.bookLbl.Location = new System.Drawing.Point(25, 26);
            this.bookLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookLbl.Name = "bookLbl";
            this.bookLbl.Size = new System.Drawing.Size(99, 20);
            this.bookLbl.TabIndex = 28;
            this.bookLbl.Text = "Select Book:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(226, 208);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(103, 208);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 35);
            this.okBtn.TabIndex = 26;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // itemCbo
            // 
            this.itemCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCbo.FormattingEnabled = true;
            this.itemCbo.Location = new System.Drawing.Point(29, 95);
            this.itemCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemCbo.Name = "itemCbo";
            this.itemCbo.Size = new System.Drawing.Size(309, 28);
            this.itemCbo.TabIndex = 29;
            this.itemCbo.Validating += new System.ComponentModel.CancelEventHandler(this.itemCbo_Validating);
            this.itemCbo.Validated += new System.EventHandler(this.itemCbo_Validated);
            // 
            // ChooseBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 269);
            this.Controls.Add(this.itemCbo);
            this.Controls.Add(this.bookLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Name = "ChooseBookForm";
            this.Text = "Choose Book";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.itemCbo_Validating);
            this.Validated += new System.EventHandler(this.itemCbo_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox itemCbo;
    }
}