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
    public partial class add_Employee : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();

        public add_Employee()
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
                MessageBox.Show("Error" + t.Message);
                return;
            }


        }

        private void add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm main = new EmployeeForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidate())
            {
                add_employee_validation();
            }
        }

        private bool isValidate()
        {


            if (txt_name_Employee.Text == "")
            {
                myvalidation.ValidationMessage(txt_name_Employee, "أدخل اسم الموظف", "خطأ في الإدخال");
                return false;
            }


            if (txt_baseSalary.Text == "")
            {
                myvalidation.ValidationMessage(txt_baseSalary, "أدخل الراتب الشهري ", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_Role.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_Role, "اختار دور الموظف", "خطأ في الإدخال");
                return false;
            }
            

            return true;
        }

        private void add_employee_validation()
        {
           
             if (txt_name_Employee.Text == "")
            {
                MessageBox.Show("أدخل اسم الموظف ");
            }
            else if (txt_baseSalary.Text == "")
            {
                MessageBox.Show("أدخل الراتب ");
            }
            else if (date_startDate.Text == "")
            {
                MessageBox.Show("أدخل تاريخ البدء ");
            }
            else if (date_endDate.Text == "")
            {
                MessageBox.Show("أدخل تاريخ الانتهاء ");
            }
            else if (comboBox_Role.Text == "")
            {
                MessageBox.Show("أدخل  دور الموظف ");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("هل متأكد من إدخال معلومات موظف  جديد ", "تسجيل معلومات الموظف ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    insert_employee();

                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم يتم تسجيل معلومات الموظف ");

                }

            }

        }




        private void insert_employee()
        {
            


            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                Employee employee = new Employee();



                employee.Name = txt_name_Employee.Text;
                String name = employee.Name;

                employee.Salary = txt_baseSalary.Text;
                String salary = employee.Salary;

                employee.Start_date = date_startDate.Text;
                String start_date = employee.Start_date;

                employee.End_date = date_endDate.Text;
                String end_date = employee.End_date;

                employee.Role = comboBox_Role.SelectedItem.ToString();
                String role = employee.Role;





                commandDatabase.CommandText = "INSERT INTO employee(id,name, salary, start_date, end_date, role)VALUES(NULL,'" + name + "','" + salary + "','" + start_date + "','" + end_date + "','" + role + "')";
                commandDatabase.ExecuteNonQuery();
                commandDatabase.Dispose();




                MessageBox.Show("تم تسجيل الموظف بنجاح");
                empty_texts();

            }
            catch (Exception e)
            {
                MessageBox.Show("Query Error :" + e.Message);
            }
        }

        private void role_Employee()
        {
            try
            {
                String r;

                r = "SELECT role FROM employee";

                MySqlCommand command;
                command = new MySqlCommand(r, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {
                    comboBox_Role.Items.Add(myaReader.GetString(5));
                }
                myaReader.Close();

            }

            catch (Exception)
            {

            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_revealed salary_Revealed = new Salary_revealed();
            salary_Revealed.Show();
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void empty_texts()
        {
            txt_name_Employee.Text = "";
            txt_baseSalary.Text = "";
            comboBox_Role.Text = "";
            
        }

    }
}
