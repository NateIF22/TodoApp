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
                lbTasks.Items.Add(task);
            }
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
    }
}
