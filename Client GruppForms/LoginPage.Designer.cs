namespace Client_GruppForms
{
    partial class LoginPage
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
            loginPanel = new Panel();
            registerButton = new Button();
            loginButton = new Button();
            loginPasswordTextBox = new TextBox();
            loginEmailTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            registerPanel = new Panel();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            goBackButton = new Button();
            registerUserButton = new Button();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            exitButton = new Button();
            loginPanel.SuspendLayout();
            registerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(registerButton);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(loginPasswordTextBox);
            loginPanel.Controls.Add(loginEmailTextBox);
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(label1);
            loginPanel.Location = new Point(230, 45);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(340, 360);
            loginPanel.TabIndex = 1;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            registerButton.Location = new Point(100, 285);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(123, 37);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register new";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            loginButton.Location = new Point(100, 242);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(123, 37);
            loginButton.TabIndex = 10;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPasswordTextBox
            // 
            loginPasswordTextBox.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            loginPasswordTextBox.Location = new Point(157, 113);
            loginPasswordTextBox.Name = "loginPasswordTextBox";
            loginPasswordTextBox.PasswordChar = '*';
            loginPasswordTextBox.Size = new Size(145, 30);
            loginPasswordTextBox.TabIndex = 9;
            // 
            // loginEmailTextBox
            // 
            loginEmailTextBox.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            loginEmailTextBox.Location = new Point(157, 49);
            loginEmailTextBox.Name = "loginEmailTextBox";
            loginEmailTextBox.Size = new Size(145, 30);
            loginEmailTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 34);
            label2.TabIndex = 7;
            label2.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 34);
            label1.TabIndex = 6;
            label1.Text = "Email: ";
            // 
            // registerPanel
            // 
            registerPanel.Controls.Add(lastNameTextBox);
            registerPanel.Controls.Add(firstNameTextBox);
            registerPanel.Controls.Add(label5);
            registerPanel.Controls.Add(label6);
            registerPanel.Controls.Add(goBackButton);
            registerPanel.Controls.Add(registerUserButton);
            registerPanel.Controls.Add(passwordTextBox);
            registerPanel.Controls.Add(emailTextBox);
            registerPanel.Controls.Add(label3);
            registerPanel.Controls.Add(label4);
            registerPanel.Location = new Point(230, 45);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(340, 360);
            registerPanel.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            lastNameTextBox.Location = new Point(136, 198);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(145, 30);
            lastNameTextBox.TabIndex = 15;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            firstNameTextBox.Location = new Point(136, 152);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(145, 30);
            firstNameTextBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 194);
            label5.Name = "label5";
            label5.Size = new Size(107, 34);
            label5.TabIndex = 13;
            label5.Text = "Last Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 141);
            label6.Name = "label6";
            label6.Size = new Size(111, 34);
            label6.TabIndex = 12;
            label6.Text = "First Name:";
            // 
            // goBackButton
            // 
            goBackButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            goBackButton.Location = new Point(79, 285);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(123, 37);
            goBackButton.TabIndex = 11;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // registerUserButton
            // 
            registerUserButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            registerUserButton.Location = new Point(79, 242);
            registerUserButton.Name = "registerUserButton";
            registerUserButton.Size = new Size(123, 37);
            registerUserButton.TabIndex = 10;
            registerUserButton.Text = "Register";
            registerUserButton.UseVisualStyleBackColor = true;
            registerUserButton.Click += registerUserButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            passwordTextBox.Location = new Point(136, 95);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(145, 30);
            passwordTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            emailTextBox.Location = new Point(136, 49);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(145, 30);
            emailTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 91);
            label3.Name = "label3";
            label3.Size = new Size(112, 34);
            label3.TabIndex = 7;
            label3.Text = "Password: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 38);
            label4.Name = "label4";
            label4.Size = new Size(70, 34);
            label4.TabIndex = 6;
            label4.Text = "Email: ";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Agency FB", 14.25F, FontStyle.Bold);
            exitButton.Location = new Point(665, 401);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(123, 37);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit Program";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(loginPanel);
            Controls.Add(registerPanel);
            Name = "LoginPage";
            Text = "LoginPage";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button registerButton;
        private Button loginButton;
        private TextBox loginPasswordTextBox;
        private TextBox loginEmailTextBox;
        private Label label2;
        private Label label1;
        private Panel registerPanel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label label5;
        private Label label6;
        private Button goBackButton;
        private Button registerUserButton;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Label label3;
        private Label label4;
        private Button exitButton;
    }
}