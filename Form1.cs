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
    public partial class log_in : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;
        MyValidation myvalidation = new MyValidation();
        public log_in()
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);

            try { databaseConnection.Open(); }
            catch (Exception t)
            {
                // MessageBox.Show("خطأ.." + t.Message);
                MessageBox.Show("خطأ.." + "مشكلة في الاتصال مع قاعدة البيانات  تأكد من فتح قاعدة البيانات أولاً");
                //this.Close();
                return;
            }

        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

       

        private void login_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {

                    loginQuery();

                

            }
        }

        public bool IsValidation()
        {


            if (txt_user_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_user_name, "أدخل اسم المستخدم", "خطأ في الإدخال");
                return false;
            }
            if (txt_password.Text == "")
            {
                myvalidation.ValidationMessage(txt_password, "أدخل كلمة السر", "خطأ في الإدخال");
                return false;
            }
            return true;



        }

        

        private void loginQuery()
        {
            string user_name = txt_user_name.Text;
            string password = txt_password.Text;
            string query = "SELECT Count(*) FROM `login` WHERE user_name ='" + user_name + "'  and password='" + password + "'";



            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;
            
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);


            if (dataTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {

                MessageBox.Show("  ! اسم المستخدم أو كلمة السر غير صحيحة", "!!!!!!!!! خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl =  (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
