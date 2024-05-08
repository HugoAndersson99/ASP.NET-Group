using Client_GruppForms.Objects;

namespace Client_GruppForms
{
    public partial class MediaLibrary : Form
    {
        MyClient myClient = new MyClient();
        MediaUser mediaUser;
        List<Movie> userMovies;
        List<Serie> userSeries;
        MainPage MainPage;

        public MediaLibrary(MediaUser mediaUser, MainPage mainPage)
        {
            InitializeComponent();
            this.mediaUser = mediaUser;
            this.MainPage = mainPage;
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
            string choosenMovie = "";
            //seriesListBox.SelectedItems.Clear();
            if (moviesLibraryListBox.SelectedItems != null)
            {
                if (moviesLibraryListBox.SelectedIndex >= 0)
                {
                    choosenMovie = moviesLibraryListBox.SelectedItem.ToString();
                }
                if (userMovies != null)
                {
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
        }

        private void seriesLibraryListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string choosenSerie = "";
            //seriesListBox.SelectedItems.Clear();
            if (seriesLibraryListBox.SelectedItems != null)
            {
                if (seriesLibraryListBox.SelectedIndex >= 0)
                {
                    choosenSerie = seriesLibraryListBox.SelectedItem.ToString();
                }

                if (userSeries != null)
                {
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage.Show();
        }

        private void removeFromLibraryButton_Click(object sender, EventArgs e)
        {
            //foreach (Serie serie in userSeries)
            //{
            //    if (serie.Title == titleLabel.Text)
            //    {

            //        //choosenSerie = serie;
            //        bool test = myClient.RemoveSerieFromLibrary(serie);
            //        MessageBox.Show("Removed serie from your library!");
            //    }
            //}
            //foreach (Movie movie in userMovies)
            //{
            //    if (movie.Title == titleLabel.Text)
            //    {

            //        //movie.Users.Add(mediaUser);
            //        //mediaUser.MoviesInLibrary.Add(movie);
            //        bool test = myClient.RemoveMovieFromLibrary(movie);
            //        MessageBox.Show("Removed movie from your library!");
            //    }
            //}

            bool isRemoved = false; // Används för att kontrollera om något objekt togs bort

            if (userSeries != null)
            {
                foreach (Serie serie in userSeries)
                {
                    if (serie.Title == titleLabel.Text)
                    {
                        bool test = myClient.RemoveSerieFromLibrary(serie);
                        if (test)
                        {
                            MessageBox.Show("Serie removed from your library!");
                            isRemoved = true; // Markera att en serie togs bort
                        }
                    }
                }
            }

            if (userMovies != null)
            {
                foreach (Movie movie in userMovies)
                {
                    if (movie.Title == titleLabel.Text)
                    {
                        bool test = myClient.RemoveMovieFromLibrary(movie);
                        if (test)
                        {
                            MessageBox.Show("Movie removed from your library!");
                            isRemoved = true; // Markera att en film togs bort
                        }
                    }
                }
            }

            // Om något objekt togs bort, uppdatera listorna och visa de senaste ändringarna
            if (isRemoved)
            {
                // Rensa de nuvarande listbox-objekten
                moviesLibraryListBox.Items.Clear();
                seriesLibraryListBox.Items.Clear();

                // Uppdatera listorna och visa de senaste ändringarna
                ShowMediaLibrary();
            }
        }
    }
}
