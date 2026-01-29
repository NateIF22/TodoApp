namespace TodoApp
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblDueDate = new Label();
            gbCreateTask = new GroupBox();
            btnAdd = new Button();
            btnClear = new Button();
            gbToDo = new GroupBox();
            lbTasks = new ListBox();
            lblInstruct = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(54, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 27);
            textBox2.TabIndex = 3;
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
            gbCreateTask.Controls.Add(textBox1);
            gbCreateTask.Controls.Add(textBox2);
            gbCreateTask.Controls.Add(lblTask);
            gbCreateTask.Controls.Add(lblDueDate);
            gbCreateTask.Location = new Point(12, 12);
            gbCreateTask.Name = "gbCreateTask";
            gbCreateTask.Size = new Size(458, 142);
            gbCreateTask.TabIndex = 4;
            gbCreateTask.TabStop = false;
            gbCreateTask.Text = "Create Task";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(358, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(258, 92);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // gbToDo
            // 
            gbToDo.Controls.Add(lblInstruct);
            gbToDo.Controls.Add(lbTasks);
            gbToDo.Location = new Point(13, 192);
            gbToDo.Name = "gbToDo";
            gbToDo.Size = new Size(457, 249);
            gbToDo.TabIndex = 5;
            gbToDo.TabStop = false;
            gbToDo.Text = "Tasks To Do";
            // 
            // lbTasks
            // 
            lbTasks.FormattingEnabled = true;
            lbTasks.Location = new Point(6, 79);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(440, 164);
            lbTasks.TabIndex = 0;
            // 
            // lblInstruct
            // 
            lblInstruct.AutoSize = true;
            lblInstruct.Location = new Point(149, 56);
            lblInstruct.Name = "lblInstruct";
            lblInstruct.Size = new Size(167, 20);
            lblInstruct.TabIndex = 1;
            lblInstruct.Text = "Click to complete a task";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(gbToDo);
            Controls.Add(gbCreateTask);
            Name = "Form1";
            Text = "Form1";
            gbCreateTask.ResumeLayout(false);
            gbCreateTask.PerformLayout();
            gbToDo.ResumeLayout(false);
            gbToDo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTask;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblDueDate;
        private GroupBox gbCreateTask;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox gbToDo;
        private ListBox lbTasks;
        private Label lblInstruct;
    }
}
