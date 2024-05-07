using Client_GruppForms.Objects;

namespace Client_GruppForms
{
    public partial class MainPage : Form
    {
        MyClient myClient = new MyClient();
        LoginPage loginPage;
        MediaUser mediaUser;
        List<Movie> movieList;
        List<Serie> serieList;
        public MainPage(MediaUser mediaUser, LoginPage loginPage)
        {
            InitializeComponent();
            this.loginPage = loginPage;
            this.mediaUser = mediaUser;
            ShowUser();
            CheckUser();
            GetMedia();
            SetUser();
        }
        private void SetUser()
        {
            myClient.SetUser(mediaUser);
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
        private void GetMedia()
        {
            movieList = myClient.GetAllMovies();
            serieList = myClient.GetAllSeries();

            foreach (Movie movie in movieList)
            {
                moviesListBox.Items.Add(movie.Title);
            }
            foreach (Serie serie in serieList)
            {
                seriesListBox.Items.Add(serie.Title);
            }
        }

        private void moviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seriesListBox.SelectedItems.Clear();
            if (moviesListBox.SelectedItems != null)
            {
                string choosenMovie = moviesListBox.SelectedItem.ToString();

                foreach (Movie movie in movieList)
                {
                    string str = movie.Title;
                    if (str == choosenMovie)
                    {
                        ViewMovie(movie.Title);
                    }
                }
            }
        }

        private void ViewMovie(string title)
        {
            foreach (Movie movie in movieList)
            {
                if (movie.Title == title)
                {
                    titleLabel.Text = movie.Title;
                    descriptionLabel.Text = movie.Description;
                    genreTextLabel.Text = movie.Genre;
                    yearTextLabel.Text = movie.ReleaseYear.ToString();
                    lengthTextLabel.Text = movie.LengthMin.ToString();

                    changeGenreLabel.Text = "Genre";
                    changeLengthLabel.Text = "Length(Minutes):";

                    mediaPanel.Visible = true;
                }
            }
        }
        private void ViewSerie(string title)
        {
            foreach (Serie serie in serieList)
            {
                if (serie.Title == title)
                {
                    titleLabel.Text = serie.Title;
                    descriptionLabel.Text = serie.Description;
                    genreTextLabel.Text = serie.Seasons.ToString();
                    yearTextLabel.Text = serie.ReleaseYear.ToString();
                    lengthTextLabel.Text = serie.Episodes.ToString();

                    changeGenreLabel.Text = "Seasons";
                    changeLengthLabel.Text = "Episodes";

                    mediaPanel.Visible = true;
                }
            }
        }

        private void seriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //moviesListBox.SelectedItems.Clear();
            if (seriesListBox.SelectedItems != null)
            {
                string choosenSerie = seriesListBox.SelectedItem.ToString();

                foreach (Serie serie in serieList)
                {
                    string str = serie.Title;

                    if (str == choosenSerie)
                    {
                        ViewSerie(serie.Title);
                    }
                }
            }

        }

        private void addToLibraryButton_Click(object sender, EventArgs e)
        {
            foreach (Serie serie in serieList)
            {
                if (serie.Title == titleLabel.Text)
                {

                    //choosenSerie = serie;
                    bool test = myClient.AddSerieToLibrary(serie);
                }
            }
            foreach (Movie movie in movieList)
            {
                if (movie.Title == titleLabel.Text)
                {

                    //movie.Users.Add(mediaUser);
                    //mediaUser.MoviesInLibrary.Add(movie);
                    bool test = myClient.AddMovieToLibrary(movie);
                }
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPage.Show();
        }
    }
}
