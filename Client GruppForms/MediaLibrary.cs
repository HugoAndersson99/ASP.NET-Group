using Client_GruppForms.Objects;

namespace Client_GruppForms
{
    public partial class MediaLibrary : Form
    {
        MediaUser mediaUser;
        LoginPage loginPage;

        public MediaLibrary(MediaUser mediaUser)
        {
            InitializeComponent();
            this.mediaUser = mediaUser;
            ShowUser();
            ShowMediaLibrary();
        }

        private void ShowMediaLibrary()
        {
            //Visa filmer och serier i respektive listbox
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            mediaUser = null;

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
        private void ShowUser()
        {
            userLabel.Text = mediaUser.FirstName + " " + mediaUser.LastName;
        }
    }
}
