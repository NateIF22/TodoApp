using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;


namespace TodoApp
{
    public partial class TodoForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Task> Tasks { get; set; }

        private BindingSource taskBindingSource;
        public TodoForm()
        {
            InitializeComponent();
            Tasks = new BindingList<Task>();
            taskBindingSource = new BindingSource();
            taskBindingSource.DataSource = Tasks;

            taskBindingSource.ListChanged += TaskBindingSource_ListChanged;
        }

        private void TaskBindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                var task = Tasks[e.NewIndex];
                AddTasksControl(task);
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                fpTasks.Controls.Clear();

                foreach (var task in Tasks)
                {
                    AddTasksControl(task);
                }
            }
        }

        private void AddTasksControl(Task task)
        {
            var item = new TaskControl(task);
            fpTasks.Controls.Add(item);
        }

        public void UpdateTasks()
        {
            fpTasks.Controls.Clear();
            foreach (Task task in Tasks)
            {
                fpTasks.Controls.Add(new TaskControl(task));
            }
        }

        public void AddTask(
            string description,
            string dueDate
            )
        {
            Tasks.Add(new Task
            {
                Description = description,
                DueDate = dueDate
            });
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
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
        
            ClearInputFields();
            txtTask.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            txtTask.Focus();
        }
    }
}
