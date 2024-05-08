using Client_GruppForms.Objects;

namespace Client_GruppForms
{
    public partial class MediaLibrary : Form
    {
        MyClient myClient = new MyClient();
        MediaUser mediaUser;
        List<Movie> userMovies;
        List<Serie> userSeries;

        public MediaLibrary(MediaUser mediaUser)
        {
            InitializeComponent();
            this.mediaUser = mediaUser;
            ShowUser();
            ShowMediaLibrary();
        }

        private void ShowMediaLibrary()
        {
            userMovies = myClient.GetUserMovies(mediaUser);
            userSeries = myClient.GetUserSeries(mediaUser);

            if (userMovies != null && userMovies.Count > 0)
            {
                foreach (Movie movie in userMovies)
                {
                    moviesLibraryListBox.Items.Add(movie.Title);
                }
            }
            else
            {
                moviesLibraryListBox.Items.Add("No movies added");
            }


            if (userSeries != null && userSeries.Count > 0)
            {
                foreach (Serie serie in userSeries)
                {
                    seriesLibraryListBox.Items.Add(serie.Title);
                }
            }
            else
            {
                seriesLibraryListBox.Items.Add("No series added");
            }
        }

        private void ViewMovie(string title)
        {
            foreach (Movie movie in userMovies)
            {
                if (movie.Title == title)
                {
                    titleLabel.Text = movie.Title;
                    descriptionText.Text = movie.Description;
                    genreText.Text = movie.Genre;
                    yearText.Text = movie.ReleaseYear.ToString();
                    lengthText.Text = movie.LengthMin.ToString();

                    descriptionText.Visible = true;
                    genreText.Visible = true;
                    yearText.Visible = true;
                    lengthText.Visible = true;

                    changeGenreLabel.Text = "Genre";
                    changeLengthLabel.Text = "Length(Minutes):";

                }
            }
        }

        private void ViewSerie(string title)
        {
            foreach (Serie serie in userSeries)
            {
                if (serie.Title == title)
                {
                    titleLabel.Text = serie.Title;
                    descriptionText.Text = serie.Description;
                    genreText.Text = serie.Seasons.ToString();
                    yearText.Text = serie.ReleaseYear.ToString();
                    lengthText.Text = serie.Episodes.ToString();

                    descriptionText.Visible = true;
                    genreText.Visible = true;
                    yearText.Visible = true;
                    lengthText.Visible = true;

                    changeGenreLabel.Text = "Seasons";
                    changeLengthLabel.Text = "Episodes";

                }
            }
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

        private void moviesLibraryListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //seriesListBox.SelectedItems.Clear();
            if (moviesLibraryListBox.SelectedItems != null)
            {
                string choosenMovie = moviesLibraryListBox.SelectedItem.ToString();

                foreach (Movie movie in userMovies)
                {
                    string str = movie.Title;
                    if (str == choosenMovie)
                    {
                        ViewMovie(movie.Title);
                    }
                }
            }
        }

        private void seriesLibraryListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //seriesListBox.SelectedItems.Clear();
            if (seriesLibraryListBox.SelectedItems != null)
            {
                string choosenSerie = seriesLibraryListBox.SelectedItem.ToString();

                foreach (Serie serie in userSeries)
                {
                    string str = serie.Title;
                    if (str == choosenSerie)
                    {
                        ViewSerie(serie.Title);
                    }
                }
            }
        }
    }
}
