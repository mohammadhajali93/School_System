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
    public partial class Daily_Fund : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;
        double sum_day_borrowing = 0.0, sum_day_expenses = 0.0;
        MyValidation myvalidation = new MyValidation();



        public Daily_Fund()
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

     

        private void show_borrowing()
        {
            salary_class salary_Class = new salary_class();

            salary_Class.Day_no = comboBox_dayno_borrows.SelectedItem.ToString();
            String day_no = salary_Class.Day_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            string query = "SELECT Amount FROM borrowing WHERE day_borrow='" + day_no + "' AND month_borrow ='" + month_no + "' AND date_borrow='" + year_no + "'";


            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_day_borrowing += double.Parse(datarow[0].ToString());

                label6.Text = sum_day_borrowing + " JD";

            }
            // MessageBox.Show("sum_Month_borrowing : " + sum_day_borrowing);
        }

        private void Daily_Fund_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateMonth())
            {
                label6.Text = "";
                sum_day_borrowing = 0.0;
                show_borrowing();

            }
         

        }
        private bool validateMonth()
        {
            //year and month
            if (date_year.Text == "")
            {
                myvalidation.ValidationMessage(date_year, "حدد السنة", "خطأ في الإدخال");
                return false;
            }
            if (date_month.Text == "")
            {
                myvalidation.ValidationMessage(date_month, "حدد الشهر", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_dayno_borrows.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_dayno_borrows, "حدد اليوم", "خطأ في الإدخال");
                return false;
            }
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateMonth())
            {
                label7.Text = "";
                sum_day_expenses = 0.0;
                show_expenses();

            }
        }

        private void show_expenses()
        {


            Expensess expensess = new Expensess();

            expensess.Day = comboBox_dayno_borrows.SelectedItem.ToString();
            string day= expensess.Day;

            expensess.Month = date_month.SelectedItem.ToString();
            String month = expensess.Month;

            expensess.Year = date_year.SelectedItem.ToString();
            String year = expensess.Year;

            string query = "SELECT price FROM expenses WHERE day='" + day + "' AND month ='" + month + "' AND year='" + year + "'";


            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_day_expenses += double.Parse(datarow[0].ToString());

                label7.Text = sum_day_expenses + " JD";

            }
            // MessageBox.Show("sum_Month_borrowing : " + sum_day_borrowing);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = (sum_day_borrowing + sum_day_expenses) + "JD";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
                }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
    }
}
