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
    public partial class FormBorring : Form
    {

        double salary = 0.0;
        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();

        public FormBorring()
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

            loading_employee();


        }

        private void loading_employee()
        {


            try
            {

                String sql, output = "";

                sql = "SELECT id,name ,salary FROM employee";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {
                    //output = output + myaReader.GetString(1) + "\n";

                    comboBox_list_Employee.Items.Add(myaReader.GetString(1));

                    salary = double.Parse(myaReader.GetString(2));


                }
                myaReader.Close();

            }

            catch (Exception)
            {

            }
        }



        private void FormBorring_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_emp = shard.Name;

            int index = comboBox_list_Employee.FindString(name_emp);
            comboBox_list_Employee.SelectedIndex = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isValidate())
            {
                calculate_borrowing();

            }
        }

        private bool isValidate()
        {

            if (comboBox_list_Employee.SelectedItem == null)
            {
                myvalidation.ValidationMessage(comboBox_list_Employee, "أختر الموظف أولاً لإجراء التعديل عليه", "خطأ في الإدخال");

                return false;
            }
            if (txt_borrows.Text == "")
            {
                myvalidation.ValidationMessage(txt_borrows, " أدخل قيمة السلفة ", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_dayno_borrows.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_dayno_borrows, "أدخل يوم السلفة ", "خطأ في الإدخال");
                return false;
            }
            if (date_month.Text == "")
            {
                myvalidation.ValidationMessage(date_month, "اختار شهر السلفة", "خطأ في الإدخال");
                return false;
            }
            
                 if (date_year.Text == "")
            {
                myvalidation.ValidationMessage(date_year, "أدخل سنة السلفة", "خطأ في الإدخال");
                return false;
            }
            return true;
        }

        private void calculate_borrowing()
        {


            string query = comboBox_list_Employee.Text;

            if (query == "")
            {
                MessageBox.Show("Please insert some sql query");
                return;
            }


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;

            String sql1, employee_id = "";
            double borrows = 0.0;
            double salary = 0.0;

            try
            {
                salary_class salary_Class = new salary_class();

                String employee_name = comboBox_list_Employee.SelectedItem.ToString();
                sql1 = "SELECT id,name,salary FROM employee WHERE name='" + employee_name + "'";


                MySqlCommand command1;
                command1 = new MySqlCommand(sql1, databaseConnection);

                MySqlDataReader myaReader1 = command1.ExecuteReader();

                while (myaReader1.Read())
                {

                    employee_id = employee_id + myaReader1.GetString(0) + "\n";
                    salary = double.Parse(myaReader1.GetString(2));

                }
                myaReader1.Close();


                salary_Class.Borrow = txt_borrows.Text;
                String borrow = salary_Class.Borrow;   //  السلف
                borrows = double.Parse(txt_borrows.Text);

                salary_Class.Day_no = comboBox_dayno_borrows.SelectedItem.ToString();
                String day_no = salary_Class.Day_no;   //  يوم السلفة

                salary_Class.Year_no = date_year.SelectedItem.ToString();
                String year_no = salary_Class.Year_no;

                salary_Class.Month_no = date_month.SelectedItem.ToString();
                String month_no = salary_Class.Month_no;





                String sql22 = "";

                sql22 = "SELECT id FROM financial_reports WHERE employee_id='" + employee_id + "' AND year_no='" + year_no + "' AND month_no='" + month_no + "'";

                MySqlCommand command22;
                string found = "";
                command22 = new MySqlCommand(sql22, databaseConnection);


                MySqlDataReader myaReader22 = command22.ExecuteReader();

                while (myaReader22.Read())
                {

                    found = myaReader22.GetString(0);
                }
                myaReader22.Close();

                if (found != "")
                {
                    MessageBox.Show(" موجود");




                    String sqls = "";
                    double net_selery_final = 0.0;

                    double net_selery_final_borrowing = 0.0;

                    sqls = "SELECT net_salary FROM financial_reports WHERE employee_id='" + employee_id + "' AND year_no='" + year_no + "' AND month_no='" + month_no + "'";

                    MySqlCommand commands;

                    commands = new MySqlCommand(sqls, databaseConnection);



                    MySqlDataReader myaReaders = commands.ExecuteReader();

                    while (myaReaders.Read())
                    {

                        net_selery_final = double.Parse(myaReaders.GetString(0));



                    }
                    myaReaders.Close();

                    net_selery_final_borrowing = net_selery_final - borrows;
                   // MessageBox.Show("net_selery_final : " + net_selery_final);
                  //  MessageBox.Show("amount_borrowing : " + borrows);
                  //  MessageBox.Show("net_selery_final_borrowing : " + net_selery_final_borrowing);




                    commandDatabase.CommandText = "INSERT INTO borrowing(id,ID_employee, date_borrow, day_borrow, Amount, month_borrow)VALUES(NULL,'" + employee_id + "','" + year_no + "','" + day_no + "','" + borrows + "','" + month_no + "')";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();


                    label11.Text = net_selery_final_borrowing + "";

                    // commandDatabase.CommandText = "INSERT INTO financial_reports(id,year_no, month_no, premiums, tours, rewards,insurance,discounts,employee_id,net_salary,comments)VALUES(NULL,'" + year_no + "','" + month_no + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + employee_id + "','" + net_selery_final_borrowing + "','" + "" + "')";
                    //commandDatabase.ExecuteNonQuery();
                    //commandDatabase.Dispose();
                    // MessageBox.Show("insert new Salary ");


                    commandDatabase.CommandText = "Update financial_reports set net_salary='" + net_selery_final_borrowing + " ' WHERE employee_id = '" + employee_id + "' AND year_no = '" + year_no + "' AND month_no = '" + month_no + "'";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();
                    MessageBox.Show("تم تسجيل السلفة بنجاح ");
                    empty_texts();
                    //MessageBox.Show(" Update financial_reports ");

                }
                else
                {
                  //  MessageBox.Show("غير موجود");

                    commandDatabase.CommandText = "INSERT INTO borrowing(id,ID_employee, date_borrow, day_borrow, Amount, month_borrow)VALUES(NULL,'" + employee_id + "','" + year_no + "','" + day_no + "','" + borrows + "','" + month_no + "')";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();

                 


                    //String sqls = "";
                    //double net_selery_final = 0.0;

                    double net_selery_final_borrowing22 = 0.0;

                    net_selery_final_borrowing22 = salary - borrows;

                    label11.Text = net_selery_final_borrowing22 + "";

                  //  MessageBox.Show("net_selery_final_borrowing22: " + net_selery_final_borrowing22);


                    commandDatabase.CommandText = "INSERT INTO financial_reports(id,year_no, month_no, premiums, tours, rewards,insurance,discounts,employee_id,net_salary,comments)VALUES(NULL,'" + year_no + "','" + month_no + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + employee_id + "','" + net_selery_final_borrowing22 + "','" + "" + "')";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();
                    MessageBox.Show("تم تسجيل السلفة بنجاح ");
                    empty_texts();
                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void empty_texts()
        {
            // txt_name.SelectedItem = "";
            comboBox_list_Employee.Text = "";
            txt_borrows.Text = "";
            comboBox_dayno_borrows.Text = "";
            date_month.Text = "";
            date_year.Text = "";
        }


    }
}
