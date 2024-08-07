namespace EmployeeManagementSystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.salary_clearbtn = new System.Windows.Forms.Button();
            this.salary_updatebtn = new System.Windows.Forms.Button();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salary_position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_employeeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salary_clearbtn);
            this.panel1.Controls.Add(this.salary_updatebtn);
            this.panel1.Controls.Add(this.salary_salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salary_position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.salary_fullname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salary_employeeId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 524);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // salary_clearbtn
            // 
            this.salary_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_clearbtn.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_clearbtn.ForeColor = System.Drawing.Color.White;
            this.salary_clearbtn.Location = new System.Drawing.Point(128, 362);
            this.salary_clearbtn.Name = "salary_clearbtn";
            this.salary_clearbtn.Size = new System.Drawing.Size(94, 41);
            this.salary_clearbtn.TabIndex = 9;
            this.salary_clearbtn.Text = "CLEAR";
            this.salary_clearbtn.UseVisualStyleBackColor = false;
            this.salary_clearbtn.Click += new System.EventHandler(this.salary_clearbtn_Click);
            // 
            // salary_updatebtn
            // 
            this.salary_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_updatebtn.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_updatebtn.ForeColor = System.Drawing.Color.White;
            this.salary_updatebtn.Location = new System.Drawing.Point(19, 362);
            this.salary_updatebtn.Name = "salary_updatebtn";
            this.salary_updatebtn.Size = new System.Drawing.Size(103, 41);
            this.salary_updatebtn.TabIndex = 8;
            this.salary_updatebtn.Text = "UPDATE";
            this.salary_updatebtn.UseVisualStyleBackColor = false;
            this.salary_updatebtn.Click += new System.EventHandler(this.salary_updatebtn_Click);
            // 
            // salary_salary
            // 
            this.salary_salary.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_salary.Location = new System.Drawing.Point(19, 307);
            this.salary_salary.Multiline = true;
            this.salary_salary.Name = "salary_salary";
            this.salary_salary.Size = new System.Drawing.Size(193, 26);
            this.salary_salary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salary:";
            // 
            // salary_position
            // 
            this.salary_position.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_position.Location = new System.Drawing.Point(19, 238);
            this.salary_position.Multiline = true;
            this.salary_position.Name = "salary_position";
            this.salary_position.Size = new System.Drawing.Size(193, 26);
            this.salary_position.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position:";
            // 
            // salary_fullname
            // 
            this.salary_fullname.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_fullname.Location = new System.Drawing.Point(19, 170);
            this.salary_fullname.Multiline = true;
            this.salary_fullname.Name = "salary_fullname";
            this.salary_fullname.Size = new System.Drawing.Size(193, 26);
            this.salary_fullname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // salary_employeeId
            // 
            this.salary_employeeId.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_employeeId.Location = new System.Drawing.Point(19, 102);
            this.salary_employeeId.Multiline = true;
            this.salary_employeeId.Name = "salary_employeeId";
            this.salary_employeeId.Size = new System.Drawing.Size(193, 26);
            this.salary_employeeId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(280, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 524);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(536, 437);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_employeeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salary_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salary_clearbtn;
        private System.Windows.Forms.Button salary_updatebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
