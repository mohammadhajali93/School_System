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

    

    public partial class Salary_revealed : Form
    {
        //        1
        connection con = new connection();
        MySqlConnection databaseConnection;

        double premiums_final_discounts = 0.0;
        double tours_final_discounts = 0.0;
        double rewards_final_discounts = 0.0;
        double insurance_final_discounts = 0.0;
        double discounts_final_discounts = 0.0;

        double salary_value_discounts = 0.0;

        double salary = 0.0;
        double dis = 0.0;
        double ins_sal;
        double ins_percent;
        double net_sal3;
        double remaind_salary = 0.0;

        double net_sal1;
        double net_sal2;
        double ins;
        double net_salary;
        double salary_updated;

        public Salary_revealed()
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

                sql = "SELECT id,name,salary FROM employee";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_list_Employee.Items.Add(myaReader.GetString(1));

                    // salary = double.Parse(myaReader.GetString(2));
                }

                myaReader.Close();

            }

            catch (Exception)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm Employee = new EmployeeForm();
            Employee.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate_salary();
        }

        private void calculate_salary()
        {
            String sql1, employee_id = "";
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

            string query = comboBox_list_Employee.Text;

            if (query == "")
            {
                MessageBox.Show("Please insert some sql query");
                return;
            }


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;

            salary_class salary_Class = new salary_class();

            double reward = 0, tou = 0, premiu = 0, borrows = 0;
            String tour = "", rewards = "", premiums = "";

            if (txt_rewards.Text == "" || txt_premiums.Text == "" || txt_tours.Text == "")
            {
                reward = 0; tou = 0; premiu = 0;
            }
            else
            {

                salary_Class.Premiums = txt_premiums.Text;
                premiums = salary_Class.Premiums; //  العلاوات
                premiu = double.Parse(txt_premiums.Text);


                salary_Class.Tours = txt_tours.Text;
                tour = salary_Class.Tours;   // الجولات 
                tou = double.Parse(txt_tours.Text);

                salary_Class.Rewards = txt_rewards.Text;
                rewards = salary_Class.Rewards;   //  المكافآت
                reward = double.Parse(txt_rewards.Text);
            }





            salary_Class.Year_no = date_year.SelectedItem.ToString();
            String year_no = salary_Class.Year_no;

            salary_Class.Month_no = date_month.SelectedItem.ToString();
            String month_no = salary_Class.Month_no;


            salary_Class.Insurance = txt_insurance.Text;
            String insurance = salary_Class.Insurance;  // التأمين
            ins = double.Parse(txt_insurance.Text);


            salary_Class.Discounts = comboBox_discounts.SelectedItem.ToString();
            String discounts1 = salary_Class.Discounts;

            salary_Class.Discounts = txt_discounts.Text;
            String discounts2 = salary_Class.Discounts;

            double disc2 = double.Parse(txt_discounts.Text);


            double disc = double.Parse(comboBox_discounts.SelectedItem.ToString());
            //MessageBox.Show("disc : " + disc);
            //double discs = salary/30;
            //MessageBox.Show("discs : " + discs);
            // MessageBox.Show("salary : " + salary);
            dis = disc * (salary / 30);
            //MessageBox.Show("dis : " + dis);
            double discounts = dis + disc2;   //  الخصم

            // salary_Class.Borrow = txt_borrows.Text;
            //String borrow = salary_Class.Borrow;   //  السلف
            //borrows = double.Parse(txt_borrows.Text);

            // salary_Class.Day_no = comboBox_dayno_borrows.SelectedItem.ToString();
            //String day_no = salary_Class.Day_no;   //  يوم السلفة
            //day_no = double.Parse(textBox8.Text);


            salary_Class.Comments = txt_Comments.Text;
            String comments = salary_Class.Comments;  // ملاحظات

            salary_Class.Net_salary = txt_netSalary.Text;



            try
            {






                String sql = "";

                sql = "SELECT id FROM financial_reports WHERE employee_id='" + employee_id + "'";

                MySqlCommand command;
                string found = "";
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {

                    found = myaReader.GetString(0);
                }
                myaReader.Close();

                if (found == "")
                {
                    MessageBox.Show("غير موجود");




                    ins_percent = ins / 100;
                    // MessageBox.Show("ins_percent : " + ins_percent);
                    ins_sal = ins_percent * salary;//salary - (ins * salary);
                                                   // MessageBox.Show("ins_salary : " + ins_sal);


                    net_sal1 = (premiu + tou + reward);
                    net_sal2 = (ins_sal + discounts);                   // borrows
                    if (reward == 0 || premiu == 0 || tou == 0)
                    {
                        //net_sal3 = net_sal2;
                    }
                    else
                    {

                        if ((net_sal1 - net_sal2) < 0)
                        {
                            net_sal3 = (net_sal2) - (net_sal1);
                        }
                        else
                        {
                            net_sal3 = (net_sal1) - (net_sal2);
                        }
                    }
                    //MessageBox.Show("net_sal1 : " + net_sal1);
                    //MessageBox.Show("net_sal2 : " + net_sal2);
                    // MessageBox.Show("net_sal2 : " + net_sal3);
                    //MessageBox.Show("borrows :" + borrows);



                    net_salary = (salary) - (net_sal3);
                    //double net_new_salary = (net_salary)- (ins_sal);
                    txt_netSalary.Text = net_salary + "";
                    //MessageBox.Show("net_salary : " + net_salary);

                    //MessageBox.Show(employee_id + "..........." + salary);

                    commandDatabase.CommandText = "INSERT INTO financial_reports(id,year_no, month_no, premiums, tours, rewards,insurance,discounts,employee_id,net_salary,comments)VALUES(NULL,'" + year_no + "','" + month_no + "','" + premiu + "','" + tou + "','" + reward + "','" + ins_sal + "','" + discounts + "','" + employee_id + "','" + net_salary + "','" + comments + "')";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();

                    MessageBox.Show("insert INTO financial_reports successfully");


                }
                else
                {

                    String year = "", mounth = "", sqls3 = "";
                    sqls3 = "SELECT year_no,month_no FROM financial_reports WHERE employee_id='" + employee_id + "'";

                    MySqlCommand commands3;

                    commands3 = new MySqlCommand(sqls3, databaseConnection);


                    MySqlDataReader myaReaders3 = commands3.ExecuteReader();

                    while (myaReaders3.Read())
                    {

                        year = myaReaders3.GetString(0);

                        mounth = myaReaders3.GetString(1);

                    }
                    myaReaders3.Close();


                    if (year == year_no && mounth == month_no)
                    {



                        String sqls, net_selery_final_discounts = "";




                        sqls = "SELECT net_salary ,premiums ,tours , rewards,insurance ,discounts FROM financial_reports WHERE employee_id='" + employee_id + "' AND year_no='" + year_no + "' AND month_no='" + month_no + "'";

                        MySqlCommand commands;

                        commands = new MySqlCommand(sqls, databaseConnection);


                        MySqlDataReader myaReaders = commands.ExecuteReader();

                        while (myaReaders.Read())
                        {

                            net_selery_final_discounts = myaReaders.GetString(0);           //290
                            premiums_final_discounts = double.Parse(myaReaders.GetString(1));
                            tours_final_discounts = double.Parse(myaReaders.GetString(2));
                            rewards_final_discounts = double.Parse(myaReaders.GetString(3));
                            insurance_final_discounts = double.Parse(myaReaders.GetString(4));
                            discounts_final_discounts = double.Parse(myaReaders.GetString(5));



                        }

                        premiums_final_discounts += premiu;
                        tours_final_discounts += tou;
                        rewards_final_discounts += reward;
                        insurance_final_discounts += ins_sal;
                        discounts_final_discounts += discounts;

                        myaReaders.Close();
                        salary_value_discounts = salary - double.Parse(net_selery_final_discounts);
                        //MessageBox.Show("net_selery_final_discounts : " + net_selery_final_discounts);
                        //MessageBox.Show("salary_value_discounts : " + salary_value_discounts);



                        ins_percent = ins / 100;
                        //MessageBox.Show("ins_percent : " + ins_percent);
                        ins_sal = ins_percent * salary;//salary - (ins * salary);
                                                       //MessageBox.Show("ins_sal : " + ins_sal);


                        net_sal1 = (premiu + tou + reward);
                        net_sal2 = (ins_sal + discounts);                  //borrows
                                                                           //if (reward == 0 || premiu == 0 || tou == 0)
                                                                           //{
                                                                           //    //net_sal3 = net_sal2;
                                                                           //    MessageBox.Show("Enter number " );

                        //}
                        //else
                        //{

                        if ((net_sal1 - net_sal2) < 0)
                        {
                            net_sal3 = (net_sal2) - (net_sal1);
                            net_salary = (salary) - (net_sal3);
                        }
                        else
                        {
                            net_sal3 = (net_sal1) - (net_sal2);
                            net_salary = (salary) + (net_sal3);

                        }
                        //}
                        //MessageBox.Show("net_sal1 : " + net_sal1);
                        //MessageBox.Show("net_sal2 : " + net_sal2);
                        // MessageBox.Show("net_sal3 : " + net_sal3);
                        // MessageBox.Show("borrows :" + borrows);






                        //double net_new_salary = (net_salary)- (ins_sal);
                        txt_netSalary.Text = net_salary + "";
                        //MessageBox.Show("salary : " + salary);
                        //MessageBox.Show("net_salary : " + net_salary);

                        //MessageBox.Show("employee_id : " + employee_id + "..........." + "salary : " + salary);





                        /*commandDatabase.CommandText = "INSERT INTO financial_reports(id,year_no, month_no, premiums, tours, rewards,insurance,discounts,employee_id,net_salary,comments)VALUES(NULL,'" + year_no + "','" + month_no + "','" + premiu + "','" + tour + "','" + rewards + "','" + ins_sal + "','" + discounts + "','" + employee_id + "','" + net_salary + "','" + comments + "')";
                        commandDatabase.ExecuteNonQuery();
                        commandDatabase.Dispose();*/


                        remaind_salary = salary - net_salary;
                        //MessageBox.Show("remaind_salary : " + remaind_salary);

                        salary_updated = salary - (remaind_salary + salary_value_discounts);
                        txt_netSalary.Text = salary_updated + "";

                        //MessageBox.Show("salary_updated : " + salary_updated);


                        // , , rewards,insurance ,discounts

                        commandDatabase.CommandText = "Update financial_reports set net_salary='" + salary_updated + "',premiums='" + premiu + "',tours='" + tou + "',rewards='" + rewards + "',insurance='" + ins_sal + "',discounts='" + discounts + " ' WHERE employee_id = '" + employee_id + "' AND year_no = '" + year_no + "' AND month_no = '" + month_no + "'";
                        commandDatabase.ExecuteNonQuery();
                        commandDatabase.Dispose();

                        MessageBox.Show(" Update financial_reports ");


                    }
                    /* else
                    {
                         double ins_percent = ins / 100;
                         //MessageBox.Show("ins_percent : " + ins_percent);
                         double ins_sal = ins_percent * salary;//salary - (ins * salary);
                         //MessageBox.Show("ins_salary : " + ins_sal);
                         double net_sal3 = 0.0;

                         double net_sal1 = (premiu + tou + reward);
                         double net_sal2 = (ins_sal + discounts);   // borrows
                         if (reward == 0 || premiu == 0 || tou == 0)
                         {
                             net_sal3 = net_sal2;
                         }
                         else
                         {

                             if ((net_sal1 - net_sal2) < 0)
                             {
                                 net_sal3 = (net_sal2) - (net_sal1);
                             }
                             else
                             {
                                 net_sal3 = (net_sal1) - (net_sal2);
                             }
                         }
                         //MessageBox.Show("net_sal1 : " + net_sal1);
                         //MessageBox.Show("net_sal2 : " + net_sal2);
                         //MessageBox.Show("net_sal2 : " + net_sal3);
                         //MessageBox.Show("borrows :" + borrows);



                         double net_salary = (salary) - (net_sal3);
                         //double net_new_salary = (net_salary)- (ins_sal);
                         txt_netSalary.Text = net_salary + "";
                         //MessageBox.Show("net_salary : " + net_salary);

                         //MessageBox.Show(employee_id + "..........." + salary);

                         commandDatabase.CommandText = "INSERT INTO financial_reports(id,year_no, month_no, premiums, tours, rewards,insurance,discounts,employee_id,net_salary,comments)VALUES(NULL,'" + year_no + "','" + month_no + "','" + premiu + "','" + tour + "','" + rewards + "','" + ins_sal + "','" + discounts + "','" + employee_id + "','" + net_salary + "','" + comments + "')";
                         commandDatabase.ExecuteNonQuery();
                         commandDatabase.Dispose();

                         MessageBox.Show("insert INTO financial_reports successfully");
                     }*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            /*
                        string query2 = comboBox_list_Employee.Text;

                        if (query == "")
                        {
                            MessageBox.Show("Please insert some sql query");
                            return;

                        }

                        MySqlCommand commandDatabase2 = new MySqlCommand(query, databaseConnection);

                        commandDatabase2.CommandTimeout = 60;

                        //    double salary = 0.0;
                        try
                        {
                            //commandDatabase2.CommandText = "INSERT INTO borrowing(id,ID_employee, date_borrow, day_borrow, Amount, month_borrow)VALUES(NULL,'" + employee_id + "','" + year_no + "','" + day_no + "','" + borrows + "','" + month_no + "')";
                            // commandDatabase2.ExecuteNonQuery();
                            //commandDatabase2.Dispose();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        */
        }


        private void Salary_revealed_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBorring formborrowing = new FormBorring();
            formborrowing.Show();
        }
        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
           ctrl.BackColor = Color.White;
        }
    }
}
