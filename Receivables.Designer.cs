namespace Rekaz
{
    partial class Receivables
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuition_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.public_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.private_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.others = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Chartreuse;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.tuition_fee,
            this.uniform,
            this.transporation,
            this.public_books,
            this.private_books,
            this.others,
            this.sum});
            this.dataGridView3.Location = new System.Drawing.Point(62, 241);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView3.Size = new System.Drawing.Size(843, 197);
            this.dataGridView3.TabIndex = 65;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "اسم الطالب";
            this.name.Name = "name";
            // 
            // tuition_fee
            // 
            this.tuition_fee.HeaderText = "المصاريف";
            this.tuition_fee.Name = "tuition_fee";
            // 
            // uniform
            // 
            this.uniform.HeaderText = "الزي";
            this.uniform.Name = "uniform";
            // 
            // transporation
            // 
            this.transporation.HeaderText = "المواصلات";
            this.transporation.Name = "transporation";
            // 
            // public_books
            // 
            this.public_books.HeaderText = "كتب عامة";
            this.public_books.Name = "public_books";
            // 
            // private_books
            // 
            this.private_books.HeaderText = "كتب خاصة";
            this.private_books.Name = "private_books";
            // 
            // others
            // 
            this.others.HeaderText = "مصاريف أخرى";
            this.others.Name = "others";
            // 
            // sum
            // 
            this.sum.HeaderText = "المجموع";
            this.sum.Name = "sum";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(350, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 59);
            this.button3.TabIndex = 66;
            this.button3.Text = "عرض المستحقات";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Receivables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Receivables";
            this.Text = "Receivables";
            this.Load += new System.EventHandler(this.Receivables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuition_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniform;
        private System.Windows.Forms.DataGridViewTextBoxColumn transporation;
        private System.Windows.Forms.DataGridViewTextBoxColumn public_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn private_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn others;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.Button button3;
    }
}