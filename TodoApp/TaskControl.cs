using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class TaskControl : UserControl
    {
        public TaskControl(Task taskDetails)
        {
            InitializeComponent();
            lblTask.Text = taskDetails.Description;
            lblDueDate.Text = taskDetails.DueDate;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Task of type: {lblTask.Text} Completed!");
        }

        private void lblTaskLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
