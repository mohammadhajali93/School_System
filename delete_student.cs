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
    public partial class delete_student : Form
    {

        int sum_student = 0;

        connection con = new connection();

        MySqlConnection databaseConnection;

        string[] array;
        MyValidation myvalidation = new MyValidation();



        public delete_student()
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }

            load_num_student();

            loading_student();

           

        }


        private void load_num_student()
        {
            try
            {
                int num_student = 0;

                String count = "SELECT COUNT(*) FROM student ";
                MySqlCommand commands;
                commands = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {
                    num_student = 1 + int.Parse(myaReaders.GetString(0));
                }
                myaReaders.Close();
                sum_student = num_student;
                array = new string[num_student];


            }

            catch (Exception)
            {

            }


        }



        private void loading_student()

        {
            try
            {

                //    ComboboxItem item = new ComboboxItem();

                //item.Text = "Item text1";
                //  item.Value = "1";

                //           comboBox1.Items.Add(item);
                //comboBox1.SelectedIndex = 0;


                String sql, output = "";

                sql = "SELECT id,name FROM student ORDER BY `student`.`id` DESC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_show_student.Items.Add(myaReader.GetString(1));
                    array[i] = myaReader.GetString(0);

                    i++;
                    //comboBox1.ValueMember = myaReader.GetString(0);
                    //       command.Parameters.AddWithValue(myaReader.GetString(0), myaReader.GetString(1));
                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }


        }


        private void delete_student_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;
            
            int index = comboBox_show_student.FindString(name_student);
            comboBox_show_student.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {
                deleteStudent();
            }
        }


        private void deleteStudent()
        {
            

           
                DialogResult dialog = MessageBox.Show("هل انت متأكد من عملية حذف  الطالب   " + comboBox_show_student.SelectedItem.ToString(), "حذف الطالب ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    int select = comboBox_show_student.SelectedIndex;
                    string id_student = "";
                    for (int i = 0; i < sum_student; i++)
                    {
                        if (select == i)
                        {
                            id_student = array[i];
                        }
                    }

                    try
                    {

                        MySqlCommand command_delete_sudent_brother;
                        MySqlDataAdapter adaptrs = new MySqlDataAdapter();

                        String delett = "Delete FROM brothers where id_student ='" + id_student + "'";

                        command_delete_sudent_brother = new MySqlCommand(delett, databaseConnection);
                        adaptrs.DeleteCommand = new MySqlCommand(delett, databaseConnection);
                        adaptrs.DeleteCommand.ExecuteNonQuery();
                        command_delete_sudent_brother.Dispose();

                        MySqlCommand command_delete_sudent_paymant;
                        MySqlDataAdapter adaptr = new MySqlDataAdapter();

                        String delet = "Delete FROM payments where student_id ='" + id_student + "'";

                        command_delete_sudent_paymant = new MySqlCommand(delet, databaseConnection);
                        adaptr.DeleteCommand = new MySqlCommand(delet, databaseConnection);
                        adaptr.DeleteCommand.ExecuteNonQuery();
                        command_delete_sudent_paymant.Dispose();

                        MySqlCommand commands;
                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        String delete = "Delete FROM student where id ='" + id_student + "'";

                        commands = new MySqlCommand(delete, databaseConnection);
                        adapter.DeleteCommand = new MySqlCommand(delete, databaseConnection);
                        adapter.DeleteCommand.ExecuteNonQuery();
                        commands.Dispose();

                    }

                    catch (Exception)
                    {

                    }
                    MessageBox.Show("تم  حذف الطالب " + comboBox_show_student.SelectedItem.ToString());
                comboBox_show_student.Items.Remove(comboBox_show_student.SelectedItem.ToString());
            }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم بحذف الطالب ");
                    //e.Cancel = true;
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stus = new students();
            stus.Show();
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        public bool IsValidation()
        {


            if (comboBox_show_student.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_show_student, " اختر اسم الطالب المراد حذفه", "خطأ في الإدخال");
                return false;
            }
            
            return true;



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }
    }
    }
