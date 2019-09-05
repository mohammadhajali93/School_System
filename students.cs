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
    public partial class students : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;

        String nameee ="", num_students="",class_name="", section_name="";
        int num = 0;


        string[] name_student, class_student, section_student, phone_student,class_name_arr, section_name_arr;
        

         
public students()
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

        private void students_Load(object sender, EventArgs e)
        {

            a();

            show();
        }

        private void a()
        {
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);

            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }
            String count = "SELECT COUNT(*) FROM student  ";
            MySqlCommand command = new MySqlCommand(count, databaseConnection);

            MySqlDataReader myaReader = command.ExecuteReader();

            while (myaReader.Read())
            {                                    //ID                             
                num_students = num_students + myaReader.GetString(0) + "\n";

               // MessageBox.Show("num_students" + num_students);
            }

            myaReader.Close();

             num = int.Parse(num_students);

            name_student = new string[num];
             class_student = new string[num];
             section_student = new string[num];
             phone_student = new string[num];
            class_name_arr = new string[num];
            section_name_arr = new string[num];

        }

        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvStudents.Rows[e.RowIndex];
              nameee=  row.Cells["name"].Value.ToString();
            }
        }
        private void show()
        {
           // string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rekaz";
            MySqlConnection databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;


            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }

            string query = "SELECT * FROM `student` ORDER BY `student`.`id` DESC ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            gvStudents.Rows.Clear();

            int q = 0;
            foreach (DataRow datarow in dataTable.Rows)
            {
                // int n = gvStudents.Rows.Add();
                //  gvStudents.Rows[n].Cells[0].Value = datarow[1].ToString();
                // gvStudents.Rows[n].Cells[1].Value = datarow[7].ToString();
                // gvStudents.Rows[n].Cells[2].Value = datarow[8].ToString();
                //gvStudents.Rows[n].Cells[3].Value = datarow[5].ToString();

               name_student[q] = datarow[1].ToString();
                class_student[q]=  datarow[7].ToString();
                section_student[q]=  datarow[8].ToString();
                 phone_student[q]= datarow[5].ToString();
                q++;
            }


            int y = 0;
            int z = 0;
            for (int i = 0; i < num; i++)
            {

                String sql_class = "SELECT name FROM class_st WHERE id='" + class_student[i] + "'";
                MySqlCommand command_class = new MySqlCommand(sql_class, databaseConnection);

                MySqlDataReader myaReader_class = command_class.ExecuteReader();
                while (myaReader_class.Read())
                {                                    //ID                             
                    class_name = myaReader_class.GetString(0) + "\n";
                    class_name_arr[y] = class_name;
                    y++;


                }
                myaReader_class.Close();

                String sql_section = "SELECT name FROM section WHERE id='" + section_student[i] + "'";
                MySqlCommand command_section = new MySqlCommand(sql_section, databaseConnection);

                MySqlDataReader myaReader_section = command_section.ExecuteReader();
                while (myaReader_section.Read())
                {                                    //ID                             
                    section_name = myaReader_section.GetString(0) + "\n";
                    section_name_arr[z] = section_name;
                    z++;


                }
                myaReader_section.Close();




                int n = gvStudents.Rows.Add();
                gvStudents.Rows[n].Cells[0].Value = name_student[i].ToString();
                gvStudents.Rows[n].Cells[1].Value = class_name_arr[i].ToString();
                gvStudents.Rows[n].Cells[2].Value = section_name_arr[i].ToString();
                gvStudents.Rows[n].Cells[3].Value = phone_student[i].ToString();


               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
              shard.Name = nameee;


            this.Hide();
            delete_student d = new delete_student();
            d.Show();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            editStudent editstu = new editStudent();
            editstu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            showBookUniform bu = new showBookUniform();
            bu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            showStudentLate showStuLate = new showStudentLate();
            showStuLate.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Check = "showpayment";
            confirm c = new confirm();
            c.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receivables receivables = new Receivables();
            receivables.Show();
        }

        private void add_student_Click(object sender, EventArgs e)
        {

        }

        private void add_student_Click_1(object sender, EventArgs e)
        {

            

            this.Hide();
            add_student addstudent = new add_student();
            addstudent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            satistics statis = new satistics();
            statis.Show();
        }

        private void payments_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Check = "payment";
            confirm c = new confirm();
            c.Show();
        }

        private void brothers_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            show_brothers show_bro = new show_brothers();
            show_bro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            add_brother add_bro = new add_brother();
            add_bro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            EditStudentDataPayment edit = new EditStudentDataPayment();
            edit.Show();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_students transfer_Students = new Transfer_students();
            transfer_Students.Show();
        }
    }
    }

