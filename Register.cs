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
    public partial class Register : Form
    {
        connection con = new connection();
        MySqlConnection databaseConnection;

        MyValidation myvalidation = new MyValidation();


        public Register()
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

        public bool IsValidation()
        {


            if (txt_user_name.Text == "")
            {
                myvalidation.ValidationMessage(txt_user_name, " ادخل اسم المستحدم  ", "خطأ في الإدخال");
                return false;
            }
            if (txt_password.Text == "")
            {
                myvalidation.ValidationMessage(txt_password, " ادخل كلمة السر", "خطأ في الإدخال");
                return false;
            }


            return true;



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;
           


            string query = "SELECT * FROM `login` ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            gvUsers.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = gvUsers.Rows.Add();
                gvUsers.Rows[n].Cells[0].Value = datarow[0].ToString();
                gvUsers.Rows[n].Cells[1].Value = datarow[1].ToString();
               

            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Main = new Main();
            Main.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {
                register();
            }
        }


        private void register()
        {
            string user_name = txt_user_name.Text;
            string password = txt_password.Text;

            string query = "INSERT INTO `login`(`user_name`,`password`) VALUES ('" + this.txt_user_name.Text + "','" + this.txt_password.Text + "')";


            if (user_name == "")
            {
                MessageBox.Show("من فضلك أدخل اسم المستخدم ");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("من فضلك أدخل كلمة السر");
                return;
            }
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;



            try{
                 commandDatabase.CommandText = query;
                 int i= commandDatabase.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show(" تم تسجيل" + "\""+user_name+"\"" + "بنجاح ");

                    txt_user_name.Text="";
                     txt_password.Text="";
                }
                else
                {
                    MessageBox.Show("!لم يتم تسجيل الموظف ");

                }
                commandDatabase.Dispose();
                 



            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ.." + e.Message);

            }



        }

        private void gvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ctrl_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
    }
}
