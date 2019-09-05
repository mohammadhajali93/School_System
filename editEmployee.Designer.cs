namespace Rekaz
{
    partial class editEmployee
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.date_endDate = new System.Windows.Forms.DateTimePicker();
            this.date_startDate = new System.Windows.Forms.DateTimePicker();
            this.txt_baseSalary = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_list_Employee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(870, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 48);
            this.label6.TabIndex = 39;
            this.label6.Text = "تعديل موظف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rekaz.Properties.Resources._48413034_266853280658216_6841681112079532032_n;
            this.pictureBox1.Location = new System.Drawing.Point(464, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1322, 646);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 46);
            this.button4.TabIndex = 33;
            this.button4.Text = "رجوع";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1018, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 53);
            this.button1.TabIndex = 32;
            this.button1.Text = "تعديل موظف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "معلم",
            "مشرف",
            "محاسب",
            "مرشد"});
            this.comboBox_Role.Location = new System.Drawing.Point(1026, 502);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(217, 41);
            this.comboBox_Role.TabIndex = 31;
            this.comboBox_Role.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // date_endDate
            // 
            this.date_endDate.CustomFormat = "dd/MM/yyyy";
            this.date_endDate.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_endDate.Location = new System.Drawing.Point(1026, 456);
            this.date_endDate.Name = "date_endDate";
            this.date_endDate.Size = new System.Drawing.Size(217, 40);
            this.date_endDate.TabIndex = 30;
            // 
            // date_startDate
            // 
            this.date_startDate.CustomFormat = "dd/MM/yyyy";
            this.date_startDate.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_startDate.Location = new System.Drawing.Point(1026, 411);
            this.date_startDate.Name = "date_startDate";
            this.date_startDate.Size = new System.Drawing.Size(217, 40);
            this.date_startDate.TabIndex = 29;
            // 
            // txt_baseSalary
            // 
            this.txt_baseSalary.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baseSalary.Location = new System.Drawing.Point(1026, 365);
            this.txt_baseSalary.Name = "txt_baseSalary";
            this.txt_baseSalary.Size = new System.Drawing.Size(217, 40);
            this.txt_baseSalary.TabIndex = 28;
            this.txt_baseSalary.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1026, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 40);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1249, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 34);
            this.label5.TabIndex = 34;
            this.label5.Text = "الدور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1249, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "تاريخ الانتهاء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1249, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 34);
            this.label3.TabIndex = 36;
            this.label3.Text = "تاريخ البدء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1249, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 34);
            this.label2.TabIndex = 37;
            this.label2.Text = "الراتب الشهري";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1249, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = " اسم الموظف المعدّل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1249, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 34);
            this.label7.TabIndex = 42;
            this.label7.Text = "اسم الموظف";
            // 
            // comboBox_list_Employee
            // 
            this.comboBox_list_Employee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_list_Employee.FormattingEnabled = true;
            this.comboBox_list_Employee.Location = new System.Drawing.Point(1026, 283);
            this.comboBox_list_Employee.Name = "comboBox_list_Employee";
            this.comboBox_list_Employee.Size = new System.Drawing.Size(217, 32);
            this.comboBox_list_Employee.TabIndex = 43;
            this.comboBox_list_Employee.SelectedIndexChanged += new System.EventHandler(this.comboBox_list_Employee_SelectedIndexChanged);
            this.comboBox_list_Employee.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // editEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.comboBox_list_Employee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.date_endDate);
            this.Controls.Add(this.date_startDate);
            this.Controls.Add(this.txt_baseSalary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editEmployee";
            this.Text = "editEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.editEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.DateTimePicker date_endDate;
        private System.Windows.Forms.DateTimePicker date_startDate;
        private System.Windows.Forms.TextBox txt_baseSalary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_list_Employee;
    }
}