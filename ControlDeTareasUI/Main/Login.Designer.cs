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
            label2 = new Label();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(232, 101);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(122, 35);
            userLabel.TabIndex = 0;
            userLabel.Text = "usuario : ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(232, 255);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(164, 35);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "contraseña : ";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(496, 101);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(391, 41);
            userTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(496, 255);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(391, 41);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(496, 403);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(253, 53);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "iniciar session";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 591);
            label2.Name = "label2";
            label2.Size = new Size(543, 35);
            label2.TabIndex = 6;
            label2.Text = "el usuario es ivan y la contraseña es ivan1234";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1310, 665);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Font = new Font("Segoe UI", 15F, FontStyle.Bold);
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
        private Label label2;
    }
}