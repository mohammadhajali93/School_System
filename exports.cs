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
    public partial class exports : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();

        double sum_Month_salary, sum_year_salary, sum_Month_borrowing, sum_year_borrowing = 0.0, sum_year_expenses = 0.0, sum_Month_expenses=0.0, sum_year_uniform=0.0, sum_year_book=0.0;

        public exports()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {

                databaseConnection.Open();
            }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }


        }

        private void view_year_exports()
        {
            string year = date_year.SelectedItem.ToString();


            string query = "SELECT price FROM expenses WHERE  year='" + year + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_year_expenses += double.Parse(datarow[0].ToString());

                label7.Text = sum_year_expenses + " JD";

            }
           // MessageBox.Show("sum_year_expense : " + sum_year_expenses);
           

        }

        private void view_monthly_exports()
        {
            string year = date_year.SelectedItem.ToString();


            string months = date_month.SelectedItem.ToString();

            string query = "SELECT   price FROM expenses WHERE  month ='" + months + "'  AND year='" + year + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_Month_expenses += double.Parse(datarow[0].ToString());

                label7.Text = sum_Month_expenses + " JD";

            }
           // MessageBox.Show("sum_Month_expense : " + sum_Month_expenses);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validateMonth()) { 
            label8.Text = "";
            sum_Month_salary = 0.0;
            view_monthly_salaries();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (validateYear())
            {
                label8.Text = "";
                sum_year_salary = 0.0;
                view_year_salaries();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateMonth())
            {
                label6.Text = "";
                sum_Month_borrowing = 0.0;
                view_monthly_borrowing();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (validateYear()) {
                label6.Text = "";
                sum_year_borrowing = 0.0;
                view_year_borrowing();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateMonth())
            {

                label7.Text = "";
                sum_Month_expenses = 0.0;
                view_monthly_exports();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (validateYear())
            {
                label7.Text = "";
                sum_year_expenses = 0.0;
                view_year_exports();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (validateYear())
            {
                label12.Text = "";
                sum_year_uniform = 0.0;
                view_year_uniform();
            }
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (validateYear())
            {
                label14.Text = "";
                sum_year_book = 0.0;
                view_year_books();
            }
           

        }

       
        private void date_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            label1.Text = 0.0 + "";
            label2.Text = 0.0 + "";
            label6.Text = 0.0 + "";
            label7.Text = 0.0 + "";
            label8.Text = 0.0 + "";
            label12.Text = 0.0 + "";
            label14.Text = 0.0 + "";
        }

        private void date_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            label1.Text = 0.0 + "";
            label2.Text = 0.0 + "";
            label6.Text = 0.0 + "";
            label7.Text = 0.0 + "";
            label8.Text = 0.0 + "";
            label12.Text = 0.0 + "";
            label14.Text = 0.0 + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (validateMonth())
            {

                sum_year_expenses = 0.0;
                sum_year_salary = 0.0;
                sum_year_borrowing = 0.0;
                sum_year_book = 0.0;
                sum_year_uniform = 0.0;

                label2.Text = 0.0 + "";
                double x = sum_Month_borrowing + sum_Month_salary + sum_Month_expenses ;

                label1.Text = "" + x;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (validateYear())
            {

                sum_Month_expenses = 0.0;
                sum_Month_salary = 0.0;
                sum_Month_borrowing = 0.0;
                label1.Text = 0.0 + "";
                double x = sum_year_borrowing + sum_year_salary + sum_year_expenses + sum_year_uniform + sum_year_book;

                label2.Text = "" + x;
            }
        }

        private void view_year_borrowing()
        {

            salary_class salary_Class = new salary_class();



            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            string query = "SELECT Amount FROM borrowing WHERE  date_borrow='" + year_no + "'";


            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_year_borrowing += double.Parse(datarow[0].ToString());

                label6.Text = sum_year_borrowing + " JD";

            }
           // MessageBox.Show("sum_year_borrowing : " + sum_year_borrowing);


        }

        private void view_monthly_borrowing()
        {

            salary_class salary_Class = new salary_class();

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            string query = "SELECT Amount FROM borrowing WHERE  month_borrow ='" + month_no + "' AND date_borrow='" + year_no + "'";


            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_Month_borrowing += double.Parse(datarow[0].ToString());

                label6.Text = sum_Month_borrowing + " JD";

            }
           // MessageBox.Show("sum_Month_borrowing : " + sum_Month_borrowing);

        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        

        private void view_year_salaries()
        {

            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;


            string query = "SELECT DISTINCT employee_id,net_salary FROM financial_reports WHERE  year_no='" + year_no + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = datarow[1].ToString();
                sum_year_salary += double.Parse(datarow[1].ToString());

                label8.Text = sum_year_salary + " JD";

            }
          //  MessageBox.Show("sum_year_salary : " + sum_year_salary);
        }


        private void view_monthly_salaries()
        {

            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            string query = "SELECT DISTINCT employee_id, net_salary FROM financial_reports WHERE  month_no ='" + month_no + "' AND year_no='" + year_no + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = datarow[1].ToString();
                sum_Month_salary += double.Parse(datarow[1].ToString());

                label8.Text = sum_Month_salary + " JD";

            }
           // MessageBox.Show("sum_Month_salary : " + sum_Month_salary);
        }
        private bool validateMonth() {
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
            return true;

        }
        private bool validateYear()
        {
            if (date_year.Text == "")
            {
                myvalidation.ValidationMessage(date_year, "حدد السنة", "خطأ في الإدخال");
                return false;
            }
            
            return true;

        }


        private void view_year_books()
        {
            string year = date_year.SelectedItem.ToString();
            //salary_class salary_Class = new salary_class();

            //salary_Class.Year_no = date_year.SelectedItem.ToString();
            //String year_no = salary_Class.Year_no;

            string query = "SELECT books FROM payments WHERE  year_no ='" + year + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView5.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView5.Rows.Add();
                dataGridView5.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_year_book += double.Parse(datarow[0].ToString());

                label14.Text = sum_year_book + " JD";

            }
            MessageBox.Show("sum_year_book : " + sum_year_book);

        }


        private void view_year_uniform()
        {
            //salary_class salary_Class = new salary_class();

            //salary_Class.Year_no = date_year.SelectedItem.ToString();
            //String year_no = salary_Class.Year_no;

            string year = date_year.SelectedItem.ToString();
            

            string query = "SELECT uniform FROM payments WHERE  year_no ='" + year + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView4.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView4.Rows.Add();
                dataGridView4.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_year_uniform += double.Parse(datarow[0].ToString());

                label12.Text = sum_year_uniform + " JD";

            }
            MessageBox.Show("sum_year_uniform : " + sum_year_uniform);

        }

        private void exports_Load(object sender, EventArgs e)
        {

        }
    }
}
