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
    public partial class Revenues : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();

        double sum_Month_installment = 0.0;
        double sum_year_installment = 0.0;
        double sum_Month_discounts = 0.0;
        double sum_year_discounts = 0.0;



        public Revenues()
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

       

        private void view_Monthly_installment()
        {
            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            string query = "SELECT sum FROM payments WHERE  month_no ='" + month_no + "' AND year_no='" + year_no + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_Month_installment += double.Parse(datarow[0].ToString());

                label8.Text = sum_Month_installment + " JD";

            }
           // MessageBox.Show("sum_Month_installment : " + sum_Month_installment);
        }

       

        private void view_year_installment()
        {
            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;


            string query = "SELECT sum FROM payments WHERE year_no='" + year_no + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_year_installment += double.Parse(datarow[0].ToString());

                label8.Text = sum_year_installment + " JD";

            }
          //  MessageBox.Show("sum_year_installment : " + sum_year_installment);

        }

       

        private void view_monthly_discounts()
        {
            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            string query = "SELECT discounts FROM financial_reports WHERE  month_no ='" + month_no + "' AND year_no='" + year_no + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_Month_discounts += double.Parse(datarow[0].ToString());

                label6.Text = sum_Month_discounts + " JD";

            }
          //  MessageBox.Show("sum_Month_discounts : " + sum_Month_discounts);
        }

       

        private void view_year_discounts()
        {
            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;


            string query = "SELECT discounts FROM financial_reports WHERE  year_no='" + year_no + "'";

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView2.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = datarow[0].ToString();
                sum_year_discounts += double.Parse(datarow[0].ToString());

                label6.Text = sum_year_discounts + " JD";

            }
          //  MessageBox.Show("sum_year_discounts : " + sum_year_discounts);

        }

       

        private void date_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            label1.Text = 0.0 + "";
            label2.Text = 0.0 + "";
            label6.Text = 0.0 + "";
            label8.Text = 0.0 + "";
        }

        private void date_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            label1.Text = 0.0 + "";
            label2.Text = 0.0 + "";
            label6.Text = 0.0 + "";
            label8.Text = 0.0 + "";
        }

        private void Revenues_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (validateMonth())
            {
                label8.Text = "";
                sum_Month_installment = 0.0;
                view_Monthly_installment();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (validateYear())
            {
            label8.Text = "";
            sum_year_installment = 0.0;
            view_year_installment();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (validateMonth())
            {
                label6.Text = "";
                sum_Month_discounts = 0.0;
                view_monthly_discounts();
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

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (validateYear())
            {
                label6.Text = "";
                sum_year_discounts = 0.0;
                view_year_discounts();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (validateMonth())
            {
                sum_year_installment = 0.0;
                sum_year_discounts = 0.0;


                label2.Text = 0.0 + " JD";
                double x = sum_Month_installment + sum_Month_discounts;

                label1.Text = x + " JD";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (validateYear())
            {
                sum_Month_installment = 0.0;
                sum_Month_discounts = 0.0;

                label1.Text = 0.0 + " JD";
                double x = sum_year_installment + sum_year_discounts;

                label2.Text = x + " JD";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
    }
}
