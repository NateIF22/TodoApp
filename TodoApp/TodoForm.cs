using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;


namespace TodoApp
{
    public partial class TodoForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Task> Tasks { get; set; }

        public TodoForm()
        {
            InitializeComponent();
            Tasks = new List<Task>();
        }

        public void UpdateContacts()
        {
            fpTasks.Controls.Clear();
            foreach (Task task in Tasks)
            {
                fpTasks.Controls.Add(new TaskControl(task));
            }
        }

        private void SortTasks()
        {
            if (Tasks.Count > 0)
            {
                Tasks.Sort((x, y) => DateTime.Parse(x.DueDate).CompareTo(DateTime.Parse(y.DueDate)));

                foreach (Task task in Tasks)
                {
                    task.Number = Tasks.IndexOf(task) + 1;
                }
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
            if (!DateTime.TryParse(txtDueDate.Text, out _))
            {
                MessageBox.Show("Invalid Due Date format.", "Error");
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
            // sort the tasks by date before adding them to the list box, and set Number property

            if (!IsValidInput())
            {
                return;
            }

            Task newTask = new Task
            {
                DueDate = DateTime.Parse(txtDueDate.Text).ToString("MM/dd/yyyy"),
                Description = txtTask.Text,
            };

            Tasks.Add(newTask);
            SortTasks();
            UpdateContacts();
            ClearInputFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            txtTask.Focus();
        }
    }
}
