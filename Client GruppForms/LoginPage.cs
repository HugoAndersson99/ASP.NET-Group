using Client_GruppForms.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client_GruppForms
{
    public partial class LoginPage : Form
    {
        MyClient myClient = new MyClient();
        List<MediaUser> mediaUsers = new List<MediaUser>();
        MediaUser user;
        public LoginPage()
        {
            InitializeComponent();
            loginPanel.BringToFront();
            GetAllUsers();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
        }
        public void GetAllUsers()
        {
            mediaUsers.Clear();
            
            mediaUsers = myClient.GetAllUsers();
            
        }
        private void RegisterNewUser()
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            MediaUser newMediaUser = new MediaUser(email, password, firstName, lastName);
            myClient.AddNewMediaUser(newMediaUser);
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == null)
            {
                MessageBox.Show("You must enter your first name!");
                return;
            }
            if (lastNameTextBox.Text == null)
            {
                MessageBox.Show("You must enter your last name!");
                return;
            }
            if (emailTextBox.Text == null)
            {
                MessageBox.Show("You must enter a email!");
                return;
            }
            if (passwordTextBox.Text == null)
            {
                MessageBox.Show("You must enter a password!");
                return;
            }
            foreach (MediaUser user in mediaUsers)
            {
                if (emailTextBox.Text == user.Email)
                {
                    MessageBox.Show("That email already exists! Try again");
                    emailTextBox.Clear();
                    return;
                }
            }
            RegisterNewUser();
            GetAllUsers();
            MessageBox.Show("You are now Registered, Now u can login");
            registerPanel.SendToBack();
        }
        private bool CheckLogIn()
        {
            foreach (MediaUser user in mediaUsers)
            {
                if (loginEmailTextBox.Text == user.Email)
                {
                    return true;
                }
            }
            return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginEmailTextBox.Text != null && loginPasswordTextBox.Text != null)
            {
                bool login = CheckLogIn();
                if (login)
                {
                    foreach (MediaUser user in mediaUsers)
                    {
                        if (loginEmailTextBox.Text == user.Email && loginPasswordTextBox.Text == user.Password)
                        {
                            MainPage mainPage = new MainPage(user, this);
                            mainPage.Show();
                            loginEmailTextBox.Clear();
                            loginPasswordTextBox.Clear();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Email / Password");
                    passwordTextBox.Clear();
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerPanel.BringToFront();
        }
    }
}
