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
    public partial class showSalary : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;
        string employee_id;

        public showSalary()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);

            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }

            loading_employee();


        }

        private void loading_employee()
        {

            try
            {

                String sql, output = "";

                sql = "SELECT id,name FROM employee";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {


                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_list_Employee.Items.Add(myaReader.GetString(1));

                }
                myaReader.Close();

            }

            catch (Exception)
            {

            }
        }



        private void showSalary_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_emp = shard.Name;

            int index = comboBox_list_Employee.FindString(name_emp);
            comboBox_list_Employee.SelectedIndex = index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            show3();

        }

        private void show3()
        {
            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            string query = "SELECT month_no,year_no,premiums ,tours,rewards,insurance,discounts,net_salary,comments FROM financial_reports WHERE employee_id='" + employee_id + "' AND year_no='" + year_no + "' AND month_no='" + month_no + "'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = myreader.GetString(0);
                dataGridView3.Rows[n].Cells[1].Value = myreader.GetString(1);
                dataGridView3.Rows[n].Cells[2].Value = myreader.GetString(2);
                dataGridView3.Rows[n].Cells[3].Value = myreader.GetString(3);
                dataGridView3.Rows[n].Cells[4].Value = myreader.GetString(4);
                dataGridView3.Rows[n].Cells[5].Value = myreader.GetString(5);
                dataGridView3.Rows[n].Cells[6].Value = myreader.GetString(6);
                dataGridView3.Rows[n].Cells[7].Value = myreader.GetString(7);
                dataGridView3.Rows[n].Cells[8].Value = myreader.GetString(8);
            }
            myreader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
        }

        private void comboBox_list_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                String sql = "";

                sql = "SELECT id FROM employee WHERE name ='" + comboBox_list_Employee.SelectedItem.ToString() + "'";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {

                    employee_id = myaReader.GetString(0);

                }
                myaReader.Close();

                //MessageBox.Show(employee_id);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
