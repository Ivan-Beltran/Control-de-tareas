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
            addTaskButton = new Button();
            newTaskTextBox = new TextBox();
            taskListBox = new ListBox();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(372, 7);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(145, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "control de tareas";
            // 
            // newTaskLabel
            // 
            newTaskLabel.AutoSize = true;
            newTaskLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            newTaskLabel.Location = new Point(59, 44);
            newTaskLabel.Margin = new Padding(2, 0, 2, 0);
            newTaskLabel.Name = "newTaskLabel";
            newTaskLabel.Size = new Size(131, 25);
            newTaskLabel.TabIndex = 1;
            newTaskLabel.Text = "nueva tarea : ";
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(1074, 40);
            addTaskButton.Margin = new Padding(2);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(136, 33);
            addTaskButton.TabIndex = 3;
            addTaskButton.Text = "agregar tarea";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // newTaskTextBox
            // 
            newTaskTextBox.Location = new Point(221, 42);
            newTaskTextBox.Margin = new Padding(2);
            newTaskTextBox.Multiline = true;
            newTaskTextBox.Name = "newTaskTextBox";
            newTaskTextBox.Size = new Size(642, 53);
            newTaskTextBox.TabIndex = 5;
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 23;
            taskListBox.Location = new Point(59, 157);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(927, 211);
            taskListBox.TabIndex = 6;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1074, 123);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(144, 29);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "terminar tarea";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1383, 697);
            Controls.Add(deleteButton);
            Controls.Add(taskListBox);
            Controls.Add(newTaskTextBox);
            Controls.Add(addTaskButton);
            Controls.Add(newTaskLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Task";
            Text = "Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label newTaskLabel;
        private Button addTaskButton;
        private TextBox newTaskTextBox;
        private ListBox taskListBox;
        private Button deleteButton;
    }
}