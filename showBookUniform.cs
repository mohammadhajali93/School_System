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
    public partial class showBookUniform : Form
    {
        connection con = new connection();

        MySqlConnection databaseConnection;


        public showBookUniform()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                dataGridView_book.Rows.Clear();
                loading_info_stu_book();

            
        }

        private void loading_info_stu_book()
        {


            string num_public_books = "", num_private_books = "", private_books="", public_books="";
            double summ_private_books = 0, summ_public_books=0;
            String count_private_book = "SELECT COUNT(*) FROM student WHERE private_books!='" + 0 + "'";

            MySqlCommand commands_private_book = new MySqlCommand(count_private_book, databaseConnection);

            MySqlDataReader myaReaders = commands_private_book.ExecuteReader();

            while (myaReaders.Read())
            {
                num_private_books = myaReaders.GetString(0);
            }

            label_num_stu_private_books.Text = num_private_books;
            myaReaders.Close();



            String count_public_book = "SELECT COUNT(*) FROM student WHERE public_books!='" + 0 + "'";
            MySqlCommand commands_public_book = new MySqlCommand(count_public_book, databaseConnection);

            MySqlDataReader myaReaders_public = commands_public_book.ExecuteReader();

            while (myaReaders_public.Read())
            {
                num_public_books = myaReaders_public.GetString(0);
            }

            label_num_stu_public_books.Text = num_public_books;
            myaReaders_public.Close();



            try
            {
                String sql = "SELECT name,private_books FROM student WHERE private_books !='" + 0 + "'";
                MySqlCommand commands;

                commands = new MySqlCommand(sql, databaseConnection);

                MySqlDataReader myaReaderss_private = commands.ExecuteReader();

                while (myaReaderss_private.Read())
                {
                    private_books = myaReaderss_private.GetString(1);
                    summ_private_books += double.Parse(private_books);
                    int n = dataGridView_book.Rows.Add();
                    // MessageBox.Show("myaReaderss.GetString(1)" + myaReaderss.GetString(1));
                    // MessageBox.Show("myaReaderss.GetString(0)" + myaReaderss.GetString(0));

                    dataGridView_book.Rows[n].Cells[0].Value = myaReaderss_private.GetString(0);
                    dataGridView_book.Rows[n].Cells[1].Value = myaReaderss_private.GetString(1);

                }
                myaReaderss_private.Close();








                sum_private_books.Text = summ_private_books.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                String sql = "SELECT name,public_books FROM student WHERE public_books !='" + 0 + "'";
                MySqlCommand commands;

                commands = new MySqlCommand(sql, databaseConnection);

                MySqlDataReader myaReaderss_public = commands.ExecuteReader();

                while (myaReaderss_public.Read())
                {
                    public_books = myaReaderss_public.GetString(1);
                    summ_public_books += double.Parse(public_books);
                    int n = dataGridView_book.Rows.Add();
                    // MessageBox.Show("myaReaderss.GetString(1)" + myaReaderss.GetString(1));
                    // MessageBox.Show("myaReaderss.GetString(0)" + myaReaderss.GetString(0));

                    dataGridView_book.Rows[n].Cells[0].Value = myaReaderss_public.GetString(0);
                    dataGridView_book.Rows[n].Cells[2].Value = myaReaderss_public.GetString(1);

                }
                myaReaderss_public.Close();








                sum_bublic_books.Text = summ_public_books.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                dataGridView_uniform.Rows.Clear();
                loading_info_stu_uniform();

            
        }

        private void loading_info_stu_uniform()
        {


            string num_uni = "",uniform="";
            double uniformm = 0;
            String count_uni = "SELECT COUNT(*) FROM student WHERE uniform!='" + 0 + "'";
            MySqlCommand commands_count_uni= new MySqlCommand(count_uni, databaseConnection);

            MySqlDataReader myaReaders = commands_count_uni.ExecuteReader();

            while (myaReaders.Read())
            {
                num_uni = myaReaders.GetString(0);
            }

            lab_num_stu_uniform.Text = num_uni;
            myaReaders.Close();
            


            try
            {
                String sql = "SELECT name,uniform FROM student WHERE uniform !='" + 0 + "'";
                MySqlCommand commands;

                commands = new MySqlCommand(sql, databaseConnection);

                MySqlDataReader myaReaderss = commands.ExecuteReader();

                while (myaReaderss.Read())
                {
                    uniform = myaReaderss.GetString(1);
                    uniformm += double.Parse(uniform);
                    int n = dataGridView_uniform.Rows.Add();
                   // MessageBox.Show("myaReaderss.GetString(1)" + myaReaderss.GetString(1));
//MessageBox.Show("myaReaderss.GetString(0)" + myaReaderss.GetString(0));

                    dataGridView_uniform.Rows[n].Cells[0].Value = myaReaderss.GetString(0);
                    dataGridView_uniform.Rows[n].Cells[1].Value = myaReaderss.GetString(1);

                }
                myaReaders.Close();








                sum_uniform.Text = uniformm.ToString() ;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showBookUniform_Load(object sender, EventArgs e)
        {

        }
    }
}
