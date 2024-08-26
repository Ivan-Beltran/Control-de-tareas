using ControlDeTareasUI.CustomEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;

namespace ControlDeTareasUI.Main
{
    public partial class Task : Form
    {
        private AddTaskEventCompleted _addTaskEventCompleted;
        private DeleteTaskEvent _deleteTaskEvent;
        public Task()
        {
            InitializeComponent();
            _addTaskEventCompleted = new AddTaskEventCompleted();
            _addTaskEventCompleted.TaskAddCompleted += OnTaskCompleted;
            _deleteTaskEvent = new DeleteTaskEvent();
            _deleteTaskEvent.DeleteTaskNotification += OnDeleteTaskNotification;
        }

        public void OnDeleteTaskNotification(object sender, string message)
        {
            MessageBox.Show($"advertencia : {message}",
               "evento personalizado",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }


        public void OnTaskCompleted(object sender, string message)
        {
            MessageBox.Show($"guardado : {message}",
                "evento personalizado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private int taskcouenter = 1;
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newTaskTextBox.Text))
            {

                taskListBox.Items.Add(taskcouenter + "- " + newTaskTextBox.Text);
                taskcouenter++;
                _addTaskEventCompleted.SendTaskAddNotification("tarea agregada");
                newTaskTextBox.Clear();
            }
            else
            {
                MessageBox.Show("por favor ingrese una tarea",
                    "advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(taskListBox.SelectedItem != null)
            {
                _deleteTaskEvent.SendDeleteTaskNotification("esta apunto de eliminar esta tarea");
                taskListBox.Items.Remove(taskListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("ningun elemento seleccionado",
                    "advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}