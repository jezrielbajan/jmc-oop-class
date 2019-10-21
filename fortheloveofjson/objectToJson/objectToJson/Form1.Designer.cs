namespace objectToJson
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertTOJson = new System.Windows.Forms.Button();
            this.lstStudent = new System.Windows.Forms.ListView();
            this.txtJsonResult = new System.Windows.Forms.TextBox();
            this.colStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(136, 27);
            this.txtStudentID.MaxLength = 5;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(601, 20);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.Click += new System.EventHandler(this.txtStudentID_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(136, 66);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(601, 20);
            this.txtLastname.TabIndex = 0;
            this.txtLastname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(136, 104);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(601, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FirstName";
            // 
            // btnConvertTOJson
            // 
            this.btnConvertTOJson.Location = new System.Drawing.Point(136, 140);
            this.btnConvertTOJson.Name = "btnConvertTOJson";
            this.btnConvertTOJson.Size = new System.Drawing.Size(75, 23);
            this.btnConvertTOJson.TabIndex = 3;
            this.btnConvertTOJson.Text = "TO JSON";
            this.btnConvertTOJson.UseVisualStyleBackColor = true;
            this.btnConvertTOJson.Click += new System.EventHandler(this.btnConvertTOJson_Click);
            // 
            // lstStudent
            // 
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStudentID,
            this.colLastName,
            this.colFirstName});
            this.lstStudent.HideSelection = false;
            this.lstStudent.Location = new System.Drawing.Point(46, 327);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(691, 148);
            this.lstStudent.TabIndex = 4;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            // 
            // txtJsonResult
            // 
            this.txtJsonResult.Location = new System.Drawing.Point(46, 204);
            this.txtJsonResult.Multiline = true;
            this.txtJsonResult.Name = "txtJsonResult";
            this.txtJsonResult.Size = new System.Drawing.Size(691, 101);
            this.txtJsonResult.TabIndex = 5;
            // 
            // colStudentID
            // 
            this.colStudentID.Text = "StudentID";
            this.colStudentID.Width = 148;
            // 
            // colLastName
            // 
            this.colLastName.Text = "LastName";
            this.colLastName.Width = 176;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "FirstName";
            this.colFirstName.Width = 253;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 543);
            this.Controls.Add(this.txtJsonResult);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.btnConvertTOJson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertTOJson;
        private System.Windows.Forms.TextBox txtJsonResult;
        private System.Windows.Forms.ColumnHeader colStudentID;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colFirstName;
        protected internal System.Windows.Forms.ListView lstStudent;
    }
}

