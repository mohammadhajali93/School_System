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
    public partial class add_student : Form
    {
        string[] id_transporation = new string[2000];
        connection con = new connection();
        MySqlConnection databaseConnection;
        public static string SetValueForText2 = "";
        MyValidation myvalidation = new MyValidation();
        int outAge;



        public add_student()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }

            loading_class();

            loading_Section();


          

        }


        private void loading_Section()
        {
            try
            {
               

                String sql2, output2 = "";

                sql2 = "SELECT id,name FROM section ORDER BY `section`.`id` ASC";

                MySqlCommand command2;
                command2 = new MySqlCommand(sql2, databaseConnection);


                MySqlDataReader myaReader2 = command2.ExecuteReader();

                while (myaReader2.Read())
                {                            //ID                               
                    output2 = output2 + myaReader2.GetString(1) + "\n";
                    txt_section.Items.Add(myaReader2.GetString(1));
                }
                myaReader2.Close();

            }

            catch (Exception)
            {

            }
        }

        private void loading_class()

        {
            try
            {


                String sql, output = "";

                sql = "SELECT id,name FROM class_st ORDER BY `class_st`.`id` ASC ";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    txt_class.Items.Add(myaReader.GetString(1));
                }
                myaReader.Close();

            }



            catch (Exception)
            {


            }


        }



        private void add_student_Load(object sender, EventArgs e)
        {
       
            Load_transporation();

            

        }



        private void Load_transporation()
        {
            try
            {


                String sql, output = "";

                sql = "SELECT id,area FROM transportation_fee ORDER BY `transportation_fee`.`id` ASC ";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    txt_area.Items.Add(myaReader.GetString(1));
                    id_transporation[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }


        }






        private void add_brother_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_brother add_bro = new add_brother();
            add_bro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {
                ShardPreferance shard = new ShardPreferance();
                shard.Name = txt_name.Text;

                add_student_validation();
            }
        }

        public bool IsValidation()
        {


            if (txt_student_id.Text == "")
            {
                myvalidation.ValidationMessage(txt_student_id, "أدخل الرقم الوطني", "خطأ في الإدخال");
                return false;
            }
            else if (!int.TryParse(txt_student_id.Text, out outAge))
            {
                txt_student_id.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان يحتوي الرقم الوطني على أعداد فقط", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_student_id.Focus();
                return false;
            }

            if (txt_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_name, "أدخل اسم الطالب", "خطأ في الإدخال");
                return false;
            }
            if (txt_class.Text == "")
            {
                myvalidation.ValidationMessage(txt_class, "اختر الصف", "خطأ في الإدخال");
                return false;
            }
            if (txt_section.Text == "")
            {
                myvalidation.ValidationMessage(txt_section, "اختر الشعبة", "خطأ في الإدخال");
                return false;
            }
            if (txt_area.Text == "")
            {
                myvalidation.ValidationMessage(txt_area, "اختر اسم المنطقة", "خطأ في الإدخال");
                return false;
            }
            if (txt_adderes.Text == "")
            {
                myvalidation.ValidationMessage(txt_adderes, "أدخل عنوان الطالب", "خطأ في الإدخال");
                return false;
            }
            if (txt_emergency_phone_number.Text == "")
            {
                myvalidation.ValidationMessage(txt_emergency_phone_number, "أدخل رقم هاتف الطوارئ", "خطأ في الإدخال");
                return false;
            }
            else if (!int.TryParse(txt_emergency_phone_number.Text, out outAge))
            {
                MessageBox.Show(" يجب ان يحتوي رقم هاتف الطوارئ على أعداد فقط", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txt_emergency_phone_number.Text.Length!=10)
            {
                MessageBox.Show(" يجب ان يكون طول رقم الهاتف 10 أرقام ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (radio_button_new.Checked == false && radio_button_not_new.Checked == false)
            {
                MessageBox.Show("  اختر حالة الطالب مستجد/غير مستجد ");
                return false;
            }

            if (radio_button_persistent.Checked == false && radio_button_not_persistent.Checked == false)
            {
                MessageBox.Show("حدد استمرارية الطالب");
                return false;
            }
            if (radio_button_have_brother.Checked == false && radio_button_not_have_brother.Checked == false)
            {
                MessageBox.Show("  اختر هل للطالب إخوة ");
                return false;
            }

            if (radio_button_male.Checked == false && radio_button_female.Checked == false)
            {
                MessageBox.Show("اختر الجنس");
                return false;
            }
            

            
            

            
            



            return true;



        }




        private void add_student_validation()
        {
            
            
                DialogResult dialog = MessageBox.Show("هل متأكد من إدخال معلومات طالب  جديد ", "تسجيل معلومات الطالب ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    insert_student();

                    next();

                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم بتسجيل الطالب     ");
                    //e.Cancel = true;
                }

            
        }

        private void next()
        {
            

            this.Hide();
            
                add_student_data_payment asdp = new add_student_data_payment();
                asdp.Show();
            
        }

        private void insert_student()
        {
            string query = txt_student_id.Text;

            //if (query == "")
            //{
              //  MessageBox.Show("Please insert some sql query");
               // return;
            //}


            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {

                student student = new student();

                student.Id_student = txt_student_id.Text;
                String id_student = student.Id_student;

                student.Name = txt_name.Text;
                String name = student.Name;

               // Form1.SetValueForText2 = textBox2.Text;

                student.Number_of_brothers = "0";
                String number_of_brothers = student.Number_of_brothers;

                student.Date_of_birth = dateTimePicker1.Text;
                String date_of_birth = student.Date_of_birth;

                student.Address = txt_adderes.Text;
                String address = student.Address;

                student.Phone_number = txt_phone_number.Text;
                String phone_number = student.Phone_number;

                student.Emergency_phone_number = txt_emergency_phone_number.Text;
                String emergency_phone_number = student.Emergency_phone_number;

                student.Start_date = dateTimePicker2.Text;
                String start_date = student.Start_date;

                student.End_date = dateTimePicker3.Text;
                String end_date = student.End_date;

                student.Comments = txt_comments.Text;
                String comments = student.Comments;


                if (radio_button_male.Checked == true)
                {
                    student.Gender = "ذكر";

                }
                else if (radio_button_female.Checked == true)
                {
                    student.Gender = "أنثى";
                }  
                String gender = student.Gender;

                if (radio_button_new.Checked == true)
                {
                    student.Noob = "مستجد";

                }
                else if (radio_button_not_new.Checked == true)
                {
                    student.Noob = "غير مستجد";
                }
                String noob = student.Noob;

                if (radio_button_persistent.Checked == true)
                {
                    student.Persistent = "مستمر";

                }
                else if (radio_button_not_persistent.Checked == true)
                {
                    student.Persistent = "غير مستمر";
                }

                String presistent = student.Persistent;





                String sql1, id_class = "";
                String sql2, id_section = "";

                String name_class = txt_class.SelectedItem.ToString();
                String name_section = txt_section.SelectedItem.ToString();

                sql1 = "SELECT id,name FROM class_st WHERE name='" + name_class + "' ";
                sql2 = "SELECT id,name FROM section WHERE name='" + name_section + "' ";
                MySqlCommand command1;
                command1 = new MySqlCommand(sql1, databaseConnection);

                MySqlCommand command2;
                command2 = new MySqlCommand(sql2, databaseConnection);

                MySqlDataReader myaReader1 = command1.ExecuteReader();

                while (myaReader1.Read())
                {                                    //ID                             
                    id_class = id_class + myaReader1.GetString(0) + "\n";


                }
                myaReader1.Close();

                MySqlDataReader myaReader2 = command2.ExecuteReader();

                while (myaReader2.Read())
                {                     //ID                             
                    id_section = id_section + myaReader2.GetString(0) + "\n";


                }
                myaReader2.Close();


                int select = txt_area.SelectedIndex;
                string id_transportion = "";
                for (int i = 0; i < 2000; i++)
                {
                    if (select == i)
                    {
                        id_transportion = id_transporation[i];
                    }
                }


                commandDatabase.CommandText = "INSERT INTO student(id,id_student, name,gender, class_st, section, number_of_brothers, date_of_birth, address, phone_number, emergency_phone_number, start_date, end_date, comments, noob,persistent,transporation_id)VALUES(NULL,'" + id_student + "','" + name + "','" + gender + "','" + id_class + "','" + id_section + "','" + number_of_brothers + "','" + date_of_birth + "','" + address + "','" + phone_number + "','" + emergency_phone_number + "','" + start_date + "','" + end_date + "','" + comments + "','" + noob + "','" + presistent + "','" + id_transportion + "')";
                commandDatabase.ExecuteNonQuery();
                commandDatabase.Dispose();




                MessageBox.Show("تم تسجيل المعلومات   من فضلك أكمل عملية التسجيل");

            }
            catch (Exception e)
            {
                MessageBox.Show("Query Error :" + e.Message);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_student_id.Text = "";
            txt_name.Text = "";
            txt_class.Text = "";
            txt_section.Text = "";
            txt_emergency_phone_number.Text = "";
            txt_phone_number.Text = "";
            txt_area.Text = "";
            txt_adderes.Text = "";
            txt_comments.Text = "";
            radio_button_male.Checked = false;
            radio_button_female.Checked = false;
            radio_button_new.Checked = false;
            radio_button_not_new.Checked = false;
            radio_button_have_brother.Checked = false;
            radio_button_not_have_brother.Checked = false;
            radio_button_persistent.Checked = false;
            radio_button_not_persistent.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

