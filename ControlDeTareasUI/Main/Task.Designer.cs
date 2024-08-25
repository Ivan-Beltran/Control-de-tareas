namespace ControlDeTareasUI.Main
{
    partial class Task
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            newTaskLabel = new Label();
            newTaskTextBox = new TextBox();
            addTaskButton = new Button();
            TaskListBox = new ListBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(484, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(193, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "control de tareas";
            // 
            // newTaskLabel
            // 
            newTaskLabel.AutoSize = true;
            newTaskLabel.Location = new Point(110, 80);
            newTaskLabel.Name = "newTaskLabel";
            newTaskLabel.Size = new Size(158, 32);
            newTaskLabel.TabIndex = 1;
            newTaskLabel.Text = "nueva tarea : ";
            // 
            // newTaskTextBox
            // 
            newTaskTextBox.Location = new Point(307, 80);
            newTaskTextBox.Multiline = true;
            newTaskTextBox.Name = "newTaskTextBox";
            newTaskTextBox.Size = new Size(451, 34);
            newTaskTextBox.TabIndex = 2;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(836, 73);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(176, 45);
            addTaskButton.TabIndex = 3;
            addTaskButton.Text = "agragar tarea";
            addTaskButton.UseVisualStyleBackColor = true;
            // 
            // TaskListBox
            // 
            TaskListBox.FormattingEnabled = true;
            TaskListBox.ItemHeight = 31;
            TaskListBox.Location = new Point(110, 189);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(875, 376);
            TaskListBox.TabIndex = 4;
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 669);
            Controls.Add(TaskListBox);
            Controls.Add(addTaskButton);
            Controls.Add(newTaskTextBox);
            Controls.Add(newTaskLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Task";
            Text = "Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label newTaskLabel;
        private TextBox newTaskTextBox;
        private Button addTaskButton;
        private ListBox TaskListBox;
    }
}