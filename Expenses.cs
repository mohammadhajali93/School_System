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
    public partial class Expenses : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();


        string[] id_exp = new string[2000];
        string output="";
        string consumer ;

        public Expenses()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            databaseConnection.Open();
            load_type_exp();


        }


        private void load_type_exp()
        {
            try
            {


                String sql;

                sql = "SELECT id,name FROM exp";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {

                    comboBox_type.Items.Add(myaReader.GetString(1));
                    id_exp[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Expenses_Load(object sender, EventArgs e)
        {
            loading_consumer_in_combobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {
                MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

                commandDatabase.CommandTimeout = 60;
                try
                {



                    string name_consumer = txt_name_consumer.SelectedItem.ToString();

                    string sql = "SELECT id,user_name FROM login WHERE user_name='" + name_consumer + "'";

                    MySqlCommand command;
                    command = new MySqlCommand(sql, databaseConnection);


                    MySqlDataReader myaReader = command.ExecuteReader();

                    while (myaReader.Read())
                    {                     //ID                             
                        consumer = consumer + myaReader.GetString(0) + "\n";

                    }


                    myaReader.Close();





                    DialogResult dialog = MessageBox.Show("هل انت متأكد من حفظ المصروف ", "ادخال المصاريف ", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {

                        insert_data_exp();

                    }
                    else if (dialog == DialogResult.No)
                    {

                        MessageBox.Show("لم تقم بحفظ المصروف     ");
                        //e.Cancel = true;
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Query Error :" + ex.Message);
                }
            }
             }

        

        private bool IsValidation()
        {
            if (comboBox_type.SelectedItem == null)
            {
                myvalidation.ValidationMessage(comboBox_type, "اختر نوع المصاريف", "خطأ في الإدخال");
                return false;
            }
             if (textBox_consum.Text == "")
            {
                myvalidation.ValidationMessage(textBox_consum, "أدخل الكمية بالدينار", "خطأ في الإدخال");
                return false;

            }
             if (txt_name_consumer.Text == "")
            {
                myvalidation.ValidationMessage(txt_name_consumer, "اختار اسم المستهلك", "خطأ في الإدخال");
                return false;

            }
            return true;

        }


        private void insert_data_exp()
        {
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                int select = comboBox_type.SelectedIndex;
                string id_expens = "";
                for (int i = 0; i < 2000; i++)
                {
                    if (select == i)
                    {
                        id_expens = id_exp[i];
                    }
                }

                Expensess expensess = new Expensess();

                expensess.Name_exp = textBox_consum.Text;
                String price = expensess.Name_exp;

                expensess.Date_exp = dateTimePicker1.Text;
                String date = expensess.Date_exp;

                // MessageBox.Show("Month" + dateTimePicker1.Value.Month + "");
                //MessageBox.Show("Year" + dateTimePicker1.Value.Year + "");
                int month = dateTimePicker1.Value.Month;
                int year = dateTimePicker1.Value.Year;
                int day = dateTimePicker1.Value.Day;



                commandDatabase.CommandText = "INSERT INTO expenses(id,id_exp, date,price,consumer,month,year,day)VALUES(NULL,'" + id_expens + "','" + date + "','" + price + "','" + consumer + "','" + month + "','" + year + "','" + day + "')";
                commandDatabase.ExecuteNonQuery();
                commandDatabase.Dispose();



                txt_name_consumer.Text = "";
                dateTimePicker1.Text = "";
                textBox_consum.Text = "";
                comboBox_type.Text = "";

            }
            catch (Exception e)
            {
                MessageBox.Show("Query Error :" + e.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox_new_type.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_new_type.Text == "")
            {
                MessageBox.Show("أدخل اسم المصروف الجديد  ");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("هل متأكد من اضافة المصروف ", "اضافة مصروف جديد ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    add_new_type();

                    button2.Visible = false;
                    textBox_new_type.Text = "";
                    textBox_new_type.Visible = false;

                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم بإضافة المصروف     ");
                    //e.Cancel = true;
                }

            }


        }



        private void add_new_type()
        {
            if (comboBox_type.Items.Contains(textBox_new_type.Text))
            {

                int index = comboBox_type.FindString(textBox_new_type.Text);
                comboBox_type.SelectedIndex = index;

                MessageBox.Show("المصروف   " + textBox_new_type.Text + "   موجود بالفعل");


            }
            else
            {
                comboBox_type.Items.Clear();
                MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

                commandDatabase.CommandTimeout = 60;

                try
                {


                    Expensess expensess = new Expensess();

                    expensess.New_type_exp = textBox_new_type.Text;
                    String new_type_exp = expensess.New_type_exp;






                    commandDatabase.CommandText = "INSERT INTO exp(id,name)VALUES(NULL,'" + new_type_exp + "')";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();


                    load_type_exp();

                    comboBox_type.SelectedIndex = comboBox_type.Items.Count - 1;

                    MessageBox.Show("Query successfully excuted");



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query Error :" + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void loading_consumer_in_combobox()
        {

            try
            {




               string sql = "SELECT id,user_name FROM login ORDER BY `login`.`id` ASC";

               MySqlCommand command = new MySqlCommand(sql, databaseConnection);


              MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    txt_name_consumer.Items.Add(myaReader.GetString(1));
                }
                myaReader.Close();



            }


            catch (Exception)
            {

            }

        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_name_consumer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses_Show expenses_Show = new Expenses_Show();
            expenses_Show.Show();
        }
    }
}
