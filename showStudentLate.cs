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
    public partial class showStudentLate : Form
    {
        connection con = new connection();

        MySqlConnection databaseConnection;

        public showStudentLate()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            databaseConnection.Open();

        }




        private void showStudentLate_Load(object sender, EventArgs e)
        {
           
        }

        private void percent()
        {

            int month =int.Parse(comboBox1.SelectedItem.ToString());
            string num = "", sql_id_student = "", sql_id_payment = "", sum_pay = "";
            double sum_original = 0, summ = 0, div = 0, b = 0;
            
            string student_id="", student_name="", sum_orig="", sum="", start_date="";
            
            sql_id_student = "SELECT `id`,`name`,`sum_original`,`sum`,`start_date` FROM student ";

            MySqlCommand command_name = new MySqlCommand(sql_id_student, databaseConnection);

            MySqlDataReader myaReader_name1 = command_name.ExecuteReader();
            while (myaReader_name1.Read())
            {
                if (!myaReader_name1.IsDBNull(0)) { student_id = myaReader_name1.GetString(0); }
                if (!myaReader_name1.IsDBNull(1)) { student_name = myaReader_name1.GetString(1); }
                if (!myaReader_name1.IsDBNull(2)) { sum_orig = myaReader_name1.GetString(2); }
                if (!myaReader_name1.IsDBNull(3)) { sum = myaReader_name1.GetString(3); }
                if (!myaReader_name1.IsDBNull(4)) { start_date = myaReader_name1.GetString(4);
                   

                    }
                if (start_date!="")
                {
                    sum_original = double.Parse(sum_orig);
                    summ = double.Parse(sum);


                    div = sum_original / 270;

                    DateTime now = DateTime.Now;
                    //string currentDate = now.ToString("dd/MM/yyyy");
                    string sub = now.Subtract(Convert.ToDateTime(start_date)).Days.ToString();
                    int days = int.Parse(sub);

                    double must_pay = div * days;
                    double pay = sum_original - summ;
                    // double natu_situ=sum_original - must_pay;
                    if (must_pay - pay > 0 && must_pay - pay >= div * (month * 30))
                    {
                        int n = dataGridView1.Rows.Add();

                        dataGridView1.Rows[n].Cells[0].Value = student_name;
                    }

                }

            }
            myaReader_name1.Close();



            /*for (int i = 0; i < int.Parse(num); i++)
            {


                sql_id_payment = "SELECT `sum` FROM payments WHERE student_id='" + student_id[i] + "'";

                MySqlCommand command_pay = new MySqlCommand(sql_id_payment, databaseConnection);

                MySqlDataReader myaReader_pay = command_pay.ExecuteReader();
                while (myaReader_pay.Read())
                {
                    sum_pay = myaReader_pay.GetString(0);
                    double a = double.Parse(sum_pay);
                    b += a;

                }
                myaReader_pay.Close();*/
            
            //int q = Convert.ToInt32(b - (div * days));


            //MessageBox.Show("تقريباً" + "\t" + q.ToString() + "\t" + " المبلغ الفائض من دفعات الطالب ");


        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
                percent();
        }
    }
}
