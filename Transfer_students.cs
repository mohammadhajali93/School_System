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
    public partial class Transfer_students : Form
    {


        string[] array_student = new string[2000];
        string[] name = new string[2000];
        string[] name_sections = new string[2000];
        string[] id_class = new string[2000];
        string[] id_section = new string[2000];
        string[] id_sections = new string[2000];
        string[] name_new_sections = new string[2000];
        string[] name_section = new string[2000];
        string student = "";
        string students = "", students_indexs;
        int num_student = 0;
        int count = 0;
        int index;
        int indexs;
        connection con = new connection();

        MySqlConnection databaseConnection;



        public Transfer_students()
        {
            InitializeComponent();

            Load_classes();

        }


        private void Load_classes()
        {
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            try
            {
                databaseConnection.Open();

                String sql, output = "";

                sql = "SELECT id,name FROM class_st  ORDER BY `class_st`.`id` ASC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_classes.Items.Add(myaReader.GetString(1));
                    comboBox_new_class.Items.Add(myaReader.GetString(1));
                    array_student[i] = myaReader.GetString(0);
                    id_class[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_classes.SelectedItem == null)
            {
                MessageBox.Show("اختر الصف أولاً لعرض عدد الطلاب ");
            }

            else
            {
                dataGridView2.Rows.Clear();
                chose_number_student_in_class();
            }

        }


        private void chose_number_student_in_class()
        {
            string id_class = "";

            int select_class = comboBox_classes.SelectedIndex;

            for (int i = 0; i < 10; i++)
            {
                if (select_class == i)
                {
                    id_class = array_student[i];
                }
            }

            try
            {



                String sql;

                sql = "SELECT name , section FROM student WHERE class_st ='" + id_class + "' ORDER BY `student`.`id` DESC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                int i = 0;
                while (myaReader.Read())
                {

                    int n2 = dataGridView2.Rows.Add();


                    dataGridView2.Rows[n2].Cells[0].Value = myaReader.GetString(0);
                    name[i] = myaReader.GetString(0);
                    id_section[i] = myaReader.GetString(1);
                    // dataGridView1.add
                    i++;

                }
                myaReader.Close();


                String count = "SELECT COUNT(*) FROM student WHERE  class_st ='" + id_class + "'";
                MySqlCommand commands;
                commands = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {
                    num_student = int.Parse(myaReaders.GetString(0));
                }
                myaReaders.Close();


                for (int z = 0; z < num_student; z++)
                {

                    String sql2;

                    sql2 = "SELECT name  FROM section WHERE id  ='" + id_section[z] + "'";

                    MySqlCommand command2;
                    command2 = new MySqlCommand(sql2, databaseConnection);


                    MySqlDataReader myaReader2 = command2.ExecuteReader();


                    while (myaReader2.Read())
                    {
                        name_sections[z] = myaReader2.GetString(0);

                        dataGridView2.Rows[z].Cells[1].Value = myaReader2.GetString(0);
                    }
                    myaReader2.Close();
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_classes.SelectedItem == null)
            {
                MessageBox.Show("حدد الصف لإظهار الطلاب أولاً    ");
            }

            else if (students == "")
            {
                MessageBox.Show(" أختر الطالب أولاً لاستثنائه  من خلال الضغط بنقرة مزدوجة أكثر من مرة على الطالب   ");
            }
            else
            {

                DialogResult dialog = MessageBox.Show("هل متأكد من استثناء الطالب   " + students, "عملية استثناء الطالب ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    MessageBox.Show("    سيتم استثناء     " + students + " من النقل  ");
                    //  MessageBox.Show(index + "");


                    dataGridView2.Rows.RemoveAt(indexs);

                    for (int i = 0; i < 15; i++)
                    {
                        if (i == indexs)
                        {
                            name[i] = "";


                        }

                    }

                    for (int i = indexs; i < 15; i++)
                    {
                        name[i] = name[i + 1];


                    }
                    name_sections[indexs] = students_indexs;
                    select_id_sctions_new();

                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم  بعملية الإستثناء     ");

                }
            }

        }



        private void select_id_sctions_new()
        {
            try
            {
                for (int z = 0; z < num_student; z++)
                {

                    String sql2;

                    sql2 = "SELECT id  FROM section WHERE name  ='" + name_sections[z] + "'ORDER BY `section`.`id` ASC";

                    MySqlCommand command2;
                    command2 = new MySqlCommand(sql2, databaseConnection);


                    MySqlDataReader myaReader2 = command2.ExecuteReader();


                    while (myaReader2.Read())
                    {
                        id_sections[z] = myaReader2.GetString(0);

                    }
                    myaReader2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox_classes.SelectedItem == null)
            {
                MessageBox.Show("حدد الصف لإظهار الطلاب أولاً    ");
            }


            else if (comboBox_new_class.SelectedItem == null)
            {
                MessageBox.Show("أختر الصف الذي تريد نقل الطلاب عليه     ");
            }
            else
            {

                DialogResult dialog = MessageBox.Show("هل متأكد من نقل الطلاب   ", "عملية نقل الطالب ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    string new_class = comboBox_new_class.SelectedItem.ToString();






                    update_class();

                    DataGridViewRow rows = this.dataGridView2.Rows[indexs];

                    MessageBox.Show(" تمت  عملية النقل    بنجاح  ");


                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم  بعملية النقل     ");

                }
            }
            
        }


        private void update_class()
        {
            int select_class = comboBox_new_class.SelectedIndex;
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                string id_classes = "";
                for (int i = 0; i < 2000; i++)
                {
                    if (select_class == i)
                    {
                        id_classes = id_class[i];
                    }
                }//id_student ,name,gender,class_st,section,transporation_id,persistent,noob,comments,end_date,start_date, emergency_phone_number,phone_number,address , date_of_birth,number_of_brothers

                for (int i = 0; i < 150; i++)
                {

                    commandDatabase.CommandText = "Update student set  class_st='" + id_classes + "'WHERE name ='" + name[i] + "'";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();

                }
            }
            catch (Exception ex)
            {


            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexs = e.RowIndex;
            DataGridViewRow rows = this.dataGridView2.Rows[indexs];


            students = rows.Cells["Column3"].Value.ToString();

        }

        private void comboBox_new_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            students Student = new students();
            Student.Show();
        }

        private void Transfer_students_Load(object sender, EventArgs e)
        {

        }
    }
}
