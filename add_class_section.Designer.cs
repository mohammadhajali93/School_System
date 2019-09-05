namespace Rekaz
{
    partial class add_class_section
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
            this.class_name = new System.Windows.Forms.Label();
            this.class_price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.section_name = new System.Windows.Forms.Label();
            this.txt_class_name = new System.Windows.Forms.TextBox();
            this.txt_name_section = new System.Windows.Forms.TextBox();
            this.txt_class_price = new System.Windows.Forms.TextBox();
            this.gvClasses = new System.Windows.Forms.DataGridView();
            this.class_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSections = new System.Windows.Forms.DataGridView();
            this.section_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(480, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "إضافة صف";
            // 
            // class_name
            // 
            this.class_name.AutoSize = true;
            this.class_name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name.Location = new System.Drawing.Point(538, 468);
            this.class_name.Name = "class_name";
            this.class_name.Size = new System.Drawing.Size(138, 34);
            this.class_name.TabIndex = 1;
            this.class_name.Text = "اسم الصف";
            // 
            // class_price
            // 
            this.class_price.AutoSize = true;
            this.class_price.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_price.Location = new System.Drawing.Point(534, 533);
            this.class_price.Name = "class_price";
            this.class_price.Size = new System.Drawing.Size(148, 34);
            this.class_price.TabIndex = 2;
            this.class_price.Text = "تكلفة الصف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(480, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "إضافة شعبة";
            // 
            // section_name
            // 
            this.section_name.AutoSize = true;
            this.section_name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_name.Location = new System.Drawing.Point(534, 728);
            this.section_name.Name = "section_name";
            this.section_name.Size = new System.Drawing.Size(162, 34);
            this.section_name.TabIndex = 4;
            this.section_name.Text = "اسم الشعبة";
            // 
            // txt_class_name
            // 
            this.txt_class_name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_class_name.Location = new System.Drawing.Point(359, 471);
            this.txt_class_name.Name = "txt_class_name";
            this.txt_class_name.Size = new System.Drawing.Size(164, 40);
            this.txt_class_name.TabIndex = 5;
            this.txt_class_name.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // txt_name_section
            // 
            this.txt_name_section.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_section.Location = new System.Drawing.Point(365, 731);
            this.txt_name_section.Name = "txt_name_section";
            this.txt_name_section.Size = new System.Drawing.Size(164, 40);
            this.txt_name_section.TabIndex = 6;
            this.txt_name_section.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // txt_class_price
            // 
            this.txt_class_price.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_class_price.Location = new System.Drawing.Point(359, 533);
            this.txt_class_price.Name = "txt_class_price";
            this.txt_class_price.Size = new System.Drawing.Size(164, 40);
            this.txt_class_price.TabIndex = 7;
            this.txt_class_price.TextChanged += new System.EventHandler(this.Ctrl_TextChanged);
            // 
            // gvClasses
            // 
            this.gvClasses.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.gvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_no,
            this.price});
            this.gvClasses.Location = new System.Drawing.Point(826, 408);
            this.gvClasses.Name = "gvClasses";
            this.gvClasses.RowTemplate.Height = 24;
            this.gvClasses.Size = new System.Drawing.Size(285, 354);
            this.gvClasses.TabIndex = 8;
            // 
            // class_no
            // 
            this.class_no.HeaderText = "الصف";
            this.class_no.Name = "class_no";
            // 
            // price
            // 
            this.price.HeaderText = "السعر";
            this.price.Name = "price";
            // 
            // gvSections
            // 
            this.gvSections.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.gvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.section_no});
            this.gvSections.Location = new System.Drawing.Point(1171, 408);
            this.gvSections.Name = "gvSections";
            this.gvSections.RowTemplate.Height = 24;
            this.gvSections.Size = new System.Drawing.Size(170, 354);
            this.gvSections.TabIndex = 9;
            // 
            // section_no
            // 
            this.section_no.HeaderText = "الشعبة";
            this.section_no.Name = "section_no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(891, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "جدول الصفوف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1166, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "جدول الشُعب";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Yellow;
            this.save.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(347, 605);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(92, 46);
            this.save.TabIndex = 12;
            this.save.Text = "إضافة صف";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(695, 841);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 58);
            this.back.TabIndex = 13;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(347, 790);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "إضافة شعبة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rekaz.Properties.Resources._39404682_223701144973430_5060375758577336320_n1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1911, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // add_class_section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvSections);
            this.Controls.Add(this.gvClasses);
            this.Controls.Add(this.txt_class_price);
            this.Controls.Add(this.txt_name_section);
            this.Controls.Add(this.txt_class_name);
            this.Controls.Add(this.section_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.class_price);
            this.Controls.Add(this.class_name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "add_class_section";
            this.Text = "add_class_section";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.add_class_section_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label class_name;
        private System.Windows.Forms.Label class_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label section_name;
        private System.Windows.Forms.TextBox txt_class_name;
        private System.Windows.Forms.TextBox txt_name_section;
        private System.Windows.Forms.TextBox txt_class_price;
        private System.Windows.Forms.DataGridView gvClasses;
        private System.Windows.Forms.DataGridView gvSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn section_no;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}