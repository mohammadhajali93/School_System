namespace Rekaz
{
    partial class showBookUniform
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
            this.dataGridView_uniform = new System.Windows.Forms.DataGridView();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label_num_stu_public_books = new System.Windows.Forms.Label();
            this.dataGridView_book = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.public_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.private_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sum_bublic_books = new System.Windows.Forms.Label();
            this.sum_uniform = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_num_stu_uniform = new System.Windows.Forms.Label();
            this.sum_private_books = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_num_stu_private_books = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uniform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_uniform
            // 
            this.dataGridView_uniform.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_uniform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_uniform.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Name,
            this.uniform});
            this.dataGridView_uniform.Location = new System.Drawing.Point(130, 287);
            this.dataGridView_uniform.Name = "dataGridView_uniform";
            this.dataGridView_uniform.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_uniform.RowTemplate.Height = 26;
            this.dataGridView_uniform.Size = new System.Drawing.Size(403, 513);
            this.dataGridView_uniform.TabIndex = 18;
            // 
            // Student_Name
            // 
            this.Student_Name.HeaderText = "اسم الطالب";
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Width = 200;
            // 
            // uniform
            // 
            this.uniform.HeaderText = "الزي";
            this.uniform.Name = "uniform";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.Location = new System.Drawing.Point(1449, 767);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "رجوع";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_num_stu_public_books
            // 
            this.label_num_stu_public_books.AutoSize = true;
            this.label_num_stu_public_books.BackColor = System.Drawing.Color.White;
            this.label_num_stu_public_books.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_stu_public_books.ForeColor = System.Drawing.Color.Black;
            this.label_num_stu_public_books.Location = new System.Drawing.Point(1022, 192);
            this.label_num_stu_public_books.Name = "label_num_stu_public_books";
            this.label_num_stu_public_books.Size = new System.Drawing.Size(21, 24);
            this.label_num_stu_public_books.TabIndex = 14;
            this.label_num_stu_public_books.Text = "0";
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.public_book,
            this.private_book});
            this.dataGridView_book.Location = new System.Drawing.Point(660, 291);
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_book.RowTemplate.Height = 26;
            this.dataGridView_book.Size = new System.Drawing.Size(635, 513);
            this.dataGridView_book.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "اسم الطالب";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // public_book
            // 
            this.public_book.HeaderText = "الكتب العامة";
            this.public_book.Name = "public_book";
            this.public_book.Width = 150;
            // 
            // private_book
            // 
            this.private_book.HeaderText = "الكتب الخاصة";
            this.private_book.Name = "private_book";
            this.private_book.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1049, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "عدد الطلاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(813, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "مجموع الكتب";
            // 
            // sum_bublic_books
            // 
            this.sum_bublic_books.AutoSize = true;
            this.sum_bublic_books.BackColor = System.Drawing.Color.White;
            this.sum_bublic_books.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_bublic_books.ForeColor = System.Drawing.Color.Black;
            this.sum_bublic_books.Location = new System.Drawing.Point(786, 192);
            this.sum_bublic_books.Name = "sum_bublic_books";
            this.sum_bublic_books.Size = new System.Drawing.Size(21, 24);
            this.sum_bublic_books.TabIndex = 22;
            this.sum_bublic_books.Text = "0";
            // 
            // sum_uniform
            // 
            this.sum_uniform.AutoSize = true;
            this.sum_uniform.BackColor = System.Drawing.Color.White;
            this.sum_uniform.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_uniform.ForeColor = System.Drawing.Color.Black;
            this.sum_uniform.Location = new System.Drawing.Point(210, 188);
            this.sum_uniform.Name = "sum_uniform";
            this.sum_uniform.Size = new System.Drawing.Size(21, 24);
            this.sum_uniform.TabIndex = 26;
            this.sum_uniform.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(237, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "مجموع الزي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(430, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "عدد الطلاب";
            // 
            // lab_num_stu_uniform
            // 
            this.lab_num_stu_uniform.AutoSize = true;
            this.lab_num_stu_uniform.BackColor = System.Drawing.Color.White;
            this.lab_num_stu_uniform.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_num_stu_uniform.ForeColor = System.Drawing.Color.Black;
            this.lab_num_stu_uniform.Location = new System.Drawing.Point(403, 192);
            this.lab_num_stu_uniform.Name = "lab_num_stu_uniform";
            this.lab_num_stu_uniform.Size = new System.Drawing.Size(21, 24);
            this.lab_num_stu_uniform.TabIndex = 23;
            this.lab_num_stu_uniform.Text = "0";
            this.lab_num_stu_uniform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum_private_books
            // 
            this.sum_private_books.AutoSize = true;
            this.sum_private_books.BackColor = System.Drawing.Color.White;
            this.sum_private_books.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_private_books.ForeColor = System.Drawing.Color.Black;
            this.sum_private_books.Location = new System.Drawing.Point(786, 236);
            this.sum_private_books.Name = "sum_private_books";
            this.sum_private_books.Size = new System.Drawing.Size(21, 24);
            this.sum_private_books.TabIndex = 30;
            this.sum_private_books.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(813, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "مجموع الكتب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1049, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "عدد الطلاب";
            // 
            // label_num_stu_private_books
            // 
            this.label_num_stu_private_books.AutoSize = true;
            this.label_num_stu_private_books.BackColor = System.Drawing.Color.White;
            this.label_num_stu_private_books.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_stu_private_books.ForeColor = System.Drawing.Color.Black;
            this.label_num_stu_private_books.Location = new System.Drawing.Point(1022, 236);
            this.label_num_stu_private_books.Name = "label_num_stu_private_books";
            this.label_num_stu_private_books.Size = new System.Drawing.Size(21, 24);
            this.label_num_stu_private_books.TabIndex = 27;
            this.label_num_stu_private_books.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1158, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "  :الكتب العامة ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1158, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "  :الكتب الخاصة ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.Image = global::Rekaz.Properties.Resources._12183_dress_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(214, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 39);
            this.button2.TabIndex = 16;
            this.button2.Text = "عرض الطلاب (زي)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Image = global::Rekaz.Properties.Resources.Books_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(825, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "عرض الطلاب (كتب)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showBookUniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sum_private_books);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_num_stu_private_books);
            this.Controls.Add(this.sum_uniform);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab_num_stu_uniform);
            this.Controls.Add(this.sum_bublic_books);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_book);
            this.Controls.Add(this.dataGridView_uniform);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_num_stu_public_books);
            this.Name = "showBookUniform";
            this.Text = "showBookUniform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.showBookUniform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uniform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_uniform;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_num_stu_public_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniform;
        private System.Windows.Forms.DataGridView dataGridView_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn public_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn private_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sum_bublic_books;
        private System.Windows.Forms.Label sum_uniform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_num_stu_uniform;
        private System.Windows.Forms.Label sum_private_books;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_num_stu_private_books;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}