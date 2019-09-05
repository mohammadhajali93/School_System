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
    public partial class satistics : Form
    {

        string[] array = new string[2000];
        string[] array2 = new string[2000];
        connection con = new connection();
        MyValidation myvalidation = new MyValidation();
        MySqlConnection databaseConnection;


        public satistics()
        {
            InitializeComponent();
            Load_num_student();

            Load_classes();

            Load_num_sections();

        }

















        private void Load_num_sections()
        {
            try
            {
                String sql, output = "";

                sql = "SELECT id,name FROM section ORDER BY `section`.`id` ASC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_section.Items.Add(myaReader.GetString(1));
                    array2[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }

        }

        private void Load_classes()
        {
            try
            {
                String sql, output = "";

                sql = "SELECT id,name FROM class_st ORDER BY `class_st`.`id` ASC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_classes.Items.Add(myaReader.GetString(1));
                    array[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }

        }

        private void Load_num_student()
        {
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            try
            {
                databaseConnection.Open();
                string num_student = "";
                String count = "SELECT COUNT(*) FROM student";
                MySqlCommand commands;
                commands = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {
                    num_student = myaReaders.GetString(0);
                }
                myaReaders.Close();
                label2.Text = "" + num_student;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        


        private void chose_number_student_in_section_class()
        {
            string id_section = "";
            string id_class = "";

            int select_class = comboBox_classes.SelectedIndex;

            for (int i = 0; i < 2000; i++)
            {
                if (select_class == i)
                {
                    id_class = array[i];
                }
            }
            int select_section = comboBox_section.SelectedIndex;

            for (int i = 0; i < 2000; i++)
            {
                if (select_section == i)
                {
                    id_section = array[i];
                }
            }


            try
            {

                string num_student = "";
                String count = "SELECT COUNT(*) FROM student WHERE class_st='" + id_class + "'AND section='" + id_section + "'";
                MySqlCommand commands;
                commands = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {
                    num_student = myaReaders.GetString(0);
                }
                myaReaders.Close();





                String sql;

                sql = "SELECT name FROM student WHERE class_st ='" + id_class + "'AND section='" + id_section + "'";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                int i = 0;
                while (myaReader.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = myaReader.GetString(0);

                    // dataGridView1.add
                    i++;

                }
                myaReader.Close();






                label4.Text = num_student + " في الصف  " + comboBox_classes.SelectedItem.ToString() + "    والشعبة " + comboBox_section.SelectedItem.ToString() + "    عدد الطلاب  ";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void chose_number_student_in_class()
        {
            string id_class = "";

            int select_class = comboBox_classes.SelectedIndex;

            for (int i = 0; i < 2000; i++)
            {
                if (select_class == i)
                {
                    id_class = array[i];
                }
            }

            try
            {

                string num_student = "";
                String count = "SELECT COUNT(*) FROM student WHERE class_st='" + id_class + "'";
                MySqlCommand commands;
                commands = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {
                    num_student = myaReaders.GetString(0);
                }
                myaReaders.Close();





                String sql;

                sql = "SELECT name FROM student WHERE class_st ='" + id_class + "'ORDER BY `student`.`id` DESC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                int i = 0;
                while (myaReader.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = myaReader.GetString(0);

                    // dataGridView1.add
                    i++;

                }
                myaReader.Close();




                label8.Text = " في الصف  " + comboBox_classes.SelectedItem.ToString() + "    عدد الطلاب " + num_student;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }














        private void statistics_Load(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (IsValidation())
            {
                dataGridView1.Rows.Clear();
                chose_number_student_in_section_class();

            }
        }

        private bool IsValidation()
        {
            if (comboBox_classes.SelectedItem == null )
            {
                myvalidation.ValidationMessage(comboBox_classes, "اختر الصف لعرض عدد الطلاب ", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_section.SelectedItem == null )
            {
                myvalidation.ValidationMessage(comboBox_section, "اختر الشعبة لعرض عدد الطلاب", "خطأ في الإدخال");
                return false;
            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_classes.SelectedItem == null)
            {
                MessageBox.Show("اختر الصف أولاً لعرض عدد الطلاب ");
            }

            else
            {
                dataGridView1.Rows.Clear();
                chose_number_student_in_class();
            }
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
