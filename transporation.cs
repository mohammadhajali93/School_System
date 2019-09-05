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
    public partial class transporation : Form
    {


        string num_student_in_transporatin;
        string[] id_transporation = new string[2000];
        connection con = new connection();

        MySqlConnection databaseConnection;



        public transporation()
        {
            InitializeComponent();

            Load_transporation();

        }





        private void Load_transporation()
        {
            databaseConnection = new MySqlConnection(con.MySQLConnectionString);

            try
            {
                databaseConnection.Open();

                String sql, output = "";

                sql = "SELECT id,area FROM transportation_fee ORDER BY `transportation_fee`.`id` ASC";

                MySqlCommand command;
                command = new MySqlCommand(sql, databaseConnection);


                MySqlDataReader myaReader = command.ExecuteReader();
                int i = 0;
                while (myaReader.Read())
                {                            //ID                               
                    output = output + myaReader.GetString(1) + "\n";

                    comboBox1.Items.Add(myaReader.GetString(1));
                    id_transporation[i] = myaReader.GetString(0);

                    i++;

                }
                myaReader.Close();

            }



            catch (Exception)
            {

            }


        }





        private void transporation_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();

            int select = comboBox1.SelectedIndex;
            string id_transportion = "";
            for (int x = 0; x < 2000; x++)
            {
                if (select == x)
                {
                    id_transportion = id_transporation[x];
                }
            }
            String count = "SELECT COUNT(*) FROM student WHERE transporation_id ='" + id_transportion + "'";
            MySqlCommand commands;
            commands = new MySqlCommand(count, databaseConnection);

            MySqlDataReader myaReaders = commands.ExecuteReader();

            while (myaReaders.Read())
            {
                num_student_in_transporatin = myaReaders.GetString(0);
            }
            myaReaders.Close();
            label1.Text = num_student_in_transporatin;


            String sql;

            sql = "SELECT name FROM student WHERE transporation_id ='" + id_transportion + "'ORDER BY `student`.`id` DESC";

            MySqlCommand command;
            command = new MySqlCommand(sql, databaseConnection);


            MySqlDataReader myaReader = command.ExecuteReader();

            int i = 0;
            while (myaReader.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = myaReader.GetString(0);

                // dataGridView1.add
                i++;

            }
            myaReader.Close();


        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
