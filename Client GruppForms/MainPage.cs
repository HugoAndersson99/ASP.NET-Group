using Client_GruppForms.Objects;

namespace Client_GruppForms
{
    public partial class MainPage : Form
    {
        LoginPage loginPage;
        MediaUser mediaUser;
        public MainPage(MediaUser mediaUser, LoginPage loginPage)
        {
            InitializeComponent();
            this.loginPage = loginPage;
            this.mediaUser = mediaUser;
            ShowUser();
            CheckUser();
        }
        private void ShowUser()
        {
            userLabel.Text = mediaUser.FirstName + " " + mediaUser.LastName;
        }
        private void CheckUser()
        {
            if (mediaUser.Email == "admin")
            {
                adminPanel.Visible = true;
                userPanel.Visible = false;
            }
            else
            {
                adminPanel.Visible = false;
                userPanel.Visible = true;
            }
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void goToLibraryButton_Click(object sender, EventArgs e)
        {
            MediaLibrary mediaLibrary = new MediaLibrary(this.mediaUser);
            mediaLibrary.Show();
            this.Hide();
        }
    }
}
