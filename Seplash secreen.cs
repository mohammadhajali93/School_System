using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Rekaz
{
    public partial class Seplash_secreen : Form
    {

        public Seplash_secreen()
        {

                        InitializeComponent();

        }

        private void Seplash_secreen_Load(object sender, EventArgs e)
        {
            Seplash_secreen splash = new Seplash_secreen();
            log_in seplash = new log_in();
            Thread.Sleep(4000);
            this.Hide();
            seplash.Show();

        }
    }
}


