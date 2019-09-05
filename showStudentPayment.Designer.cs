namespace Rekaz
{
    partial class showStudentPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tution_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.public_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.private_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.others = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(641, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 52);
            this.label2.TabIndex = 20;
            this.label2.Text = "إظهار دفعات الطالب";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1349, 647);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(140, 57);
            this.back.TabIndex = 19;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tution_fee,
            this.uniform,
            this.transporation,
            this.public_books,
            this.private_books,
            this.others,
            this.sum,
            this.dateTime,
            this.receiver_name});
            this.dataGridView1.Location = new System.Drawing.Point(97, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1637, 280);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(951, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "اختر اسم الطالب";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(661, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 32);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tution_fee
            // 
            this.tution_fee.HeaderText = "القسط المدرسي";
            this.tution_fee.Name = "tution_fee";
            this.tution_fee.Width = 150;
            // 
            // uniform
            // 
            this.uniform.HeaderText = "الزي المدرسي";
            this.uniform.Name = "uniform";
            this.uniform.Width = 150;
            // 
            // transporation
            // 
            this.transporation.HeaderText = "مواصلات";
            this.transporation.Name = "transporation";
            this.transporation.Width = 150;
            // 
            // public_books
            // 
            this.public_books.HeaderText = "كتب عامة";
            this.public_books.Name = "public_books";
            this.public_books.Width = 150;
            // 
            // private_books
            // 
            this.private_books.HeaderText = "كتب خاصة";
            this.private_books.Name = "private_books";
            this.private_books.Width = 150;
            // 
            // others
            // 
            this.others.HeaderText = "أخرى";
            this.others.Name = "others";
            this.others.Width = 150;
            // 
            // sum
            // 
            this.sum.HeaderText = "المجموع";
            this.sum.Name = "sum";
            this.sum.Width = 150;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "التاريخ والوقت";
            this.dateTime.Name = "dateTime";
            this.dateTime.Width = 160;
            // 
            // receiver_name
            // 
            this.receiver_name.HeaderText = "اسم المستلم";
            this.receiver_name.Name = "receiver_name";
            this.receiver_name.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(870, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 47);
            this.button2.TabIndex = 43;
            this.button2.Text = "النسبة المئوية";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "showStudentPayment";
            this.Text = "showStudentPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.showStudentPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tution_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniform;
        private System.Windows.Forms.DataGridViewTextBoxColumn transporation;
        private System.Windows.Forms.DataGridViewTextBoxColumn public_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn private_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn others;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiver_name;
        private System.Windows.Forms.Button button2;
    }
}