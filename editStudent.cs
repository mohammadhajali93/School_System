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
using System.Threading;

namespace Rekaz
{
    public partial class editStudent : Form
    {

        string select_id_class = "";
        string select_name_class = "";
        string select_id_section = "";
        string select_id_tranporation = "";
        string select_name_section = "";
        string select_name_transporation = "";
        string id_studente = "";

        string[] id_students = new string[2000];
        string[] id_class = new string[2000];
        string[] name_class = new string[2000];
        string[] id_section = new string[2000];
        string[] name_section = new string[2000];
        string[] id_transporation = new string[2000];
        string[] name_transporation = new string[2000];
        connection con = new connection();
        public static string SetValueForText2 = "";
        MyValidation myvalidation = new MyValidation();
        MySqlConnection databaseConnection;
        int outAge;


        public editStudent()
        {
            InitializeComponent();



            databaseConnection = new MySqlConnection(con.MySQLConnectionString);


            //Thread childThread = new Thread("");
            //childThread.Start();

            Thread.Sleep(500);

            loading_student();
            loading_class();
            Load_transporation();
            loading_Section();



        }




        private void loading_Section()
        {
            try
            {
                String sql2;

                sql2 = "SELECT id,name FROM section ORDER BY `section`.`id` ASC";

                MySqlCommand command2;
                command2 = new MySqlCommand(sql2, databaseConnection);


                MySqlDataReader myaReader2 = command2.ExecuteReader();
                int i = 0;
                while (myaReader2.Read())
                {

                    comboBox_section.Items.Add(myaReader2.GetString(1));
                    id_section[i] = myaReader2.GetString(0);
                    name_section[i] = myaReader2.GetString(1);

                    i++;
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

                sql = "SELECT id,name FROM class_st ORDER BY `class_st`.`id` ASC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_class.Items.Add(myaReader.GetString(1));

                    id_class[i] = myaReader.GetString(0);
                    name_class[i] = myaReader.GetString(1);

                    i++;
                }
                myaReader.Close();
            }

            catch (Exception)
            {

            }
        }

        private void Load_transporation()
        {
            try
            {


                String sql, output = "";

                sql = "SELECT id,area FROM transportation_fee ORDER BY `transportation_fee`.`id` ASC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_transporation.Items.Add(myaReader.GetString(1));
                    id_transporation[i] = myaReader.GetString(0);
                    name_transporation[i] = myaReader.GetString(1);
                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }


        }

        private void loading_student()
        {
            try
            {
                databaseConnection.Open();
                String sql, output = "";

                sql = "SELECT id,name FROM student ORDER BY `student`.`id` DESC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox_student.Items.Add(myaReader.GetString(1));
                    id_students[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }

        }



        private void editStudent_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;
            
            int index = comboBox_student.FindString(name_student);
            comboBox_student.SelectedIndex = index;
        }



        private void chose_student()
        {


            string select_student = comboBox_student.SelectedItem.ToString();
            int select = comboBox_student.SelectedIndex;

            for (int i = 0; i < 2000; i++)
            {
                if (select == i)
                {
                    id_studente = id_students[i];
                }
            }
            String sql2;
            string gender = "";
            string noob = "";
            string persistent = "";
            sql2 = "SELECT id,id_student ,name,gender,class_st,section,transporation_id,persistent,noob,comments,end_date,start_date, emergency_phone_number,phone_number,address , date_of_birth,number_of_brothers FROM student WHERE name='" + select_student + "'";

            MySqlCommand commands;
            commands = new MySqlCommand(sql2, databaseConnection);

            MySqlDataReader myaReader2 = commands.ExecuteReader();
            try
            {

                while (myaReader2.Read())
                {
                    //if (!myaReader2.IsDBNull(1) && !myaReader2.IsDBNull(2) && !myaReader2.IsDBNull(14) && !myaReader2.IsDBNull(13) && !myaReader2.IsDBNull(12) && !myaReader2.IsDBNull(9) && !myaReader2.IsDBNull(4) && !myaReader2.IsDBNull(5) && !myaReader2.IsDBNull(6) && !myaReader2.IsDBNull(3) && !myaReader2.IsDBNull(7) && !myaReader2.IsDBNull(8) && !myaReader2.IsDBNull(10) && !myaReader2.IsDBNull(11) && !myaReader2.IsDBNull(15))
                    //{
                    if (!myaReader2.IsDBNull(1)) { text_id_student.Text = myaReader2.GetString(1); }
                    if (!myaReader2.IsDBNull(2)) { text_name_student.Text = myaReader2.GetString(2); }
                    if (!myaReader2.IsDBNull(14)) { text_addres_student.Text = myaReader2.GetString(14); }
                    if (!myaReader2.IsDBNull(13)) { text_phone_student.Text = myaReader2.GetString(13); }
                    if (!myaReader2.IsDBNull(12))
                    { text_phone_emargancy_student.Text = myaReader2.GetString(12); }
                    if (!myaReader2.IsDBNull(9))
                    { text_comment_student.Text = myaReader2.GetString(9); }

                    if (!myaReader2.IsDBNull(4))
                    { select_id_class = myaReader2.GetString(4); }
                    if (!myaReader2.IsDBNull(5))
                    { select_id_section = myaReader2.GetString(5); }
                    if (!myaReader2.IsDBNull(6))
                    { select_id_tranporation = myaReader2.GetString(6); }

                    if (!myaReader2.IsDBNull(15))
                    { bearth_day.Text = myaReader2.GetString(15); }
                    if (!myaReader2.IsDBNull(11))
                    { start_date.Text = myaReader2.GetString(11); }
                    if (!myaReader2.IsDBNull(10))
                    { end_date.Text = myaReader2.GetString(10); }

                    if (!myaReader2.IsDBNull(3))
                    {
                        gender = myaReader2.GetString(3);

                        if (gender == "أنثى")
                        {
                            radioButton_femal.Checked = true;
                        }
                        else
                        {
                            radioButton_male.Checked = true;
                        }
                    }
                    if (!myaReader2.IsDBNull(8))
                    {
                        noob = myaReader2.GetString(8);
                        if (noob == "مستجد")
                        {
                            radioButton_noob.Checked = true;
                        }
                        else
                        {
                            radioButton_not_noob.Checked = true;
                        }
                    }
                    if (!myaReader2.IsDBNull(7))
                    {
                        persistent = myaReader2.GetString(7);
                        if (persistent == "مستمر")
                        {
                            radioButton_presistent.Checked = true;
                        }
                        else
                        {
                            radioButton4.Checked = true;
                        }
                    }

                    //     }






                }







            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك بعض الحقول ما زالت فارغة يرجى ملؤها ");

            }
            myaReader2.Close();
            try
            {
                String sql;

                sql = "SELECT id,name FROM class_st WHERE id='" + select_id_class + "' ";

                MySqlCommand command2;
                command2 = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command2.ExecuteReader();

                while (myaReader.Read())
                {
                    select_name_class = myaReader.GetString(1);

                }


                myaReader.Close();
                int index_class = 0;
                for (int i = 0; i < 2000; i++)
                {
                    if (name_class[i] == select_name_class)
                    {
                        index_class = i;
                    }
                }

                // int index = comboBox2.Items.IndexOf(select_name_class);
                comboBox_class.SelectedIndex = index_class;

                // MessageBox.Show(select_name_class + "");
            }

            catch (Exception)
            {

            }

            try
            {
                String sql;

                sql = "SELECT id,name FROM section WHERE id='" + select_id_section + "' ";

                MySqlCommand command3;
                command3 = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command3.ExecuteReader();

                while (myaReader.Read())
                {
                    select_name_section = myaReader.GetString(1);

                }


                myaReader.Close();
                int index_section = 0;
                for (int i = 0; i < 2000; i++)
                {
                    if (name_section[i] == select_name_section)
                    {
                        index_section = i;
                    }
                }

                // int index = comboBox2.Items.IndexOf(select_name_class);
                comboBox_section.SelectedIndex = index_section;

            }

            catch (Exception)
            {

            }

            try
            {
                String sql;

                sql = "SELECT id,area FROM transportation_fee WHERE id='" + select_id_tranporation + "' ";

                MySqlCommand command2;
                command2 = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command2.ExecuteReader();

                while (myaReader.Read())
                {
                    select_name_transporation = myaReader.GetString(1);

                }


                myaReader.Close();
                int index_tranporation = 0;
                for (int i = 0; i < 2000; i++)
                {
                    if (name_transporation[i] == select_name_transporation)
                    {
                        index_tranporation = i;
                    }
                }

                // int index = comboBox2.Items.IndexOf(select_name_class);
                comboBox_transporation.SelectedIndex = index_tranporation;

                // MessageBox.Show(select_name_class + "");
            }

            catch (Exception)
            {

            }
        }



        private void clear_data()
        {

            text_id_student.Text = "";
            text_name_student.Text = "";
            text_phone_emargancy_student.Text = "";
            text_addres_student.Text = "";
            text_phone_student.Text = "";
            text_phone_emargancy_student.Text = "";
            text_comment_student.Text = "";
            //comboBox_section.SelectedItem = null;
            //comboBox1.SelectedItem = null;
            comboBox_section.SelectedIndex = -1;

            comboBox_transporation.SelectedItem = null;
            comboBox_class.SelectedItem = null;
            radioButton_male.Checked = false;
            radioButton_femal.Checked = false;
            radioButton_not_noob.Checked = false;
            radioButton_noob.Checked = false;
            radioButton4.Checked = false;
            radioButton_presistent.Checked = false;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_student.SelectedItem == null)
            {
                myvalidation.ValidationMessage(comboBox_student, "أختر الطالب أولاً لإجراء التعديل عليه    ", "خطأ في الإدخال");

              //  MessageBox.Show("أختر الطالب أولاً لإجراء التعديل عليه    ");
            }
            else
            {
                if (IsValidation()) { 
                DialogResult dialog = MessageBox.Show("هل متأكد من عملية تعديل بيانات الطالب   " + comboBox_student.SelectedItem.ToString(), "تعديل بيانات الطالب ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    update_student();

                    MessageBox.Show("تم  تعديل بيانات الطالب     " + comboBox_student.SelectedItem.ToString());
                    string remove_name = comboBox_student.SelectedItem.ToString();

                    comboBox_student.Items.Remove(remove_name);

                    string name_student = text_name_student.Text;

                    comboBox_student.Items.Add(name_student);

                    comboBox_student.SelectedIndex = comboBox_student.Items.Count - 1;

                    clear_data();

                }
                else if (dialog == DialogResult.No)
                {

                    MessageBox.Show("لم تقم بتعديل بيانات الطالب     ");

                }
            }
            }


        }
        private void update_student()
        {
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                student stud = new student();

                stud.Id_student = text_id_student.Text;
                String id_student = stud.Id_student;

                stud.Name = text_name_student.Text;
                String name = stud.Name;

                //  Form1.SetValueForText2 = text_name_student.Text;

                stud.Number_of_brothers = "0";
                String number_of_brothers = stud.Number_of_brothers;

                stud.Date_of_birth = bearth_day.Text;
                String date_of_birth = stud.Date_of_birth;

                stud.Address = text_addres_student.Text;
                String address = stud.Address;

                stud.Phone_number = text_phone_student.Text;
                String phone_number = stud.Phone_number;

                stud.Emergency_phone_number = text_phone_emargancy_student.Text;
                String emergency_phone_number = stud.Emergency_phone_number;

                stud.Start_date = this.start_date.Text;
                String start_date = stud.Start_date;

                stud.End_date = this.end_date.Text;
                String end_date = stud.End_date;

                stud.Comments = text_comment_student.Text;
                String comments = stud.Comments;


                if (radioButton_male.Checked == true)
                {
                    stud.Gender = "ذكر";

                }
                else if (radioButton_femal.Checked == true)
                {
                    stud.Gender = "أنثى";
                }
                String gender = stud.Gender;


                if (radioButton_not_noob.Checked == true)
                {
                    stud.Noob = "غير مستجد";

                }
                else if (radioButton_noob.Checked == true)
                {
                    stud.Noob = "مستجد";
                }


                String noob = stud.Noob;

                if (radioButton4.Checked == true)
                {
                    stud.Persistent = "غير مستمر";

                }
                else if (radioButton_presistent.Checked == true)
                {
                    stud.Persistent = "مستمر";
                }

                String presistent = stud.Persistent;


                int select = comboBox_transporation.SelectedIndex;
                string id_transportions = "";
                for (int i = 0; i < 2000; i++)
                {
                    if (select == i)
                    {
                        id_transportions = id_transporation[i];
                    }
                }

                int select_section = comboBox_section.SelectedIndex;
                string id_sections = "";
                for (int i = 0; i < 2000; i++)
                {
                    if (select_section == i)
                    {
                        id_sections = id_section[i];
                    }
                }

                int select_class = comboBox_class.SelectedIndex;
                string id_classes = "";
                for (int i = 0; i < 2000; i++)
                {
                    if (select_class == i)
                    {
                        id_classes = id_class[i];
                    }
                }//id_student ,name,gender,class_st,section,transporation_id,persistent,noob,comments,end_date,start_date, emergency_phone_number,phone_number,address , date_of_birth,number_of_brothers

                commandDatabase.CommandText = "Update student set id_student='" + id_student + "',name ='" + name + "',gender='" + gender + "',class_st='" + id_classes + "',section='" + id_sections + "',transporation_id='" + id_transportions + "',persistent='" + presistent + "',noob='" + noob + "',comments='" + comments + "',end_date='" + end_date + "',start_date='" + start_date + "',emergency_phone_number='" + emergency_phone_number + "',phone_number='" + phone_number + "',address='" + address + "',date_of_birth='" + date_of_birth + "',number_of_brothers='" + number_of_brothers + "'WHERE id ='" + id_studente + "'";
                commandDatabase.ExecuteNonQuery();
                commandDatabase.Dispose();



//MessageBox.Show("Query successfully excuted");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error :" + ex.Message);
            }


        }






        private void button2_Click(object sender, EventArgs e)
        {
           // loading_student();
            clear_data();


        }

        private void comboBox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_data();
            chose_student();
        }



        public bool IsValidation()
        {


            if (text_id_student.Text == "")
            {
                myvalidation.ValidationMessage(text_id_student, "أدخل الرقم الوطني", "خطأ في الإدخال");
                return false;
            }
            else if (!int.TryParse(text_id_student.Text, out outAge))
            {
                text_id_student.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان يحتوي الرقم الوطني على أعداد فقط", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_id_student.Focus();
                return false;
            }

            if (text_name_student.Text == "")
            {
                myvalidation.ValidationMessage(text_name_student, "أدخل اسم الطالب", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_class.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_class, "اختر الصف", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_section.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_section, "اختر الشعبة", "خطأ في الإدخال");
                return false;
            }
            if (comboBox_transporation.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_transporation, "اختر اسم المنطقة", "خطأ في الإدخال");
                return false;
            }
            if (text_addres_student.Text == "")
            {
                myvalidation.ValidationMessage(text_addres_student, "أدخل عنوان الطالب", "خطأ في الإدخال");
                return false;
            }
            if (text_phone_emargancy_student.Text == "")
            {
                myvalidation.ValidationMessage(text_phone_emargancy_student, "أدخل رقم هاتف الطوارئ", "خطأ في الإدخال");
                return false;
            }
            else if (!int.TryParse(text_phone_emargancy_student.Text, out outAge))
            {
                MessageBox.Show(" يجب ان يحتوي رقم هاتف الطوارئ على أعداد فقط", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (text_phone_emargancy_student.Text.Length != 10)
            {
                MessageBox.Show(" يجب ان يكون طول رقم الهاتف 10 أرقام ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           
            return true;



        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_transporation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stus = new students();
            stus.Show();
        }
    }
}

