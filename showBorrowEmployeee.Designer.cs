namespace Rekaz
{
    partial class showBorrowEmployeee
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.day_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(936, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 57;
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
            this.date_month.Location = new System.Drawing.Point(707, 155);
            this.date_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_month.Name = "date_month";
            this.date_month.Size = new System.Drawing.Size(202, 24);
            this.date_month.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 55;
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
            this.date_year.Location = new System.Drawing.Point(707, 214);
            this.date_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_year.Name = "date_year";
            this.date_year.Size = new System.Drawing.Size(202, 24);
            this.date_year.TabIndex = 54;
            // 
            // comboBox_list_Employee
            // 
            this.comboBox_list_Employee.FormattingEnabled = true;
            this.comboBox_list_Employee.Location = new System.Drawing.Point(707, 93);
            this.comboBox_list_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_list_Employee.Name = "comboBox_list_Employee";
            this.comboBox_list_Employee.Size = new System.Drawing.Size(202, 24);
            this.comboBox_list_Employee.TabIndex = 53;
            this.comboBox_list_Employee.SelectedIndexChanged += new System.EventHandler(this.comboBox_list_Employee_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "قائمة الموظفين";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(960, 619);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 60;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day_borrow,
            this.month_borrow,
            this.date_borrow,
            this.Amount});
            this.dataGridView2.Location = new System.Drawing.Point(229, 359);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(842, 178);
            this.dataGridView2.TabIndex = 62;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1088, 419);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 48);
            this.button3.TabIndex = 61;
            this.button3.Text = "عرض السلف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // day_borrow
            // 
            this.day_borrow.HeaderText = "اليوم";
            this.day_borrow.Name = "day_borrow";
            this.day_borrow.Width = 150;
            // 
            // month_borrow
            // 
            this.month_borrow.HeaderText = "الشهر";
            this.month_borrow.Name = "month_borrow";
            this.month_borrow.Width = 150;
            // 
            // date_borrow
            // 
            this.date_borrow.HeaderText = "السنة";
            this.date_borrow.Name = "date_borrow";
            this.date_borrow.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "مقدار السلفة";
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // showBorrowEmployeee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_year);
            this.Controls.Add(this.comboBox_list_Employee);
            this.Controls.Add(this.label2);
            this.Name = "showBorrowEmployeee";
            this.Text = "showBorrowEmployeee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.showBorrowEmployeee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}