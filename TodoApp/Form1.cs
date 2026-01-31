using System.Diagnostics;

namespace TodoApp
{
    public partial class Form1 : Form
    {
        public List<Task> Tasks { get; set; }

        public Form1()
        {
            InitializeComponent();
            Tasks = new List<Task>();
        }

        public void UpdateContactListBox()
        {
            lbTasks.Items.Clear();
            foreach (Task task in Tasks)
            {
                // make sort by due date
                lbTasks.Items.Add(task);
            }
        }

        private bool IsValidInput()
        {
            // Validate the input fields
            // If invalid, show a message box and return

            if (txtTask.Text.Length <= 0)
            {
                MessageBox.Show("A Task description is required", "Error");
                txtDueDate.Focus();
                return false;
            }

            if (txtDueDate.Text.Length <= 0)
            {
                MessageBox.Show("A Due Date is required", "Error");
                txtDueDate.Focus();
                return false;
            }
            return true;
        }

        public void ClearInputFields()
        {
            txtDueDate.Clear();
            txtTask.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the task from the input box
            // Create a new task item
            // Add the task item to the list
            if (!IsValidInput())
            {
                return;
            }

            Task newTask = new Task
            {
                DueDate = txtDueDate.Text,
                Description = txtTask.Text,
            };
            Tasks.Add(newTask);
            UpdateContactListBox();
            ClearInputFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void lbTasks_click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)lbTasks.SelectedItem;

            if (selectedTask != null)
            {
                // Toggle the task's completion
                selectedTask.IsCompleted = !selectedTask.IsCompleted;
                // Update the list box to reflect the new change
                UpdateContactListBox();
            }
        }
    }
}
