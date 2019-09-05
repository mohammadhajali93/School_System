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
    public partial class Expenses_Show : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;

        MyValidation myvalidation = new MyValidation();

        double sum_Month_expenses = 0.0, sum_year_expenses = 0.0;

        public Expenses_Show()
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

            loading_expenses();
        }

        private void loading_expenses()
        {
            try
            {

                String sql = "";

                sql = "SELECT id,name FROM exp";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {
                    
                    comboBox_list_exp.Items.Add(myaReader.GetString(1));

                    
                }

                myaReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses expenses = new Expenses();
            expenses.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (validateMonth())
            {
                label7.Text = "";
                sum_Month_expenses = 0.0;
                show_expenses_month();
            }
            
        }

        private void show_expenses_month()

        {
            
            string id ="";
            string months = date_month.SelectedItem.ToString();
            string year = date_year.SelectedItem.ToString();

            String sql;

            sql = "SELECT id FROM exp WHERE name='" + comboBox_list_exp.SelectedItem.ToString() + "' ";

            MySqlCommand command2;
            command2 = new MySqlCommand(sql, databaseConnection);


            MySqlDataReader myaReader = command2.ExecuteReader();

            while (myaReader.Read())
            {
              id = myaReader.GetString(0);

            }


            myaReader.Close();


            string query = "SELECT price FROM expenses WHERE  id_exp ='" + id + "'  AND month ='" + months + "'  AND year='" + year + "'";

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
            MessageBox.Show("sum_Month_expense : " + sum_Month_expenses);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (validateYear())
            {
                label7.Text = "";
                sum_year_expenses = 0.0;
                show_expenses_year();
            }
            
        }

        private void show_expenses_year()
        {
            string id = comboBox_list_exp.SelectedItem.ToString();
            
            string year = date_year.SelectedItem.ToString();

            String sql;

            sql = "SELECT id FROM exp WHERE name='" + comboBox_list_exp.SelectedItem.ToString() + "' ";

            MySqlCommand command2;
            command2 = new MySqlCommand(sql, databaseConnection);


            MySqlDataReader myaReader = command2.ExecuteReader();

            while (myaReader.Read())
            {
                id = myaReader.GetString(0);

            }


            myaReader.Close();


            string query = "SELECT price FROM expenses WHERE  id_exp ='" + id + "'  AND year='" + year + "'";

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
            MessageBox.Show("sum_year_expenses : " + sum_year_expenses);
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

        private void comboBox_list_exp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView3.Rows.Clear();
            
            label7.Text = 0.0 + "";
           
        }

        private void date_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            label7.Text = 0.0 + "";
        }

        private void date_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            label7.Text = 0.0 + "";
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
    }
}
