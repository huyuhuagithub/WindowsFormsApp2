using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int gitint = 100;
            if (gitint<900)
            {
                MessageBox.Show("小于900", "提示框");
                if (gitint<80)
                {
                    MessageBox.Show("小于80", "提示框");
                }
                if (gitint<60)
                {
                    MessageBox.Show("小于60", "提示框");
                }
                if (gitint < 10)
                {
                    MessageBox.Show("小于10", "提示框");
                }
            }
            else
            {
                MessageBox.Show($"大于{gitint}", "提示框");
            }
           

        }
    }
}
