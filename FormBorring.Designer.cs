namespace Rekaz
{
    partial class FormBorring
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
            this.label4 = new System.Windows.Forms.Label();
            this.date_month = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_year = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_list_Employee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_dayno_borrows = new System.Windows.Forms.ComboBox();
            this.txt_borrows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1043, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "الشهر";
            // 
            // date_month
            // 
            this.date_month.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.date_month.Location = new System.Drawing.Point(697, 431);
            this.date_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_month.Name = "date_month";
            this.date_month.Size = new System.Drawing.Size(290, 32);
            this.date_month.TabIndex = 57;
            this.date_month.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1043, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "السنة";
            // 
            // date_year
            // 
            this.date_year.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_year.FormattingEnabled = true;
            this.date_year.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.date_year.Location = new System.Drawing.Point(697, 490);
            this.date_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_year.Name = "date_year";
            this.date_year.Size = new System.Drawing.Size(290, 32);
            this.date_year.TabIndex = 55;
            this.date_year.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(1081, 636);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 53);
            this.button2.TabIndex = 54;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_list_Employee
            // 
            this.comboBox_list_Employee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_list_Employee.FormattingEnabled = true;
            this.comboBox_list_Employee.Location = new System.Drawing.Point(697, 242);
            this.comboBox_list_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_list_Employee.Name = "comboBox_list_Employee";
            this.comboBox_list_Employee.Size = new System.Drawing.Size(290, 32);
            this.comboBox_list_Employee.TabIndex = 53;
            this.comboBox_list_Employee.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1038, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "اسم الموظف";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(255, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "0.0 jd";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(260, 259);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 73);
            this.button3.TabIndex = 50;
            this.button3.Text = "حفظ وعرض المتبقي من الراتب";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1038, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 29);
            this.label15.TabIndex = 49;
            this.label15.Text = "يوم السلفة";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1038, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 29);
            this.label14.TabIndex = 48;
            this.label14.Text = "قيمة السلفة";
            // 
            // comboBox_dayno_borrows
            // 
            this.comboBox_dayno_borrows.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dayno_borrows.FormattingEnabled = true;
            this.comboBox_dayno_borrows.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_dayno_borrows.Location = new System.Drawing.Point(697, 368);
            this.comboBox_dayno_borrows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_dayno_borrows.Name = "comboBox_dayno_borrows";
            this.comboBox_dayno_borrows.Size = new System.Drawing.Size(290, 32);
            this.comboBox_dayno_borrows.TabIndex = 47;
            this.comboBox_dayno_borrows.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // txt_borrows
            // 
            this.txt_borrows.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_borrows.Location = new System.Drawing.Point(697, 309);
            this.txt_borrows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_borrows.Name = "txt_borrows";
            this.txt_borrows.Size = new System.Drawing.Size(290, 35);
            this.txt_borrows.TabIndex = 46;
            this.txt_borrows.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(335, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "المتبقي من الراتب";
            // 
            // FormBorring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Rekaz.Properties.Resources.تنزيل__1_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_year);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_list_Employee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox_dayno_borrows);
            this.Controls.Add(this.txt_borrows);
            this.Name = "FormBorring";
            this.Text = "FormBorring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBorring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox date_month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox date_year;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_list_Employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_dayno_borrows;
        private System.Windows.Forms.TextBox txt_borrows;
        private System.Windows.Forms.Label label1;
    }
}