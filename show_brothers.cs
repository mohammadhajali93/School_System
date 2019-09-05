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
    public partial class show_brothers : Form
    {
        connection con = new connection();

        MySqlConnection databaseConnection;



        public show_brothers()
        {
            InitializeComponent();
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);

            loaading_brothers_student();



        }

        private void show_brothers_Load(object sender, EventArgs e)
        {



            ShardPreferance shard = new ShardPreferance();
            string name_student = shard.Name;



            int index = comboBox3.FindString(name_student);
            comboBox3.SelectedIndex = index;

        }


        private void loaading_brothers_student()
        {
            try
            {
                databaseConnection.Open();

                String sqls, outputs = "";

                // sqls = "SELECT name_student FROM brothers";
                sqls = "SELECT name FROM student WHERE number_of_brothers >0 ORDER BY `student`.`id` DESC";

                MySqlCommand commands;
                commands = new MySqlCommand(sqls, databaseConnection);


                MySqlDataReader myaReaders = commands.ExecuteReader();

                while (myaReaders.Read())
                {                            //ID                               
                    outputs = outputs + myaReaders.GetString(0) + "\n";

                    comboBox3.Items.Add(myaReaders.GetString(0));
                }
                myaReaders.Close();



            }


            catch (Exception)
            {

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_brother_when_click_student();
        }


        private void show_brother_when_click_student()
        {
            string show_brothers = comboBox3.SelectedItem.ToString();



            try
            {
                String sqls, outputs = "";

               sqls = "SELECT name_brother FROM brothers WHERE name_student='" + show_brothers + "'";

                /* MySqlCommand commands;
                 commands = new MySqlCommand(sqls, databaseConnection);

                 MySqlDataReader myaReaders = commands.ExecuteReader();
                 dataGridView_brothers..Clear();

                 while (myaReaders.Read())
                 {                            //ID                               
                     outputs = outputs + myaReaders.GetString(0) + "\n";

                     comboBox4.Items.Add(myaReaders.GetString(0));
                 }
                 myaReaders.Close();
                 */

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqls, databaseConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView_brothers.Rows.Clear();

                foreach (DataRow datarow in dataTable.Rows)
                {
                    int n = dataGridView_brothers.Rows.Add();
                    dataGridView_brothers.Rows[n].Cells[0].Value = datarow[0].ToString();
                    

                }

            }


            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stu = new students();
            stu.Show();
        }
    }
}
