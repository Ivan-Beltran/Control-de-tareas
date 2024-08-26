using ControlDeTareasUI.CustomEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;


namespace ControlDeTareasUI.Main
{
    public partial class Login : Form
    {
        private InvalidLoginErrorHandler _invalidLoginErrorHandler;

        public Login()
        {
            InitializeComponent();
            _invalidLoginErrorHandler = new InvalidLoginErrorHandler();
            _invalidLoginErrorHandler.InvalidLoginNotification += OnInvalidLoginNotification;


        }

        public void OnInvalidLoginNotification(object sender, string message)
        {
            MessageBox.Show($"error:{message}",
                "evento personalizado",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string inputUser = userTextBox.Text;
            string inputpassword = passwordTextBox.Text;

            Users user1 = new Users("ivan", "ivan1234");
            if (user1.Validate(inputUser, inputpassword))
            {
                Task task = new Task();
                task.Show();
                this.Hide();
            }
            else
            {
                _invalidLoginErrorHandler.SendInvalidLoginNotification("credenciales incorrectas");
            }   
        }
    }
} 
