using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Student Name:{txtName.Text}\nAddress:{txtPhoneNo.Text}\n" +
                $"Phone No.:{txtAge.Text}\n Birth of Date:{dateTimePicker1.Value}\n" +
                $"Age:{txtAddress.Text}"

                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhoneNo.Clear();
            txtAge.Clear();
            txtAddress.Clear();
        }
    }
}
