namespace WinApp
{
    partial class frmDialogBirthday
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
            this.btnGetAge = new System.Windows.Forms.Button();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAge
            // 
            this.btnGetAge.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGetAge.Location = new System.Drawing.Point(91, 61);
            this.btnGetAge.Name = "btnGetAge";
            this.btnGetAge.Size = new System.Drawing.Size(67, 28);
            this.btnGetAge.TabIndex = 0;
            this.btnGetAge.Text = "OK";
            this.btnGetAge.UseVisualStyleBackColor = true;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(35, 21);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(187, 20);
            this.txtBirthday.TabIndex = 1;
            // 
            // frmDialogBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 101);
            this.ControlBox = false;
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.btnGetAge);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frmDialogBirthday";
            this.Text = "Please Enter Birth Year";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGetAge;
        public System.Windows.Forms.TextBox txtBirthday;
    }
}