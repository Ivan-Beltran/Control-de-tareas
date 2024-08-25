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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(463, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 41);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(463, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 41);
            textBox2.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(463, 403);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(236, 53);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "iniciar sescion";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 665);
            Controls.Add(LoginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(passwordLabel);
            Controls.Add(userLabel);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private Label passwordLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button LoginButton;
    }
}