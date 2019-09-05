using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekaz
{
    class MyValidation
    {
        public void ValidationMessage(Control control, string validationMessage, string header= "!!!!!!!!! خطأ")
        {
            control.BackColor = Color.LightPink;
            MessageBox.Show(validationMessage, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
            control.Focus();
        }

        



    }





}
