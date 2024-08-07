namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_show_pass = new System.Windows.Forms.CheckBox();
            this.signup_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_signin_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(289, 332);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(88, 34);
            this.signup_btn.TabIndex = 17;
            this.signup_btn.Text = "SignUp";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_show_pass
            // 
            this.signup_show_pass.AutoSize = true;
            this.signup_show_pass.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_show_pass.Location = new System.Drawing.Point(404, 279);
            this.signup_show_pass.Name = "signup_show_pass";
            this.signup_show_pass.Size = new System.Drawing.Size(141, 23);
            this.signup_show_pass.TabIndex = 16;
            this.signup_show_pass.Text = "Show password";
            this.signup_show_pass.UseVisualStyleBackColor = true;
            this.signup_show_pass.CheckedChanged += new System.EventHandler(this.signup_show_pass_CheckedChanged);
            // 
            // signup_pass
            // 
            this.signup_pass.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_pass.Location = new System.Drawing.Point(290, 228);
            this.signup_pass.Multiline = true;
            this.signup_pass.Name = "signup_pass";
            this.signup_pass.PasswordChar = '*';
            this.signup_pass.Size = new System.Drawing.Size(261, 25);
            this.signup_pass.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "password";
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(289, 155);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(261, 25);
            this.signup_username.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(553, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 20);
            this.exit.TabIndex = 10;
            this.exit.Text = "x";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.signup_signin_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 400);
            this.panel1.TabIndex = 9;
            // 
            // signup_signin_btn
            // 
            this.signup_signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.signup_signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_signin_btn.FlatAppearance.BorderSize = 0;
            this.signup_signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.signup_signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.signup_signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_signin_btn.ForeColor = System.Drawing.Color.White;
            this.signup_signin_btn.Location = new System.Drawing.Point(85, 348);
            this.signup_signin_btn.Name = "signup_signin_btn";
            this.signup_signin_btn.Size = new System.Drawing.Size(105, 35);
            this.signup_signin_btn.TabIndex = 1;
            this.signup_signin_btn.Text = "SigIn";
            this.signup_signin_btn.UseVisualStyleBackColor = false;
            this.signup_signin_btn.Click += new System.EventHandler(this.signup_signin_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sign In Your Account";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_show_pass);
            this.Controls.Add(this.signup_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox signup_show_pass;
        private System.Windows.Forms.TextBox signup_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signup_signin_btn;
        private System.Windows.Forms.Label label5;
    }
}