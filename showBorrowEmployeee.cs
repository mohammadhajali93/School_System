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
    public partial class showBorrowEmployeee : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;
        string employee_id;

        public showBorrowEmployeee()
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


        private void showBorrowEmployeee_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_emp = shard.Name;

            int index = comboBox_list_Employee.FindString(name_emp);
            comboBox_list_Employee.SelectedIndex = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show2();

        }

        private void show2()
        {

            salary_class salary_Class = new salary_class();

            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;

            string query = "SELECT day_borrow,month_borrow,date_borrow ,Amount FROM borrowing WHERE ID_employee='" + employee_id + "' AND date_borrow='" + year_no + "' AND month_borrow='" + month_no + "'";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = myreader.GetString(0);
                dataGridView2.Rows[n].Cells[1].Value = myreader.GetString(1);
                dataGridView2.Rows[n].Cells[2].Value = myreader.GetString(2);
                dataGridView2.Rows[n].Cells[3].Value = myreader.GetString(3);
            }
            myreader.Close();

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



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_list_Employee_SelectedIndexChanged_1(object sender, EventArgs e)
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
