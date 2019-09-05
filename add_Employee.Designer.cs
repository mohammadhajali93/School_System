namespace Rekaz
{
    partial class add_Employee
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name_Employee = new System.Windows.Forms.TextBox();
            this.txt_baseSalary = new System.Windows.Forms.TextBox();
            this.date_startDate = new System.Windows.Forms.DateTimePicker();
            this.date_endDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(885, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم الموظف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(885, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "الراتب الشهري";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(885, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "تاريخ البدء";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(885, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "تاريخ الانتهاء";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(885, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "الدور";
            // 
            // txt_name_Employee
            // 
            this.txt_name_Employee.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_Employee.Location = new System.Drawing.Point(694, 202);
            this.txt_name_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name_Employee.Name = "txt_name_Employee";
            this.txt_name_Employee.Size = new System.Drawing.Size(187, 34);
            this.txt_name_Employee.TabIndex = 0;
            this.txt_name_Employee.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // txt_baseSalary
            // 
            this.txt_baseSalary.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baseSalary.Location = new System.Drawing.Point(694, 237);
            this.txt_baseSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_baseSalary.Name = "txt_baseSalary";
            this.txt_baseSalary.Size = new System.Drawing.Size(187, 34);
            this.txt_baseSalary.TabIndex = 1;
            this.txt_baseSalary.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // date_startDate
            // 
            this.date_startDate.CustomFormat = "dd/MM/yyyy";
            this.date_startDate.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_startDate.Location = new System.Drawing.Point(694, 275);
            this.date_startDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_startDate.Name = "date_startDate";
            this.date_startDate.Size = new System.Drawing.Size(187, 34);
            this.date_startDate.TabIndex = 2;
            // 
            // date_endDate
            // 
            this.date_endDate.CustomFormat = "dd/MM/yyyy";
            this.date_endDate.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_endDate.Location = new System.Drawing.Point(694, 311);
            this.date_endDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_endDate.Name = "date_endDate";
            this.date_endDate.Size = new System.Drawing.Size(187, 34);
            this.date_endDate.TabIndex = 3;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "مدير",
            "معلم",
            "مشرف",
            "محاسب",
            "سكرتير",
            "مرشد",
            "مستخدم",
            "حارس",
            "سائق",
            "مساعد"});
            this.comboBox_Role.Location = new System.Drawing.Point(694, 349);
            this.comboBox_Role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(187, 35);
            this.comboBox_Role.TabIndex = 4;
            this.comboBox_Role.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "إضافة موظف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(948, 466);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "رجوع";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(561, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "إضافة موظف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rekaz.Properties.Resources._48413034_266853280658216_6841681112079532032_n;
            this.pictureBox1.Location = new System.Drawing.Point(213, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1174, 609);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.date_endDate);
            this.Controls.Add(this.date_startDate);
            this.Controls.Add(this.txt_baseSalary);
            this.Controls.Add(this.txt_name_Employee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "add_Employee";
            this.Text = "add_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.add_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name_Employee;
        private System.Windows.Forms.TextBox txt_baseSalary;
        private System.Windows.Forms.DateTimePicker date_startDate;
        private System.Windows.Forms.DateTimePicker date_endDate;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}