namespace TodoApp
{
    partial class TaskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTaskLabel = new Label();
            lblTask = new Label();
            lblDueDate = new Label();
            lblDueDateLabel = new Label();
            btnComplete = new Button();
            SuspendLayout();
            // 
            // lblTaskLabel
            // 
            lblTaskLabel.AutoSize = true;
            lblTaskLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTaskLabel.Location = new Point(44, 59);
            lblTaskLabel.Name = "lblTaskLabel";
            lblTaskLabel.Size = new Size(59, 28);
            lblTaskLabel.TabIndex = 0;
            lblTaskLabel.Text = "Task:";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Segoe UI", 12F);
            lblTask.Location = new Point(76, 87);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(130, 28);
            lblTask.TabIndex = 1;
            lblTask.Text = "Do the dishes";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 12F);
            lblDueDate.Location = new Point(156, 19);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(130, 28);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Do the dishes";
            // 
            // lblDueDateLabel
            // 
            lblDueDateLabel.AutoSize = true;
            lblDueDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDueDateLabel.Location = new Point(44, 19);
            lblDueDateLabel.Name = "lblDueDateLabel";
            lblDueDateLabel.Size = new Size(106, 28);
            lblDueDateLabel.TabIndex = 2;
            lblDueDateLabel.Text = "Due Date:";
            // 
            // btnComplete
            // 
            btnComplete.BackColor = SystemColors.ButtonHighlight;
            btnComplete.Location = new Point(315, 39);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(94, 29);
            btnComplete.TabIndex = 4;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnComplete);
            Controls.Add(lblDueDate);
            Controls.Add(lblDueDateLabel);
            Controls.Add(lblTask);
            Controls.Add(lblTaskLabel);
            Name = "TaskControl";
            Size = new Size(431, 136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskLabel;
        private Label lblTask;
        private Label lblDueDate;
        private Label lblDueDateLabel;
        private Button btnComplete;
    }
}
