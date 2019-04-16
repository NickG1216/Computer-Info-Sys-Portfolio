namespace LibraryItems
{
    partial class ChoosePatronForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.patronCbo = new System.Windows.Forms.ComboBox();
            this.patronLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(223, 189);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(100, 189);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 35);
            this.okBtn.TabIndex = 22;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // patronCbo
            // 
            this.patronCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronCbo.FormattingEnabled = true;
            this.patronCbo.Location = new System.Drawing.Point(95, 74);
            this.patronCbo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patronCbo.Name = "patronCbo";
            this.patronCbo.Size = new System.Drawing.Size(205, 28);
            this.patronCbo.TabIndex = 21;
            this.patronCbo.Validating += new System.ComponentModel.CancelEventHandler(this.patronCbo_Validating);
            this.patronCbo.Validated += new System.EventHandler(this.patronCbo_Validated);
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(22, 7);
            this.patronLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(109, 20);
            this.patronLbl.TabIndex = 24;
            this.patronLbl.Text = "Select Patron:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChoosePatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 257);
            this.Controls.Add(this.patronLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronCbo);
            this.Name = "ChoosePatronForm";
            this.Text = "Choose Patron";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.patronCbo_Validating);
            this.Validated += new System.EventHandler(this.patronCbo_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ComboBox patronCbo;
        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}