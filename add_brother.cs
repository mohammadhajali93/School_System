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
    public partial class add_brother : Form
    {

        connection con = new connection();

        MySqlConnection databaseConnection;
        String sql="", sql1="", id_student = "", name_student = "", name_brother="", sql2 = "", id_student2 = "", output = "", sql3 = "",  num_brothers = "", count="", all_brother="";

        MySqlCommand  command,  command1, command2, command3,  commands, commandDatabase, commandDatabaseBro;
        
        string[] id_brothers = new string[50];

        string[] transporation = new string[50];
        string[] tiotation_fee = new string[50];
        string[] sum = new string[50];
        string[] brother_special = new string[200];
         string[] student_special = new string[100];

        string name = "";





        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_student_data_payment asdp = new add_student_data_payment();
            asdp.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        MySqlDataReader myaReader,myaReader1, myaReader2, myaReader3;
        MyValidation myvalidation = new MyValidation();



        public add_brother()
        {
            InitializeComponent();

            


            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }
            loading_student_in_combobox();
        }



        private void update_number_brother()
        {
            String sql1, id_student = "";
            try
            {
                databaseConnection.Open();


                sql1 = "SELECT id,name FROM student WHERE name='" + name_student + "'";
                MySqlCommand command1;
                command1 = new MySqlCommand(sql1, databaseConnection);

                MySqlDataReader myaReader1 = command1.ExecuteReader();

                while (myaReader1.Read())
                {                                    //ID                             
                    id_student = id_student + myaReader1.GetString(0) + "\n";

                }
                myaReader1.Close();
              //  MessageBox.Show("رقم الطالب"+id_student);
            }
            catch (Exception)
            {

            }

            String num_brother = "";
            String count = "SELECT COUNT(*) FROM brothers  WHERE id_student ='" + id_student + "'";
            MySqlCommand command;
            command = new MySqlCommand(count, databaseConnection);

            MySqlDataReader myaReader = command.ExecuteReader();

            while (myaReader.Read())
            {                                    //ID                             
                num_brother = num_brother + myaReader.GetString(0) + "\n";

            }

            myaReader.Close();
          //  MessageBox.Show("عدد الاخوة"+num_brother);
        }





        private void loading_student_in_combobox()
        {

            try
            {

                String count = "SELECT COUNT(*) FROM brothers";
                MySqlCommand command_count;
                command_count = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReader_count = command_count.ExecuteReader();

                while (myaReader_count.Read())
                {                                    //ID                             
                    all_brother = all_brother + myaReader_count.GetString(0) + "\n";

                }
               // MessageBox.Show("all_brother" + all_brother);

                myaReader_count.Close();
                String sql, sql_special, output = "", output_special = "";
                int i = 0;
                



                    //لاستثناء الأخوة المضيوفين داخل الطلاب

                    sql_special = "SELECT id_brother,id_student FROM brothers";

                    MySqlCommand command_special;
                    command_special = new MySqlCommand(sql_special, databaseConnection);


                    MySqlDataReader myaReader_special = command_special.ExecuteReader();

                    while (myaReader_special.Read())
                    {                            //ID                               
                        output_special = output_special + myaReader_special.GetString(0) + "\n";
                        brother_special[i]= myaReader_special.GetString(0);
                    student_special[i] = myaReader_special.GetString(1);
                    // MessageBox.Show("brother_special[i]" + brother_special[i]);
                    i++;


                }

                myaReader_special.Close();

                


                //لإحضار بيانات الطالب

                sql = "SELECT id,name FROM student ORDER BY `student`.`id` DESC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";
                    if (!brother_special.Contains(myaReader.GetString(0)))
                    {
                        txt_student_name.Items.Add(myaReader.GetString(1));
                    }
                    if ((!student_special.Contains(myaReader.GetString(0))) && (!brother_special.Contains(myaReader.GetString(0))))
                    {
                        txt_brother_name.Items.Add(myaReader.GetString(1));
                    }

                }
                myaReader.Close();



            }


            catch (Exception)
            {

            }

        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {

                regester_brothers();
                updae_num_brother();
                name = txt_student_name.SelectedItem.ToString();
                descount_brothers();



            }

        }




        private void descount_brothers()
        {
            String sql;
            string transportion = "", tutation_fee = "", sums = "";
            double tt = 0,ttt=0, remainder = 0,remainder_bro=0,sum_all=0,sum_all_bro=0;

          //تعديل الطالب نفسه
            try { 

            
            sql = "SELECT tuition_fee ,transporation ,sum_original FROM student WHERE id ='" + id_student + "'";

            MySqlCommand command;
            command = new MySqlCommand(sql, databaseConnection);


            MySqlDataReader myaReader2 = command.ExecuteReader();

            int x = 0;
            while (myaReader2.Read())
            {

                transportion = myaReader2.GetString(1);
                tutation_fee = myaReader2.GetString(0);
                tt = double.Parse(transportion) + double.Parse(tutation_fee);
                sums = myaReader2.GetString(2);
                remainder = double.Parse(sums) - tt;

                x++;

            }
            myaReader2.Close();

        }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }

            discount(tt);



            sum_all = discount(tt) + remainder;
            
          string  query = " UPDATE `student` SET `sum`='" + sum_all + "'WHERE name ='" + name + "'";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;



            try
            {

                int i = commandDatabase.ExecuteNonQuery();
                if (i >= 1)
                {
                  //  MessageBox.Show("تم تعديل حسبة الطالب /ة" + "...  بنجاح");

                }
                else
                {
                   // MessageBox.Show("!لم يتم تعديل حسبة الطالب /ة بنجاح  ");

                }


                commandDatabase.Dispose();



            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }

            //تعديل الأخوة
            try
            {
                for (int i = 0; i < int.Parse(num_brothers); i++)
                {

                    String sql_s = "";

                    sql_s = "SELECT tuition_fee ,transporation , sum_original FROM student WHERE id ='" + id_brothers[i] + "'";


                    MySqlCommand command4;
                    command4 = new MySqlCommand(sql_s, databaseConnection);



                    MySqlDataReader myaReader3 = command4.ExecuteReader();


                    while (myaReader3.Read())
                    {
                        tiotation_fee[i] = myaReader3.GetString(0);
                        transporation[i] = myaReader3.GetString(1);
                        ttt = double.Parse(tiotation_fee[i]) + double.Parse(transporation[i]);

                        sum[i] = myaReader3.GetString(2);


                        remainder_bro = double.Parse(sum[i]) - ttt;

                        discount(ttt);
                        sum_all_bro = discount(ttt) + remainder_bro;
                    }
                        myaReader3.Close();
                    

                    string query_bro = " UPDATE `student` SET `sum`='" + sum_all_bro + "'WHERE id ='" + id_brothers[i] + "'";
                    commandDatabaseBro = new MySqlCommand(query_bro, databaseConnection);
                    commandDatabaseBro.CommandTimeout = 60;

                    int q = commandDatabaseBro.ExecuteNonQuery();
                    if (q >= 1)
                    {
                       // MessageBox.Show(" تم تعديل حسبة الاخوة بنجاح  ");

                    }
                    else
                    {
                      //  MessageBox.Show("!لم يتم تعديل حسبة الأخوة بنجاح  ");

                    }
                    commandDatabaseBro.Dispose();
                    
                }
            }


            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }







           




            /* if (int.Parse(num_brothers) <= 2)//خصم 10 %
             {
                 MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);
                 MySqlCommand commandDatabase_brother = new MySqlCommand("", databaseConnection);

                 commandDatabase.CommandTimeout = 60;

                 double transes = double.Parse(tutation_fee);

                 double descounts_transporation = transes - ((double.Parse(tutation_fee) * 10) / 100);

                 double descounts_sum = double.Parse(sums) - descounts_transporation;


                 commandDatabase_brother.CommandText = "Update student set sum ='" + descounts_sum + "'WHERE name ='" + name + "'";

                 commandDatabase_brother.ExecuteNonQuery();
                 commandDatabase_brother.Dispose();


                 try
                 {
                     for (int i = 0; i < int.Parse(num_brothers); i++)
                     {
                         double trans = double.Parse(tiotation_fee[i]);

                         double descount_transporation = trans - ((double.Parse(tiotation_fee[i]) * 10) / 100);

                         double descount_sum = descount_transporation - double.Parse(sum[i]);
                         MessageBox.Show(descount_sum + "");

                         commandDatabase.CommandText = "Update student set sum ='" + descount_sum + "'WHERE id ='" + id_brothers[i] + "'";
                         commandDatabase.ExecuteNonQuery();
                         commandDatabase.Dispose();
                     }




                     MessageBox.Show("Query successfully excuted");

                 }
                 catch (Exception e)
                 {
                     MessageBox.Show("Query Error :" + e.Message);
                 }

             }


             else if (int.Parse(num_brothers) > 2)//خصم 15 %
             {

                 MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);
                 MySqlCommand commandDatabase_brother = new MySqlCommand("", databaseConnection);

                 commandDatabase.CommandTimeout = 60;

                 double transes = double.Parse(tutation_fee);

                 double descounts_transporation = transes - ((double.Parse(tutation_fee) * 15) / 100);

                 double descounts_sum = double.Parse(sums) - descounts_transporation;


                 commandDatabase_brother.CommandText = "Update student set sum ='" + descounts_sum + "'WHERE name ='" + name + "'";

                 commandDatabase_brother.ExecuteNonQuery();
                 commandDatabase_brother.Dispose();


                 try
                 {
                     for (int i = 0; i < int.Parse(num_brothers); i++)
                     {
                         double trans = double.Parse(tiotation_fee[i]);

                         double descount_transporation = trans - ((double.Parse(tiotation_fee[i]) * 15) / 100);

                         double descount_sum = descount_transporation - double.Parse(sum[i]);
                         MessageBox.Show(descount_sum + "");
                         commandDatabase.CommandText = "Update student set sum ='" + descount_sum + "'WHERE id ='" + id_brothers[i] + "'";
                         commandDatabase.ExecuteNonQuery();
                         commandDatabase.Dispose();
                     }




                     MessageBox.Show("Query successfully excuted");

                 }
                 catch (Exception e)
                 {
                     MessageBox.Show("Query Error :" + e.Message);
                 }


             }*/


        }






        private double discount(double sum)
        {
           


            if (int.Parse(num_brothers) >= 1 && int.Parse(num_brothers) <= 2)
            {
                sum = sum - (sum * 0.010);
            }
            else if (int.Parse(num_brothers) >= 3)
            {
                sum = sum - (sum * 0.015);

            }
            else
            {
                sum = sum;

            }
            
            return sum;


        }




        public bool IsValidation()
        {


            if (txt_student_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_student_name, "اختر اسم الطالب /ة", "خطأ في الإدخال");
                return false;
            }
            if (txt_brother_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_brother_name, "اختر اسم الأخ", "خطأ في الإدخال");
                return false;
            }
            return true;



        }





        private void updae_num_brother()
        {
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);
            MySqlCommand commandDatabase_brother = new MySqlCommand("", databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                String descount = "SELECT id_brother FROM brothers WHERE id_student ='" + id_student + "'";
                MySqlCommand commands;
                commands = new MySqlCommand(descount, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();
                int i = 0;
                while (myaReaders.Read())
                {                                    //ID                             
                    id_brothers[i] = myaReaders.GetString(0) + "\n";

                    i++;


                }

                myaReaders.Close();



            }
            catch (Exception)
            {

            }
            try
            {
                num_brothers = "";
                String count = "SELECT COUNT(*) FROM brothers WHERE name_student ='" + name_student + "'";
                MySqlCommand commands;
                commands = new MySqlCommand(count, databaseConnection);

                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {                                    //ID                             
                    num_brothers = num_brothers + myaReaders.GetString(0) + "\n";
                }

                myaReaders.Close();
               // MessageBox.Show("عدد الاخوة في الابديت"+num_brothers);
                for (int i = 0; i < int.Parse(num_brothers); i++)
                {

                    commandDatabase.CommandText = "Update student set number_of_brothers='" + num_brothers + "'WHERE id ='" + id_brothers[i] + "'";


                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();

                }
                commandDatabase_brother.CommandText = "Update student set number_of_brothers='" + num_brothers + "'WHERE name ='" + txt_student_name.SelectedItem.ToString() + "'";


                commandDatabase_brother.ExecuteNonQuery();
                commandDatabase_brother.Dispose();


              //  MessageBox.Show("Query successfully excuted");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error :" + ex.Message);
            }
        }

        private void regester_brothers()
        {




            DialogResult dialog = MessageBox.Show("تأكيد عملية إضافة الأخ   " + txt_brother_name.SelectedItem.ToString(), "إضافة أخ  ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {






                MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);

                commandDatabase.CommandTimeout = 60;
                try
                {



                    name_student = txt_student_name.SelectedItem.ToString();
                    name_brother = txt_brother_name.SelectedItem.ToString();

                    if (name_student.Equals(name_brother))
                    {
                        MessageBox.Show("لا يمكن اعتبار الأخ هو الطالب نفسه");
                        return;
                    }

                    sql = "SELECT id,name FROM student WHERE name='" + name_student + "'";

                    MySqlCommand command;
                    command = new MySqlCommand(sql, databaseConnection);


                    MySqlDataReader myaReader = command.ExecuteReader();

                    while (myaReader.Read())
                    {                     //ID                             
                        id_student = id_student + myaReader.GetString(0) + "\n";

                    }
                    myaReader.Close();


                    String sql2 = "", id_student2 = "";


                    sql2 = "SELECT id,name FROM student WHERE name='" + name_brother + "'";



                    MySqlCommand command2;
                    command2 = new MySqlCommand(sql2, databaseConnection);

                    MySqlDataReader myaReader2 = command2.ExecuteReader();

                    while (myaReader2.Read())
                    {                     //ID                             
                        id_student2 = id_student2 + myaReader2.GetString(0) + "\n";

                    }
                    myaReader2.Close();

                    commandDatabase.CommandText = "INSERT INTO brothers(id_student,id_brother,name_student,name_brother)VALUES('" + id_student + "','" + id_student2 + "','" + name_student + "','" + name_brother + "')";
                    commandDatabase.ExecuteNonQuery();
                    commandDatabase.Dispose();


                    //  MessageBox.Show(id_student + "      " + id_student2);

                    //  MessageBox.Show("Query successfully excuted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query Error :" + ex.Message);
                }

            }


            else if (dialog == DialogResult.No)
            {

                MessageBox.Show("لم تقم بإضافة الأخ  ");
                //e.Cancel = true;
            }


        }






        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void add_brother_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;

            int index = txt_student_name.FindString(name_student);
            txt_student_name.SelectedIndex = index;
        }

    }
}
