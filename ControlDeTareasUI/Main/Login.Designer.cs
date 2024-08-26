namespace ControlDeTareasUI.Main
{
    partial class Login
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
            userLabel = new Label();
            passwordLabel = new Label();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(217, 101);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(116, 35);
            userLabel.TabIndex = 0;
            userLabel.Text = "usuario : ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(217, 255);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(156, 35);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "contraseña : ";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(463, 98);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(365, 41);
            userTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(463, 255);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(365, 41);
            passwordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(463, 403);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(236, 53);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "iniciar sescion";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 665);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private Label passwordLabel;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private Button LoginButton;
    }
}