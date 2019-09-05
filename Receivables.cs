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
    public partial class Receivables : Form
    {

        connection con = new connection();
        MySqlConnection databaseConnection;

        public Receivables()
        {
            InitializeComponent();


            databaseConnection = new MySqlConnection(con.MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand("", databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {

                databaseConnection.Open();
            }
            catch (Exception t)
            {
                MessageBox.Show("خطأ.." + t.Message);
                return;
            }
        }

        private void Receivables_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_rec();
        }

        private void Show_rec()
        {
            string query = "SELECT name,tuition_fee,uniform,transporation,public_books,private_books,others,sum FROM `student` ";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView3.Rows.Clear();

            foreach (DataRow datarow in dataTable.Rows)
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = datarow[0].ToString();
                dataGridView3.Rows[n].Cells[1].Value = datarow[1].ToString();
                dataGridView3.Rows[n].Cells[2].Value = datarow[2].ToString();
                dataGridView3.Rows[n].Cells[3].Value = datarow[3].ToString();
                dataGridView3.Rows[n].Cells[4].Value = datarow[4].ToString();
                dataGridView3.Rows[n].Cells[5].Value = datarow[5].ToString();
                dataGridView3.Rows[n].Cells[6].Value = datarow[6].ToString();
                dataGridView3.Rows[n].Cells[7].Value = datarow[7].ToString();
            }
        }
    }
}
