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
    public partial class showStudentPayment : Form
    {
        connection con = new connection();

        MySqlConnection databaseConnection;
        string id = "",name_stu="";

        public showStudentPayment()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);

            loaading_students();

        }


        private void loaading_students()
        {
            try
            {
                databaseConnection.Open();

                String sqls, outputs = "";

                // sqls = "SELECT name_student FROM brothers";
                sqls = "SELECT name FROM student ORDER BY `student`.`id` DESC";

                MySqlCommand commands;
                commands = new MySqlCommand(sqls, databaseConnection);


                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {                            //ID                               
                    outputs = outputs + myaReaders.GetString(0) + "\n";

                    comboBox1.Items.Add(myaReaders.GetString(0));
                }
                myaReaders.Close();



            }


            catch (Exception)
            {

            }
        }


        private void showStudentPayment_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;

            int index = comboBox1.FindString(name_student);
            comboBox1.SelectedIndex = index;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_student_when_click_student();

        }



        private void show_student_when_click_student()
        {
           string sql_name, outputs = "";

             name_stu = comboBox1.SelectedItem.ToString();
            sql_name = "SELECT id FROM student WHERE  name='" + name_stu + "'";

            MySqlCommand commands;
            commands = new MySqlCommand(sql_name, databaseConnection);


            MySqlDataReader myaReader_name = commands.ExecuteReader();

            while (myaReader_name.Read())
            {                            //ID                               
                outputs = outputs + myaReader_name.GetString(0) + "\n";

                 id=myaReader_name.GetString(0);
            }
            myaReader_name.Close();




            try
            {
                String sqls, outputs2 = "", outputtt="";

                sqls = "SELECT tuition_fee,uniform,transportation,public_books,private_books,others,sum,date_time,receiver_name FROM payments WHERE  student_id='" + id + "'";


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqls, databaseConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView1.Rows.Clear();

                foreach (DataRow datarow in dataTable.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = datarow[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = datarow[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = datarow[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = datarow[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = datarow[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = datarow[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = datarow[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = datarow[7].ToString();
                    //dataGridView1.Rows[n].Cells[8].Value = datarow[8].ToString();
                   string receipt_id= datarow[8].ToString();
                    string sqlll = "SELECT user_name FROM login WHERE  id='" + receipt_id + "' ";

                    MySqlCommand commanddd = new MySqlCommand(sqlll, databaseConnection);


                    MySqlDataReader myaReaderrr = commanddd.ExecuteReader();

                    while (myaReaderrr.Read())
                    {                            //ID                               
                                                 // outputtt = outputtt + myaReaderrr.GetString(1) + "\n";

                        dataGridView1.Rows[n].Cells[8].Value=myaReaderrr.GetString(0);
                    }
                    myaReaderrr.Close();

                }

            }


            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            percent();

        }


        private void percent()
        {
            string sql_id_student = "", student_id="", sum_orig="", sql_id_payment="", sum_pay="",start_date="";
            double sum_original = 0, div=0, b=0;
            sql_id_student = "SELECT `id`,`sum_original`,`start_date` FROM student WHERE name='" + comboBox1.Text + "'";

            MySqlCommand command_name = new MySqlCommand(sql_id_student, databaseConnection);

            MySqlDataReader myaReader_name1 = command_name.ExecuteReader();
            while (myaReader_name1.Read())
            {
                student_id = myaReader_name1.GetString(0);
                sum_orig = myaReader_name1.GetString(1);
                start_date = myaReader_name1.GetString(2);

            }
            myaReader_name1.Close();
            sum_original = double.Parse(sum_orig);



            div = sum_original / 270;
            DateTime now = DateTime.Now;
            //string currentDate = now.ToString("dd/MM/yyyy");
            string sub = now.Subtract(Convert.ToDateTime(start_date)).Days.ToString();
            int days = int.Parse(sub);

            sql_id_payment = "SELECT `sum` FROM payments WHERE student_id='" + student_id + "'";

            MySqlCommand command_pay = new MySqlCommand(sql_id_payment, databaseConnection);

            MySqlDataReader myaReader_pay = command_pay.ExecuteReader();
            while (myaReader_pay.Read())
            {
                sum_pay = myaReader_pay.GetString(0);
                double a = double.Parse(sum_pay);
                b += a;

            }
            myaReader_pay.Close();
            int q = Convert.ToInt32(b - (div * days));


            MessageBox.Show("تقريباً" + "\t" + q.ToString() + "\t" + " المبلغ الفائض من دفعات الطالب ");


        }



        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }
    }
}
