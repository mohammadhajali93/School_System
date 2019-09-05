using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Rekaz
{
    public partial class add_class_section : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();
        int outAge;


        public add_class_section()
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);


            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }
        }

        private void add_class_section_Load(object sender, EventArgs e)
        {
            show_class();
            show_section();
        }
        private void show_section()
        {
           


            string query = "SELECT * FROM `section` ORDER BY `section`.`id` ASC  ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            gvSections.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = gvSections.Rows.Add();
                gvSections.Rows[n].Cells[0].Value = datarow[1].ToString();
               

            }
        }
        private void show_class()
        {
           
            string query = "SELECT * FROM `class_st` ORDER BY `class_st`.`id` ASC ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            gvClasses.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = gvClasses.Rows.Add();
                gvClasses.Rows[n].Cells[0].Value = datarow[1].ToString();
                gvClasses.Rows[n].Cells[1].Value = datarow[2].ToString();
                

            }
        }

        private void add_class()
        {
            string class_name = txt_class_name.Text;
            string class_price = txt_class_price.Text;


            string query = "INSERT INTO `class_st`(`name`,`price`) VALUES ('" + class_name + "','" + class_price+ "')";

            
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;



            try
            {
                commandDatabase.CommandText = query;
                int i = commandDatabase.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("تم التسجيل بنجاح" );

                    txt_class_name.Text = "";
                    txt_class_price.Text = "";
                }
                else
                {
                    MessageBox.Show("!لم يتم التسجيل  ");

                }
                commandDatabase.Dispose();




            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }
        }

        private void add_section()
        {
            string name_section = txt_name_section.Text;


            string query = "INSERT INTO `section`(`name`) VALUES ('" + name_section + "')";


            
           
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;



            try
            {
                commandDatabase.CommandText = query;
                int i = commandDatabase.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("تم التسجيل بنجاح ");

                    txt_name_section.Text = "";
                }
                else
                {
                    MessageBox.Show("!لم يتم التسجيل  ");

                }
                commandDatabase.Dispose();




            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (IsValidationClass())
            {
                add_class();
            }
        }
        public bool IsValidationClass()
        {


            if (txt_class_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_class_name, "أدخل اسم الصف", "خطأ في الإدخال");
                return false;
            }
            if (txt_class_price.Text == "")
            {
                myvalidation.ValidationMessage(txt_class_price, "أدخل تكلفة الصف ", "خطأ في الإدخال");
                return false;
            }

            else if (!int.TryParse(txt_class_price.Text, out outAge))
            {
                txt_class_price.BackColor = Color.LightPink;
                MessageBox.Show("قيمة التكلفة يجب ان تكون رقم", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_class_price.Focus();
                return false;
            }



            return true;



        }


        public bool IsValidationSection()
        {


            if (txt_name_section.Text == "")
            {
                myvalidation.ValidationMessage(txt_name_section, "أدخل اسم الشعبة", "خطأ في الإدخال");
                return false;
            }
            
            
            return true;
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidationSection())
            {
                add_section();
            }
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            satistics statis = new satistics();
            statis.Show();
        }
    }
}
