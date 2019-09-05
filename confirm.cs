using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekaz
{
    public partial class confirm : Form
    {
        string check="";
        MyValidation myvalidation = new MyValidation();

        public confirm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(txt_password.Text == "123123" )
            {
                if (check == "payment")
                {
                    this.Hide();
                    payments pay = new payments();
                    pay.Show();
                }
                else if (check == "showpayment")
                {
                    this.Hide();
                    showStudentPayment showStuPay = new showStudentPayment();
                    showStuPay.Show();

                }
                else
                {
                    MessageBox.Show("لقد تم الدخول إلى هذه النافذة بشكل غير متوقع , الرجاء إعادة المحاولة من جديد");
                }
            }
            else
            {
                myvalidation.ValidationMessage(txt_password, "كلمة سر خاطئة,,,أعد المحاولة", "خطأ في الإدخال");

            }
        }

        private void confirm_Load(object sender, EventArgs e)
        {
            ShardPreferance shard = new ShardPreferance();
             check = shard.Check;
        }
    }
}
