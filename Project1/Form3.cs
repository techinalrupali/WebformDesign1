﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Employee Id={txtEmployeeID.Text}\nEmployee Name={txtEmployeeName.Text}\nEmployee Salary={txtSalary.Text}\nEmployee Department={txtDepartment.Text}\n");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            txtEmployeeName.Clear();
            txtSalary.Clear();
            txtDepartment.Clear();
        }
    }
}
