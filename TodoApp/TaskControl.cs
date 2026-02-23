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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Task TaskDetails { get; set; }
        public TaskControl(Task taskDetails)
        {
            InitializeComponent();
            TaskDetails = taskDetails;

            lblTask.DataBindings.Add("Text", TaskDetails, "Description");
            lblDueDate.DataBindings.Add("Text", TaskDetails, "DueDate");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var frm = this.FindForm() as TodoForm;

            if (frm != null)
            {
                // delete myself from the list of contacts on the base for.
                frm.Tasks.Remove(TaskDetails);
                frm.UpdateContacts();
                Console.WriteLine($"Task '{TaskDetails.Description}' marked as complete and removed from the list.");
            }
        }
    }

}
