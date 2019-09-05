namespace Rekaz
{
    partial class showSalary
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
            this.comboBox_list_Employee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.month_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(977, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "الشهر";
            // 
            // date_month
            // 
            this.date_month.FormattingEnabled = true;
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
            this.date_month.Location = new System.Drawing.Point(748, 209);
            this.date_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_month.Name = "date_month";
            this.date_month.Size = new System.Drawing.Size(202, 24);
            this.date_month.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(979, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "السنة";
            // 
            // date_year
            // 
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
            this.date_year.Location = new System.Drawing.Point(748, 268);
            this.date_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_year.Name = "date_year";
            this.date_year.Size = new System.Drawing.Size(202, 24);
            this.date_year.TabIndex = 60;
            // 
            // comboBox_list_Employee
            // 
            this.comboBox_list_Employee.FormattingEnabled = true;
            this.comboBox_list_Employee.Location = new System.Drawing.Point(748, 147);
            this.comboBox_list_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_list_Employee.Name = "comboBox_list_Employee";
            this.comboBox_list_Employee.Size = new System.Drawing.Size(202, 24);
            this.comboBox_list_Employee.TabIndex = 59;
            this.comboBox_list_Employee.SelectedIndexChanged += new System.EventHandler(this.comboBox_list_Employee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(977, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "قائمة الموظفين";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month_no,
            this.year_no,
            this.premiums,
            this.tours,
            this.rewards,
            this.insurance,
            this.discounts,
            this.net_salary,
            this.comments});
            this.dataGridView3.Location = new System.Drawing.Point(133, 446);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView3.Size = new System.Drawing.Size(1643, 178);
            this.dataGridView3.TabIndex = 65;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1012, 336);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 48);
            this.button4.TabIndex = 64;
            this.button4.Text = "كشف الرواتب";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1086, 644);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 66;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // month_no
            // 
            this.month_no.HeaderText = "الشهر";
            this.month_no.Name = "month_no";
            this.month_no.Width = 150;
            // 
            // year_no
            // 
            this.year_no.HeaderText = "السنة";
            this.year_no.Name = "year_no";
            this.year_no.Width = 150;
            // 
            // premiums
            // 
            this.premiums.HeaderText = "العلاوات";
            this.premiums.Name = "premiums";
            this.premiums.Width = 150;
            // 
            // tours
            // 
            this.tours.HeaderText = "الجولات";
            this.tours.Name = "tours";
            this.tours.Width = 150;
            // 
            // rewards
            // 
            this.rewards.HeaderText = "المكافآت";
            this.rewards.Name = "rewards";
            this.rewards.Width = 150;
            // 
            // insurance
            // 
            this.insurance.HeaderText = "التأمين";
            this.insurance.Name = "insurance";
            this.insurance.Width = 150;
            // 
            // discounts
            // 
            this.discounts.HeaderText = "الخصم";
            this.discounts.Name = "discounts";
            this.discounts.Width = 150;
            // 
            // net_salary
            // 
            this.net_salary.HeaderText = "الراتب النهائي";
            this.net_salary.Name = "net_salary";
            this.net_salary.Width = 150;
            // 
            // comments
            // 
            this.comments.HeaderText = "التعليقات";
            this.comments.Name = "comments";
            this.comments.Width = 150;
            // 
            // showSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_year);
            this.Controls.Add(this.comboBox_list_Employee);
            this.Controls.Add(this.label2);
            this.Name = "showSalary";
            this.Text = "showSalary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.showSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox date_month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox date_year;
        private System.Windows.Forms.ComboBox comboBox_list_Employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiums;
        private System.Windows.Forms.DataGridViewTextBoxColumn tours;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn discounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
    }
}