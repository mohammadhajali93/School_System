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
    public partial class editEmployee : Form
    {


        string select_name_role;

        string[] id_employee = new string[2000];
        string[] id_role = new string[2000];
        string[] name_role = new string[2000];
        MyValidation myvalidation = new MyValidation();

        connection con = new connection();
        MySqlConnection databaseConnection;


        public editEmployee()
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

                String sql;

                sql = "SELECT id,name   FROM employee";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {

                    comboBox_list_Employee.Items.Add(myaReader.GetString(1));

                    id_employee[i] = myaReader.GetString(0);
                    i++;
                }
                myaReader.Close();

            }

            catch (Exception)
            {

            }

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

                DialogResult dialog = MessageBox.Show("هل متأكد من عملية تعديل بيانات الموظف   " + comboBox_list_Employee.SelectedItem.ToString(), "تعديل بيانات الطالب ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    update_employee();

                    MessageBox.Show("تم  تعديل بيانات الموظف     " + comboBox_list_Employee.SelectedItem.ToString());



                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم بتعديل بيانات الموظف     ");

                }

            }
            
            

                
            

        }

        private bool isValidate()
        {

            if (comboBox_list_Employee.SelectedItem == null)
            {
                myvalidation.ValidationMessage(comboBox_list_Employee, "أختر الموظف أولاً لإجراء التعديل عليه", "خطأ في الإدخال");

                return false;
            }
            if (textBox1.Text == "")
            {
                myvalidation.ValidationMessage(textBox1, " ادخل اسم الموظف بعد التعديل ", "خطأ في الإدخال");
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

        private void update_employee()
        {

            string employee_id = "";

            string select_employee = comboBox_list_Employee.SelectedItem.ToString();
            int select = comboBox_list_Employee.SelectedIndex;

            for (int i = 0; i < 2000; i++)
            {
                if (select == i)
                {
                    employee_id = id_employee[i];
                }
            }


            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {

                // string select_employee = comboBox_list_Employee.SelectedItem.ToString();


                commandDatabase.CommandText = "Update employee set name ='" + textBox1.Text + "',salary='" + txt_baseSalary.Text + "',start_date='" + date_startDate.Text + "',end_date='" + date_endDate.Text + "',role='" + comboBox_Role.SelectedItem.ToString() + "'WHERE id ='" + employee_id + "'";
                commandDatabase.ExecuteNonQuery();
                commandDatabase.Dispose();

                MessageBox.Show("تم تعديل الموظف بنجاح");
                empty_texts();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query Error :" + e.Message);
            }



        }



        private void comboBox_list_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            chose_employee();

        }


        private void chose_employee()
        {
            string employee_id = "";

            string select_employee = comboBox_list_Employee.SelectedItem.ToString();
            int select = comboBox_list_Employee.SelectedIndex;

            for (int i = 0; i < 2000; i++)
            {
                if (select == i)
                {
                    employee_id = id_employee[i];
                }
            }
            String sql2;


            sql2 = "SELECT id,name ,salary ,start_date ,end_date ,role  FROM employee WHERE id ='" + employee_id + "'";

            MySqlCommand commands;
            commands = new MySqlCommand(sql2, databaseConnection);

            MySqlDataReader myaReader2 = commands.ExecuteReader();
            try
            {

                while (myaReader2.Read())
                {

                    if (!myaReader2.IsDBNull(1)) { textBox1.Text = myaReader2.GetString(1); }


                    if (!myaReader2.IsDBNull(2)) { txt_baseSalary.Text = myaReader2.GetString(2); }


                    if (!myaReader2.IsDBNull(5))
                    {
                        select_name_role = myaReader2.GetString(5);
                    }

                    if (!myaReader2.IsDBNull(3))
                    { date_startDate.Text = myaReader2.GetString(3); }
                    if (!myaReader2.IsDBNull(4))
                    { date_endDate.Text = myaReader2.GetString(4); }


                }

                int index = comboBox_Role.FindString(select_name_role);
                comboBox_Role.SelectedIndex = index;

            }
            catch (Exception ex)
            {


            }
            myaReader2.Close();

        }

        private void editEmployee_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_emp = shard.Name;

            int index = comboBox_list_Employee.FindString(name_emp);
            comboBox_list_Employee.SelectedIndex = index;
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
        private void empty_texts()
        {
            comboBox_list_Employee.Text = "";
            textBox1.Text = "";
            txt_baseSalary.Text = "";
            comboBox_Role.Text = "";

        }
    }
}
