namespace TodoApp
{
    partial class TodoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTask = new Label();
            txtTask = new TextBox();
            txtDueDate = new TextBox();
            lblDueDate = new Label();
            gbCreateTask = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            gbToDo = new GroupBox();
            lblInstruct = new Label();
            fpTasks = new FlowLayoutPanel();
            gbCreateTask.SuspendLayout();
            gbToDo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Location = new Point(12, 26);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(36, 20);
            lblTask.TabIndex = 0;
            lblTask.Text = "Task";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(54, 23);
            txtTask.Name = "txtTask";
            txtTask.PlaceholderText = "Task Description";
            txtTask.Size = new Size(398, 27);
            txtTask.TabIndex = 1;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(90, 59);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "MM/DD/YYYY";
            txtDueDate.Size = new Size(362, 27);
            txtDueDate.TabIndex = 3;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 62);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(72, 20);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due Date";
            // 
            // gbCreateTask
            // 
            gbCreateTask.Controls.Add(btnClear);
            gbCreateTask.Controls.Add(btnAdd);
            gbCreateTask.Controls.Add(txtTask);
            gbCreateTask.Controls.Add(txtDueDate);
            gbCreateTask.Controls.Add(lblTask);
            gbCreateTask.Controls.Add(lblDueDate);
            gbCreateTask.Location = new Point(12, 12);
            gbCreateTask.Name = "gbCreateTask";
            gbCreateTask.Size = new Size(458, 142);
            gbCreateTask.TabIndex = 4;
            gbCreateTask.TabStop = false;
            gbCreateTask.Text = "Create Task";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(258, 92);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(358, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbToDo
            // 
            gbToDo.Controls.Add(fpTasks);
            gbToDo.Controls.Add(lblInstruct);
            gbToDo.Location = new Point(13, 192);
            gbToDo.Name = "gbToDo";
            gbToDo.Size = new Size(457, 249);
            gbToDo.TabIndex = 5;
            gbToDo.TabStop = false;
            gbToDo.Text = "Tasks To Do";
            // 
            // lblInstruct
            // 
            lblInstruct.AutoSize = true;
            lblInstruct.Location = new Point(146, 0);
            lblInstruct.Name = "lblInstruct";
            lblInstruct.Size = new Size(161, 20);
            lblInstruct.TabIndex = 1;
            lblInstruct.Text = "Click tasks to complete";
            // 
            // fpTasks
            // 
            fpTasks.Location = new Point(0, 23);
            fpTasks.Name = "fpTasks";
            fpTasks.Size = new Size(457, 226);
            fpTasks.TabIndex = 2;
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(gbToDo);
            Controls.Add(gbCreateTask);
            Name = "TodoForm";
            Text = "Form1";
            gbCreateTask.ResumeLayout(false);
            gbCreateTask.PerformLayout();
            gbToDo.ResumeLayout(false);
            gbToDo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTask;
        private TextBox txtTask;
        private TextBox txtDueDate;
        private Label lblDueDate;
        private GroupBox gbCreateTask;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox gbToDo;
        private Label lblInstruct;
        private FlowLayoutPanel fpTasks;
    }
}
