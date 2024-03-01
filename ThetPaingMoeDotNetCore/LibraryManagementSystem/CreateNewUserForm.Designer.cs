namespace LibraryManagementSystem
{
    partial class CreateNewUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            cbo1 = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(388, 22);
            label1.Name = "label1";
            label1.Size = new Size(353, 52);
            label1.TabIndex = 0;
            label1.Text = "Cretae New User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(361, 331);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 410);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 2;
            label3.Text = "User Role: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(361, 250);
            label4.Name = "label4";
            label4.Size = new Size(78, 27);
            label4.TabIndex = 3;
            label4.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(361, 173);
            label5.Name = "label5";
            label5.Size = new Size(131, 27);
            label5.TabIndex = 4;
            label5.Text = "User Name: ";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(561, 173);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 27);
            txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(561, 331);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(561, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 27);
            txtEmail.TabIndex = 7;
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Items.AddRange(new object[] { "user", "admin" });
            cbo1.Location = new Point(561, 413);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(198, 28);
            cbo1.TabIndex = 8;
            cbo1.KeyPress += comboBox1_KeyPress;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 128, 255);
            btnSave.Location = new Point(645, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 42);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // CreateNewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 712);
            Controls.Add(btnSave);
            Controls.Add(cbo1);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateNewUserForm";
            Text = "CreateNewUserForm";
            FormClosed += CreateNewUserForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private ComboBox cbo1;
        private Button btnSave;
    }
}