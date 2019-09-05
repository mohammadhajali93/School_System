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
using Microsoft.VisualBasic;



namespace Rekaz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void payments_Click(object sender, EventArgs e)
        {

            confirm c = new confirm();
            c.Show();
            

        }

        private void students_Click(object sender, EventArgs e)
        {
            this.Hide();
            students stus = new students();
            stus.Show();
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_student ad_student = new add_student();
            ad_student.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void classs_section_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_class_section acs = new add_class_section();
            acs.Show();
        }

        private void brothers_Click(object sender, EventArgs e)
        {
            this.Hide();
            show_brothers show_bro = new show_brothers();
            show_bro.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void students_MouseHover(object sender, EventArgs e)
        {

        }

        private void transporation_Click(object sender, EventArgs e)
        {
            this.Hide();
            transporation trans = new transporation();
            trans.Show();
        }

        private void expenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses exp = new Expenses();
            exp.Show();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm addEmployee = new EmployeeForm();
            addEmployee.Show();
        }

        private void add_student_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            add_student addstudent = new add_student();
            addstudent.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_class_section add_cla_sec = new add_class_section();
            add_cla_sec.Show();
        }

        private void exports_Click(object sender, EventArgs e)
        {
            this.Hide();
            exports exp = new exports();
            exp.Show();
        }

        private void revenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Revenues revenues = new Revenues();
            revenues.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Daily_Fund daily_Fund = new Daily_Fund();
            daily_Fund.Show();
        }
    }
}
