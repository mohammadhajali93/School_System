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
    public partial class EmployeeForm : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;

        String nameee = "", num_employees = "", class_name = "", section_name = "";
        int num = 0;


        string[] name_employees, salary_employees, start_date_employees, end_date_employees, role_employees;
        

        public EmployeeForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Employee addEmployee = new add_Employee();
            addEmployee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void gridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridViewEmployees.Rows[e.RowIndex];
                nameee = row.Cells["name"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            showBorrowEmployeee showBorrEmp = new showBorrowEmployeee();
            showBorrEmp.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            showSalary showSal = new showSalary();
            showSal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            editEmployee editEmp = new editEmployee();
            editEmp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            Salary_revealed salary_Rev = new Salary_revealed();
            salary_Rev.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            shard.Name = nameee;

            this.Hide();
            FormBorring formBorr = new FormBorring();
            formBorr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            a();

            show();
        }
        private void a()
        {

            
            String count = "SELECT COUNT(*) FROM employee  ";
            MySqlCommand command = new MySqlCommand(count, databaseConnection);

            MySqlDataReader myaReader = command.ExecuteReader();

            while (myaReader.Read())
            {                                    //ID                             
                num_employees = num_employees + myaReader.GetString(0) + "\n";

                // MessageBox.Show("num_students" + num_students);
            }

            myaReader.Close();

            num = int.Parse(num_employees);

            name_employees = new string[num];
            salary_employees = new string[num];
            start_date_employees = new string[num];
            end_date_employees = new string[num];
            role_employees = new string[num];

        }

        private void show()
        {
            // string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=rekaz";
            MySqlConnection databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;
            

            string query = "SELECT * FROM `employee` ORDER BY `employee`.`id` DESC ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            gridViewEmployees.Rows.Clear();

            int q = 0;
            foreach (DataRow datarow in dataTable.Rows)
            {
                // int n = gvStudents.Rows.Add();
                //  gvStudents.Rows[n].Cells[0].Value = datarow[1].ToString();
                // gvStudents.Rows[n].Cells[1].Value = datarow[7].ToString();
                // gvStudents.Rows[n].Cells[2].Value = datarow[8].ToString();
                //gvStudents.Rows[n].Cells[3].Value = datarow[5].ToString();

                name_employees[q] = datarow[1].ToString();
                salary_employees[q] = datarow[2].ToString();
                start_date_employees[q] = datarow[3].ToString();
                end_date_employees[q] = datarow[4].ToString();
                role_employees[q] = datarow[5].ToString();

                q++;
            }


            int y = 0;
            int z = 0;
            for (int i = 0; i < num; i++)
            {

                




                int n = gridViewEmployees.Rows.Add();
                gridViewEmployees.Rows[n].Cells[0].Value = name_employees[i].ToString();
                gridViewEmployees.Rows[n].Cells[1].Value = salary_employees[i].ToString();
                gridViewEmployees.Rows[n].Cells[2].Value = start_date_employees[i].ToString();
                gridViewEmployees.Rows[n].Cells[3].Value = end_date_employees[i].ToString();
                gridViewEmployees.Rows[n].Cells[4].Value = role_employees[i].ToString();



            }

        }


    }
}
