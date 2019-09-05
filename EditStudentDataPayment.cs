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
    public partial class EditStudentDataPayment : Form
    {

        string student_id = "", persistent = "", startDate = "2019/07/01", transporation_id = "0", trans_id = "0", tuition_fee = "0", uniform = "0", transportation = "0", public_books, private_books = "0", others = "0", sql_student, sql_id_student, sql_id_transporation, sql_id_payment, sum_pay = "", sum_orig = "", query, transporationn_id="", area="", type_trans="";
        string[] array;
        string id_studente = "",id_trans="";
        string[] id_students = new string[2000];
        string[] name_trans = new string[2000];
        MyValidation myvalidation = new MyValidation();
        double outnumber, div = 0, b = 0;

        private void radioButtonAM_CheckedChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void radioButtonBoth_CheckedChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void radioButtonPM_CheckedChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

            chose_student();



            
        }

        private void chose_student()
        {
            String sql2;
            sql2 = "SELECT id,tuition_fee ,uniform,transporation_id,public_books,private_books,others,type_trans FROM student WHERE id='" + id_studente + "'";

            MySqlCommand commands;
            commands = new MySqlCommand(sql2, databaseConnection);

            MySqlDataReader myaReader2 = commands.ExecuteReader();
            try
            {

                while (myaReader2.Read())
                {

                    if (!myaReader2.IsDBNull(1)) { txt_tuition_fee.Text = myaReader2.GetString(1); }
                    if (!myaReader2.IsDBNull(2)) { txt_uniform.Text = myaReader2.GetString(2); }
                    if (!myaReader2.IsDBNull(3)) { transporationn_id = myaReader2.GetString(3);}
                    if (!myaReader2.IsDBNull(4)) { txt_public_books.Text = myaReader2.GetString(4); }
                    if (!myaReader2.IsDBNull(5)) { txt_private_books.Text = myaReader2.GetString(5); }
                    if (!myaReader2.IsDBNull(6)) { txt_others.Text = myaReader2.GetString(6); }
                    if (!myaReader2.IsDBNull(7)) { type_trans = myaReader2.GetString(7); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك بعض الحقول ما زالت فارغة يرجى ملؤها ");

            }
            myaReader2.Close();

            //transporationn_id = comboBox_student.SelectedItem.ToString();
            // in = comboBox_student.SelectedIndex;

            try
            {
                String sql;

                sql = "SELECT area FROM transportation_fee WHERE id='" + transporationn_id + "' ";

                MySqlCommand command2;
                command2 = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command2.ExecuteReader();

                while (myaReader.Read())
                {
                    area = myaReader.GetString(0);

                }


                myaReader.Close();
                int index_trans = 0;
                for (int i = 0; i < 2000; i++)
                {
                    if (name_trans[i] == area)
                    {
                        index_trans = i;
                    }
                }


                txt_transporation.SelectedIndex = index_trans;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            if (type_trans.Equals("صباحي"))
            {
                radioButtonAM.Checked = true;
            }
            if (type_trans.Equals("مسائي"))
            {
                radioButtonPM.Checked = true;

            }
            if (type_trans.Equals("معاً"))
            {
                radioButtonBoth.Checked = true;

            }




        }


        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        int numberOfBrothers = 0;

        MySqlCommand command_name, command_pay, command_transporation, commandDatabase;
        MySqlDataReader myaReader_transporation1;
        connection con = new connection();
        MySqlConnection databaseConnection;

        public EditStudentDataPayment()
        {
            InitializeComponent();

            databaseConnection = new MySqlConnection(con.MySQLConnectionString);


            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }

            load_data_student();
            load_data_into_combo();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();
            students stu = new students();
            stu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            empty_texts();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {

                run();
            }
        }

        double sum = 0, summ = 0, sum_original = 0, sum_dis = 0, summ_dis = 0;


       


        private void load_data_into_combo()
        {

            try
            {
                string sql_transporation = "";

                String sql_name, output_name = "", output_transporation = "";

                // sql_name = "SELECT id,name FROM student";
                sql_transporation = "SELECT `id`, `area`, `price` FROM `transportation_fee` ORDER BY `transportation_fee`.`id` ASC";

                // MySqlCommand command_name = new MySqlCommand(sql_name, databaseConnection);
                MySqlCommand command_transporation = new MySqlCommand(sql_transporation, databaseConnection);



                // MySqlDataReader myaReader_name = command_name.ExecuteReader();

                // while (myaReader_name.Read())
                // {
                //   output_name = output_name + myaReader_name.GetString(1) + "\n";
                // txt_name.Items.Add(myaReader_name.GetString(1));
                //}
                //myaReader_name.Close();


                MySqlDataReader myaReader_transporation = command_transporation.ExecuteReader();
                while (myaReader_transporation.Read())
                {
                    output_transporation = output_transporation + myaReader_transporation.GetString(1) + "\n";
                    txt_transporation.Items.Add(myaReader_transporation.GetString(1));
                }
                myaReader_transporation.Close();

            }



            catch (Exception ex)
            {
                MessageBox.Show("خطأ.." + ex.Message);

            }

        }



        private void EditStudentDataPayment_Load(object sender, EventArgs e)
        {
            

            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;

            

            int index = comboBox_student.FindString(name_student);
            comboBox_student.SelectedIndex = index;

           

            //  int index = txt_name.FindString(name_student);
           // comboBox_student.Text = name_student;
        }

        private void load_data_student()
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

                    comboBox_student.Items.Add(myaReader.GetString(1));
                    id_students[i] = myaReader.GetString(0);
                    i++;
                    //comboBox1.ValueMember = myaReader.GetString(0);
                    //       command.Parameters.AddWithValue(myaReader.GetString(0), myaReader.GetString(1));
                }
                myaReader.Close();

                }



                catch (Exception e)
                {
                MessageBox.Show(e.Message);

                }


            



        }

        private void run()
        {



            sql_id_student = "SELECT `id`,`start_date` FROM student WHERE name='" + comboBox_student.Text + "'";
            
            command_name = new MySqlCommand(sql_id_student, databaseConnection);

            MySqlDataReader myaReader_name1 = command_name.ExecuteReader();
            while (myaReader_name1.Read())
            {
                student_id = myaReader_name1.GetString(0);
                startDate = myaReader_name1.GetString(1);



            }
            myaReader_name1.Close();



            sql_id_transporation = "SELECT `id`,`price`,`area` FROM transportation_fee WHERE area='" + txt_transporation.Text + "'";
            command_transporation = new MySqlCommand(sql_id_transporation, databaseConnection);


            myaReader_transporation1 = command_transporation.ExecuteReader();
            int q = 0;
            while (myaReader_transporation1.Read())
            {
                transporation_id = myaReader_transporation1.GetString(1);
                trans_id = myaReader_transporation1.GetString(0);
                name_trans[q]= myaReader_transporation1.GetString(2);
                q++;
            }
            myaReader_transporation1.Close();
            if (radioButtonAM.Checked)
            {
                type_trans = radioButtonAM.Text;
                double temp_trans = double.Parse(transporation_id) / 2;
                transporation_id = temp_trans.ToString();
            }
            if (radioButtonPM.Checked)
            {
                type_trans = radioButtonPM.Text;

                double temp_trans = double.Parse(transporation_id) / 2;
                transporation_id = temp_trans.ToString();
            }
            if (radioButtonBoth.Checked)
            {
                type_trans = radioButtonBoth.Text;

            }
            sum = double.Parse(tuition_fee) + double.Parse(transporation_id);
            sum_dis = discount(sum);
            summ_dis = sum_dis + double.Parse(uniform) + double.Parse(public_books) + double.Parse(private_books) + double.Parse(others);
            summ = sum + double.Parse(uniform) + double.Parse(public_books) + double.Parse(private_books) + double.Parse(others);




            // DateTime a = currentDate - startDate;
            //double result=double.Parse() * div;


            //update
            query = " UPDATE `student` SET `tuition_fee`='" + tuition_fee + "',`uniform`='" + uniform + "',`transporation`='" + transporation_id + "',`public_books`='" + public_books + "',`private_books`='" + private_books + "',`others`='" + others + "',`sum_original`='" + summ + "',`sum`='" + summ_dis + "',`transporation_id`='" + trans_id + "',`type_trans`='" + type_trans + "' WHERE `id`='" + student_id + "'";

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;



            try
            {




                // databaseConnection.Open();
                // commandDatabase.CommandText = query;
                // commandDatabase.ExecuteNonQuery();

                int i = commandDatabase.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("تم تعديل الطالب/ة" + "\"" + comboBox_student.Text + "\"" + "...  بنجاح");

                    empty_texts();
                }
                else
                {
                    MessageBox.Show("!لم يتم تعديل الطالب ");

                }


                commandDatabase.Dispose();



            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }





        }
        private double discount(double sum)
        {


            string sql_num_per = "SELECT `number_of_brothers`,`persistent` FROM student WHERE name='" + comboBox_student.Text + "'";






            MySqlCommand command_num_per = new MySqlCommand(sql_num_per, databaseConnection);

            MySqlDataReader myaReader_num_per = command_num_per.ExecuteReader();
            while (myaReader_num_per.Read())
            {
                numberOfBrothers = int.Parse(myaReader_num_per.GetString(0));
                persistent = myaReader_num_per.GetString(1);

            }
            myaReader_num_per.Close();


            if (numberOfBrothers >= 1 && numberOfBrothers <= 2)
            {
                sum = sum - (sum * 0.010);
            }
            else if (numberOfBrothers >= 3)
            {
                sum = sum - (sum * 0.015);

            }
            else
            {
                sum = sum;

            }
            if (persistent == "مستمر")
            {
                sum = sum - 50;

            }
            else
            {
                sum = sum;

            }
            return sum;


        }

        private bool IsValidate()
        {

            try
            {

                tuition_fee = txt_tuition_fee.Text;
                public_books = txt_public_books.Text;

                if (txt_uniform.Text != "")
                {
                    uniform = txt_uniform.Text;
                }
                /*if (txt_transportation.SelectedItem.ToString() != "")
                {
                    transportation = txt_transportation.SelectedItem.ToString();
                }
                */
                if (txt_private_books.Text != "")
                {
                    private_books = txt_private_books.Text;
                }
                if (txt_others.Text != "")
                {
                    others = txt_others.Text;
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }

            if (comboBox_student.Text == "")
            {
                myvalidation.ValidationMessage(comboBox_student, "من فضلك اختار اسم الطالب ", "خطأ في الإدخال");
                return false;
            }

            if (tuition_fee == "")
            {
                myvalidation.ValidationMessage(txt_tuition_fee, "من فضلك أدخل قيمة القسط المدرسي  ", "خطأ في الإدخال");
                return false;
            }

            else if (!double.TryParse(txt_tuition_fee.Text, out outnumber))
            {
                txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة القسط المدرسي عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tuition_fee.Focus();
                return false;
            }

            if (public_books == "")
            {
                myvalidation.ValidationMessage(txt_public_books, "من فضلك أدخل قيمة الكتب العامة ", "خطأ في الإدخال");
                return false;
            }
            else if (!double.TryParse(txt_public_books.Text, out outnumber))
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة الكتب العامة عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (!double.TryParse(txt_uniform.Text, out outnumber) && txt_uniform.Text != "")
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة الزي المدرسي عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (!double.TryParse(txt_private_books.Text, out outnumber) && txt_private_books.Text != "")
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة الكتب الخاصة عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (!double.TryParse(txt_others.Text, out outnumber) && txt_others.Text != "")
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة  المستحقات الأخرى عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if ((!radioButtonAM.Checked && !radioButtonPM.Checked && !radioButtonBoth.Checked) && !txt_transporation.Text.Equals(""))
            {
                radioButtonAM.BackColor = Color.LightPink;
                radioButtonAM.Focus();
                radioButtonPM.BackColor = Color.LightPink;
                radioButtonPM.Focus();

                myvalidation.ValidationMessage(radioButtonBoth, "من فضلك اختار جولة المواصلات المطلوبة ", "خطأ في الإدخال");
                return false;
            }
            if ((radioButtonAM.Checked || radioButtonPM.Checked || radioButtonBoth.Checked) && txt_transporation.Text == "")
            {
                txt_transporation.Focus();
                myvalidation.ValidationMessage(txt_transporation, " من فضلك اختار منطقة مواصلات الطالب  ", "خطأ في الإدخال");
                return false;
            }
            return true;
        }

        private void empty_texts()
        {
            // txt_name.SelectedItem = "";
            txt_tuition_fee.Text = "";
            txt_uniform.Text = "";
            txt_transporation.Text = "";
            txt_public_books.Text = "";
            txt_private_books.Text = "";
            txt_others.Text = "";
            radioButtonAM.Checked = false;
            radioButtonPM.Checked = false;
            radioButtonBoth.Checked = false;

        }


    }
}
