namespace login_of__student
{
    partial class New_Student
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
            this.button1 = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textconfirm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiofemale = new System.Windows.Forms.RadioButton();
            this.radiomale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBatch = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(196, 34);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 5;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(196, 79);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 6;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(196, 126);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 7;
            // 
            // textconfirm
            // 
            this.textconfirm.Location = new System.Drawing.Point(196, 173);
            this.textconfirm.Name = "textconfirm";
            this.textconfirm.PasswordChar = '*';
            this.textconfirm.Size = new System.Drawing.Size(100, 20);
            this.textconfirm.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiofemale);
            this.groupBox1.Controls.Add(this.radiomale);
            this.groupBox1.Location = new System.Drawing.Point(134, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radiofemale
            // 
            this.radiofemale.AutoSize = true;
            this.radiofemale.Location = new System.Drawing.Point(102, 19);
            this.radiofemale.Name = "radiofemale";
            this.radiofemale.Size = new System.Drawing.Size(56, 17);
            this.radiofemale.TabIndex = 1;
            this.radiofemale.TabStop = true;
            this.radiofemale.Text = "female";
            this.radiofemale.UseVisualStyleBackColor = true;
            // 
            // radiomale
            // 
            this.radiomale.AutoSize = true;
            this.radiomale.Location = new System.Drawing.Point(29, 19);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(47, 17);
            this.radiomale.TabIndex = 0;
            this.radiomale.TabStop = true;
            this.radiomale.Text = "male";
            this.radiomale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Batch";
            // 
            // comboBatch
            // 
            this.comboBatch.FormattingEnabled = true;
            this.comboBatch.Items.AddRange(new object[] {
            "25A",
            "25B",
            "25C",
            "25D"});
            this.comboBatch.Location = new System.Drawing.Point(196, 278);
            this.comboBatch.Name = "comboBatch";
            this.comboBatch.Size = new System.Drawing.Size(121, 21);
            this.comboBatch.TabIndex = 11;
            // 
            // New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBatch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textconfirm);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_Student";
            this.Text = "New_Student";
            this.Load += new System.EventHandler(this.New_Student_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textconfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiofemale;
        private System.Windows.Forms.RadioButton radiomale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBatch;
    }
}