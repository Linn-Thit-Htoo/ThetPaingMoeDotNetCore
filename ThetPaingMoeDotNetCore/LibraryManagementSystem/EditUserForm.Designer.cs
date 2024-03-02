namespace LibraryManagementSystem
{
    partial class EditUserForm
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
            btnSave = new Button();
            cbo1 = new ComboBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 128, 255);
            btnSave.Location = new Point(569, 479);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 40);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Items.AddRange(new object[] { "user", "admin" });
            cbo1.Location = new Point(485, 399);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(198, 28);
            cbo1.TabIndex = 18;
            cbo1.KeyPress += cbo1_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(485, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(485, 317);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(485, 159);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 27);
            txtUserName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(285, 159);
            label5.Name = "label5";
            label5.Size = new Size(131, 27);
            label5.TabIndex = 14;
            label5.Text = "User Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(285, 236);
            label4.Name = "label4";
            label4.Size = new Size(78, 27);
            label4.TabIndex = 13;
            label4.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(288, 396);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 12;
            label3.Text = "User Role: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(285, 317);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 11;
            label2.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(398, 24);
            label1.Name = "label1";
            label1.Size = new Size(206, 52);
            label1.TabIndex = 10;
            label1.Text = "Edit User";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(224, 224, 224);
            btnBack.Location = new Point(288, 479);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 609);
            Controls.Add(btnBack);
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
            Name = "EditUserForm";
            Text = "EditUserForm";
            FormClosed += EditUserForm_FormClosed;
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbo1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack;
    }
}