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
    public partial class payments : Form
    {

        string sum1="", student_id = "", name, tuition_fee, startDate = "", uniform="0", transportation="0", public_books="0", private_books="0", others="0", date, sql_id_name, sql_id_student, sum_orig="", sql_id_payment, sum_pay="", query, query1, query2;
        double summ = 0, sum_original=0, div=0, b=0;
        string name_receiver = "", receiver="";
        private void txt_name_receiver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        MyValidation myvalidation = new MyValidation();
        double outNumber;
        string output = "";

        private void txt_receipt_number_ValueChanged(object sender, EventArgs e)
        {

        }

        MySqlCommand command_name,  commandDatabase, commandDatabase1, commandDatabase2;

        private void button2_Click(object sender, EventArgs e)
        {


            percent();
        }

        private void percent()
        {
            sql_id_student = "SELECT `id`,`sum_original`,`start_date` FROM student WHERE name='" + txt_name.Text + "'";

            MySqlCommand command_name = new MySqlCommand(sql_id_student, databaseConnection);

            MySqlDataReader myaReader_name1 = command_name.ExecuteReader();
            while (myaReader_name1.Read())
            {
                student_id = myaReader_name1.GetString(0);
                sum_orig = myaReader_name1.GetString(1);
                startDate = myaReader_name1.GetString(2);


            }
            myaReader_name1.Close();
            sum_original = double.Parse(sum_orig);



            div = sum_original / 270;
            DateTime now = DateTime.Now;
            //string currentDate = now.ToString("dd/MM/yyyy");
            string sub = now.Subtract(Convert.ToDateTime(startDate)).Days.ToString();
            int days = int.Parse(sub);

            sql_id_payment = "SELECT `sum` FROM payments WHERE student_id='" + student_id + "'";

            MySqlCommand command_pay = new MySqlCommand(sql_id_payment, databaseConnection);

            MySqlDataReader myaReader_pay = command_pay.ExecuteReader();
            while (myaReader_pay.Read())
            {
                sum_pay = myaReader_pay.GetString(0);
                double a = double.Parse(sum_pay);
                b += a;

            }
            myaReader_pay.Close();
            int q = Convert.ToInt32(b - (div * days));


            MessageBox.Show("تقريباً" + "\t" + q.ToString() + "\t" + " المبلغ الفائض من دفعات الطالب ");


        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        MySqlDataReader myaReader_name1 ,myReader_sum1;
        connection con = new connection();
        MySqlConnection databaseConnection;


        public payments()
        {
            InitializeComponent();
            
              databaseConnection = new MySqlConnection(con.MySQLConnectionString);
           

                try { databaseConnection.Open(); }
               catch (Exception t)
               {
                   MessageBox.Show("خطأ.." + t.Message);
                   return;
               }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                submitMethod();
            }
        }

        private void submitMethod()
        {


            tuition_fee = txt_tuition_fee.Text;
            name = txt_name.Text;
         name_receiver = txt_name_receiver.SelectedItem.ToString();
            date = txt_date.Text;
           int month_no= txt_date.Value.Month;
            int year_no = txt_date.Value.Year;

            string sql = "SELECT id,user_name FROM login WHERE user_name='" + name_receiver + "'";

            MySqlCommand command;
            command = new MySqlCommand(sql, databaseConnection);


            MySqlDataReader myaReader = command.ExecuteReader();

            while (myaReader.Read())
            {                     //ID                             
                receiver = receiver + myaReader.GetString(0) + "\n";

            }


            myaReader.Close();






            sql_id_name = "SELECT `id` FROM student WHERE name='" + name + "'";
            
            command_name = new MySqlCommand(sql_id_name, databaseConnection);

            myaReader_name1 = command_name.ExecuteReader();
            while (myaReader_name1.Read())
            {
                student_id = myaReader_name1.GetString(0);
            }
            myaReader_name1.Close();

            summ = double.Parse(tuition_fee) + double.Parse(uniform) + double.Parse(transportation) + double.Parse(public_books) + double.Parse(private_books) + double.Parse(others);


            query = "INSERT INTO `payments`(`student_id`,`tuition_fee`,`uniform`,`transportation`,`public_books`,`private_books`,`others`,`date`,`sum`,`receiver_name`,`year_no`,`month_no`) VALUES ('" + student_id + "','" + tuition_fee + "','" + uniform + "','" + transportation + "','" + public_books + "','" + private_books + "','" + others + "','" + date + "','" + summ + "','" + receiver + "','" + year_no + "','" + month_no + "')";
            

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            query1 = "SELECT `sum` FROM `student` WHERE id='" + student_id + "'";

            commandDatabase1 = new MySqlCommand(query1, databaseConnection);
            commandDatabase1.CommandTimeout = 60;
            myReader_sum1 = commandDatabase1.ExecuteReader();
            while (myReader_sum1.Read())
            {
                sum1 = myReader_sum1.GetString(0);
            }
            myReader_sum1.Close();


            double sub =double.Parse( sum1) - summ;
            query2 = "UPDATE `student` SET `sum`='" + sub + "' WHERE id='" + student_id + "'";



            commandDatabase2 = new MySqlCommand(query2, databaseConnection);
            commandDatabase2.CommandTimeout = 60;

            try
            {




                // databaseConnection.Open();
                // commandDatabase.CommandText = query;
                // commandDatabase.ExecuteNonQuery();
                commandDatabase1.ExecuteNonQuery();
                commandDatabase2.ExecuteNonQuery();
                int i = commandDatabase.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(" لقد دفع" + "\"" + name + "\"" + "... فاتورته بنجاح");

                    empty_texts();
                }
                else
                {
                    MessageBox.Show("!لم يتم تسجيل الفاتورة ");

                }


                commandDatabase.Dispose();
                commandDatabase2.Dispose();




            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }



        }




       
        private bool IsValidate()
        {

            try
            {


                if (txt_uniform.Text != "")
                {
                    uniform = txt_uniform.Text;
                }
                
                if (txt_private_books.Text != "")
                {
                    private_books = txt_private_books.Text;
                }
                if (txt_others.Text != "")
                {
                    others = txt_others.Text;
                }
                if (txt_public_books.Text != "")
                {
                    public_books = txt_public_books.Text;
                }
                if (txt_transportation.Text != "")
                {
                    transportation = txt_transportation.Text;
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }

            if (txt_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_name, "من فضلك اختر اسم الطالب ", "خطأ في الإدخال");
                return false;
            }

            if (txt_tuition_fee.Text == "")
            {
                myvalidation.ValidationMessage(txt_tuition_fee, "من فضلك أدخل قيمة القسط المقبوض  ", "خطأ في الإدخال");
                return false;
            }

            else if (!double.TryParse(txt_tuition_fee.Text, out outNumber))
            {
                txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة القسط المقبوض عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tuition_fee.Focus();
                return false;
            }

            
             if (txt_public_books.Text != "" && !double.TryParse(txt_public_books.Text, out outNumber))
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة الكتب العامة عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (!double.TryParse(txt_uniform.Text, out outNumber) && txt_uniform.Text != "")
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة الزي المدرسي عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (!double.TryParse(txt_private_books.Text, out outNumber) && txt_private_books.Text != "")
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة الكتب الخاصة عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (!double.TryParse(txt_others.Text, out outNumber) && txt_others.Text != "")
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                MessageBox.Show(" يجب ان تكون قيمة  المستحقات الأخرى عدد ", "خطأ عددي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  txt_tuition_fee.Focus();
                return false;
            }
            if (txt_name_receiver.Text == "" )
            {
                // txt_tuition_fee.BackColor = Color.LightPink;
                myvalidation.ValidationMessage(txt_name_receiver, "من فضلك اختار اسم المستلم     ", "خطأ في الإدخال");
                //  txt_tuition_fee.Focus();
                return false;
            }
            return true;
        }

        private void empty_texts()
        {
            //txt_receipt_number.Text = "";
            txt_name.Text = "";
            txt_tuition_fee.Text = "";
            txt_uniform.Text = "";
            txt_transportation.Text = "";
            txt_public_books.Text = "";
            txt_private_books.Text = "";
            txt_others.Text = "";
            txt_date.Text = "";
        }

        private void payments_Load(object sender, EventArgs e)
        {
            
            load_data_into_combo();
            loading_receiver_in_combobox();

            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;



            int index = txt_name.FindString(name_student);
            txt_name.SelectedIndex = index;

        }

        private void loading_receiver_in_combobox()
        {


            try
            {




                string sql = "SELECT id,user_name FROM login ORDER BY `login`.`id` ASC";

                MySqlCommand command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();

                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    txt_name_receiver.Items.Add(myaReader.GetString(1));
                }
                myaReader.Close();



            }


            catch (Exception)
            {

            }

        }

        private void load_data_into_combo()
        {

            try
            {

                String sql_name, output_name = "";

                sql_name = "SELECT id,name FROM student ORDER BY `student`.`id` DESC";

                MySqlCommand command_name = new MySqlCommand(sql_name, databaseConnection);



                MySqlDataReader myaReader_name = command_name.ExecuteReader();

                while (myaReader_name.Read())
                {
                    output_name = output_name + myaReader_name.GetString(1) + "\n";
                    txt_name.Items.Add(myaReader_name.GetString(1));
                }
                myaReader_name.Close();


                

            }



            catch (Exception ex)
            {
                MessageBox.Show("خطأ.." + ex.Message);

            }

        }



    }
}
