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

namespace Client_GruppForms
{
    public partial class AdminPage : Form
    {
        MyClient myClient = new MyClient();
        LoginPage loginPage;
        List<Movie> movieList;
        List<MediaUser> mediaUserList;
        List<Serie> serieList;

        public AdminPage(LoginPage loginPage)
        {
            InitializeComponent();
            this.loginPage = loginPage;
            GetMedia();
        }
        private void GetMedia()
        {
            movieList = myClient.GetAllMovies();
            mediaUserList = myClient.GetAllUsers();
            serieList = myClient.GetAllSeries();

            foreach (Movie movie in movieList)
            {
                editMoviesListBox.Items.Add(movie.Title);
            }
            foreach (MediaUser mediaUser in mediaUserList)
            {
                editUserListBox.Items.Add(mediaUser.Email);
            }
            foreach (Serie serie in serieList)
            {
                editSeriesListBox.Items.Add(serie.Title);
            }
        }

        private void editMoviesButton_Click(object sender, EventArgs e)
        {
            PanelVisable();
            editMoviesPanel.Visible = true;
        }

        private void editSeriesButton_Click(object sender, EventArgs e)
        {
            PanelVisable();
            editSeriesPanel.Visible = true;

        }

        private void editUsersButton_Click(object sender, EventArgs e)
        {
            PanelVisable();
            editUsersPanel.Visible = true;
        }

        private void PanelVisable()
        {
            editSeriesPanel.Visible = false;
            editUsersPanel.Visible = false;
            editMoviesPanel.Visible = false;
        }

        private void editSelectedMovieButton_Click(object sender, EventArgs e)
        {
            if (editMoviesListBox.SelectedItem == null)
            {
                MessageBox.Show("You must choose a Movie");
                return;
            }
            string choosenMovie = editMoviesListBox.SelectedItem.ToString();
            Movie movie = null;
            foreach (Movie movies in movieList)
            {
                if (movies.Title == choosenMovie)
                {
                    movie = movies;
                }
            }
            if (movie != null)
            {
                movieTitleTextBox.Text = movie.Title;
                movieDescrTextBox.Text = movie.Description;
                movieGenreTextBox.Text = movie.Genre;
                movieRelYearTextBox.Text = movie.ReleaseYear.ToString();
                movieLengthTextBox.Text = movie.LengthMin.ToString();
            }
        }

        private void editSelectedSerieButton_Click(object sender, EventArgs e)
        {
            if (editSeriesListBox.SelectedItem == null)
            {
                MessageBox.Show("You must choose a Serie");
                return;
            }
            string choosenSerie = editSeriesListBox.SelectedItem.ToString();
            Serie serieCopy = null;
            foreach (Serie serie in serieList)
            {
                if (serie.Title == choosenSerie)
                {
                    serieCopy = serie;
                }
            }
            if (serieCopy != null)
            {
                serieTitleTextbox.Text = serieCopy.Title;
                serieDescrTextBox.Text = serieCopy.Description;
                serieRelYearTextBox.Text = serieCopy.ReleaseYear.ToString();
                seireEpisodesTextBox.Text = serieCopy.Episodes.ToString();
                seasonsTextBox.Text = serieCopy.Seasons.ToString();
            }
        }

        private void editSelectedUser_Click(object sender, EventArgs e)
        {
            if (editUserListBox.SelectedItem == null)
            {
                MessageBox.Show("You must choose a User");
                return;
            }
            string choosenUser = editUserListBox.SelectedItem.ToString();
            MediaUser mediaUserCopy = null;
            foreach (MediaUser mediaUser in mediaUserList)
            {
                if (choosenUser == mediaUser.Email)
                {
                    mediaUserCopy = mediaUser;
                }
            }
            if (mediaUserCopy != null)
            {
                userEmailTextBox.Text = mediaUserCopy.Email;
                userFirstNameTextBox.Text = mediaUserCopy.FirstName;
                userLastNameTextBox.Text = mediaUserCopy.LastName;
                userPasswordTextBox.Text = mediaUserCopy.Password;
            }
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            if (userEmailTextBox.Text == null)
            {
                MessageBox.Show("You much choose a user!");
                return;
            }
            //MediaUser userCopy = null;
            foreach (MediaUser mediaUser in mediaUserList)
            {
                if (userEmailTextBox.Text == mediaUser.Email)
                {
                    myClient.DeleteUserByID(mediaUser.Id);
                    MessageBox.Show("Deleted User");
                    RefreshUsers();
                    return;

                }
            }
        }
        private void RefreshUsers()
        {
            mediaUserList.Clear();
            mediaUserList = myClient.GetAllUsers();
            editUserListBox.Items.Clear();
            userEmailTextBox.Clear();
            userFirstNameTextBox.Clear();
            userLastNameTextBox.Clear();
            userPasswordTextBox.Clear();
            foreach (MediaUser mediaUser in mediaUserList)
            {
                editUserListBox.Items.Add(mediaUser.Email);
            }
        }

        private void removeSerieButton_Click(object sender, EventArgs e)
        {
            if (serieTitleTextbox.Text == null)
            {
                MessageBox.Show("You much choose a Serie!");
                return;
            }
            foreach (Serie serie in serieList)
            {
                if (serieTitleTextbox.Text == serie.Title)
                {
                    myClient.DeleteSerieByID(serie.SerieId);
                    MessageBox.Show("Deleted Serie");
                    RefreshSeries();
                    return;
                }
            }
        }
        private void RefreshSeries()
        {
            serieList.Clear();
            serieList = myClient.GetAllSeries();
            editSeriesListBox.Items.Clear();
            serieDescrTextBox.Clear();
            serieRelYearTextBox.Clear();
            serieTitleTextbox.Clear();
            seireEpisodesTextBox.Clear();
            seasonsTextBox.Clear();
            foreach (Serie serie in serieList)
            {
                editSeriesListBox.Items.Add(serie.Title);
            }
        }
        private void RefreshMovies()
        {
            movieList.Clear();
            movieList = myClient.GetAllMovies();
            editMoviesListBox.Items.Clear();
            movieDescrTextBox.Clear();
            movieGenreTextBox.Clear();
            movieLengthTextBox.Clear();
            movieRelYearTextBox.Clear();
            movieTitleTextBox.Clear();
            foreach (Movie movie in movieList)
            {
                editMoviesListBox.Items.Add(movie.Title);
            }

        }

        private void removeMovieButton_Click(object sender, EventArgs e)
        {
            if (movieTitleTextBox.Text == null)
            {
                MessageBox.Show("You much choose a Movie!");
                return;
            }
            foreach (Movie movie in movieList)
            {
                if (movieTitleTextBox.Text == movie.Title)
                {
                    myClient.DeleteMovieByID(movie.MovieId);
                    MessageBox.Show("Deleted Movie");
                    RefreshMovies();
                    return;
                }
            }
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            if (movieRelYearTextBox.Text == null)
            {
                MessageBox.Show("You must enter a Realease Year!");
                return;
            }
            if (movieTitleTextBox.Text == null)
            {
                MessageBox.Show("You must enter a title!");
                return;
            }
            if (movieGenreTextBox.Text == null)
            {
                MessageBox.Show("You must enter a Genre!");
                return;
            }
            if (movieDescrTextBox.Text == null)
            {
                MessageBox.Show("You must enter a Description!");
                return;
            }
            if (movieLengthTextBox.Text == null)
            {
                MessageBox.Show("You must enter a length in minutes!");
                return;
            }
            foreach (Movie movie in movieList)
            {
                if (movieTitleTextBox.Text == movie.Title)
                {
                    MessageBox.Show("There is already a movie with that title!");
                    return;
                }
            }
            int relYear = Convert.ToInt32(movieRelYearTextBox.Text);
            int length = Convert.ToInt32(movieLengthTextBox.Text);
            Movie newMovie = new Movie(movieTitleTextBox.Text, movieGenreTextBox.Text, movieDescrTextBox.Text, relYear, length);
            myClient.AddMovie(newMovie);
            RefreshMovies();
            MessageBox.Show("DONE!");

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (userEmailTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Email!");
                return;
            }
            if (userFirstNameTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an First Name!");
                return;
            }
            if (userLastNameTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Last Name!");
                return;
            }
            if (userPasswordTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Password!");
                return;
            }
            foreach (MediaUser mediaUser in mediaUserList)
            {
                if (userEmailTextBox.Text == mediaUser.Email)
                {
                    MessageBox.Show("There is already an user with that email!");
                    return;
                }
            }
            MediaUser newUser = new MediaUser(userEmailTextBox.Text, userPasswordTextBox.Text, userFirstNameTextBox.Text, userLastNameTextBox.Text);
            myClient.AddNewMediaUser(newUser);
            RefreshUsers();
            MessageBox.Show("DONE!");
        }

        private void addSerieButton_Click(object sender, EventArgs e)
        {
            if (serieDescrTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Description!");
                return;
            }
            if (serieTitleTextbox.Text == null)
            {
                MessageBox.Show("You Must Enter an Title!");
                return;
            }
            if (seasonsTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter How Many Seasons!");
                return;
            }
            if (seireEpisodesTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter How Many Episodes!");
                return;
            }
            if (serieRelYearTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Release Year!");
                return;
            }
            foreach (Serie serie in serieList)
            {
                if (serieTitleTextbox.Text == serie.Title)
                {
                    MessageBox.Show("There already is a Serie with that title!");
                    return;
                }
            }
            int episodes = Convert.ToInt32(seireEpisodesTextBox.Text);
            int relYear = Convert.ToInt32(serieRelYearTextBox.Text);
            int seasons = Convert.ToInt32(seasonsTextBox.Text);
            Serie newSerie = new Serie(serieTitleTextbox.Text, serieDescrTextBox.Text, relYear, episodes, seasons);
            myClient.AddSerie(newSerie);
            RefreshSeries();
            MessageBox.Show("DONE!");
        }

        private void editSerieButton_Click(object sender, EventArgs e)
        {
            if (serieDescrTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Description!");
                return;
            }
            if (serieTitleTextbox.Text == null)
            {
                MessageBox.Show("You Must Enter an Title!");
                return;
            }
            if (seasonsTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter How Many Seasons!");
                return;
            }
            if (seireEpisodesTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter How Many Episodes!");
                return;
            }
            if (serieRelYearTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Release Year!");
                return;
            }
            if (editSeriesListBox.SelectedItem.ToString() != serieTitleTextbox.Text)
            {
                foreach (Serie serie in serieList)
                {
                    if (serieTitleTextbox.Text == serie.Title)
                    {
                        MessageBox.Show("There already is a Serie with that title!");
                        return;
                    }
                }
            }
            Serie choosenSerie = null;
            foreach (Serie serie in serieList)
            {
                if (editSeriesListBox.SelectedItem.ToString() == serie.Title)
                {
                    choosenSerie = serie;
                }
            }

            int episodes = Convert.ToInt32(seireEpisodesTextBox.Text);
            int relYear = Convert.ToInt32(serieRelYearTextBox.Text);
            int seasons = Convert.ToInt32(seasonsTextBox.Text);
            choosenSerie.Title = serieTitleTextbox.Text;
            choosenSerie.Description = serieDescrTextBox.Text;
            choosenSerie.Episodes = episodes;
            choosenSerie.ReleaseYear = relYear;
            choosenSerie.Seasons = seasons;
            //Serie newSerie = new Serie(serieTitleTextbox.Text, serieDescrTextBox.Text, relYear, episodes, seasons);
            myClient.EditSerie(choosenSerie);
            RefreshSeries();
            MessageBox.Show("DONE!");
        }

        private void editMovieButton_Click(object sender, EventArgs e)
        {
            if (movieRelYearTextBox.Text == null)
            {
                MessageBox.Show("You must enter a Realease Year!");
                return;
            }
            if (movieTitleTextBox.Text == null)
            {
                MessageBox.Show("You must enter a title!");
                return;
            }
            if (movieGenreTextBox.Text == null)
            {
                MessageBox.Show("You must enter a Genre!");
                return;
            }
            if (movieDescrTextBox.Text == null)
            {
                MessageBox.Show("You must enter a Description!");
                return;
            }
            if (movieLengthTextBox.Text == null)
            {
                MessageBox.Show("You must enter a length in minutes!");
                return;
            }
            if (editMoviesListBox.SelectedItem.ToString() != movieTitleTextBox.Text)
            {
                foreach (Movie movie in movieList)
                {
                    if (movieTitleTextBox.Text == movie.Title)
                    {
                        MessageBox.Show("There is already a movie with that title!");
                        return;
                    }
                }
            }
            Movie choosenMovie = null;
            foreach (Movie movie in movieList)
            {
                if (editMoviesListBox.SelectedItem.ToString() == movie.Title)
                {
                    choosenMovie = movie;
                }
            }
            int relYear = Convert.ToInt32(movieRelYearTextBox.Text);
            int length = Convert.ToInt32(movieLengthTextBox.Text);

            choosenMovie.Title = movieTitleTextBox.Text;
            choosenMovie.Description = movieDescrTextBox.Text;
            choosenMovie.Genre = movieGenreTextBox.Text;
            choosenMovie.LengthMin = length;
            choosenMovie.ReleaseYear = relYear;


            //Movie newMovie = new Movie(movieTitleTextBox.Text, movieGenreTextBox.Text, movieDescrTextBox.Text, relYear, length);
            myClient.EditMovie(choosenMovie);
            RefreshMovies();
            MessageBox.Show("DONE!");
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (userEmailTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Email!");
                return;
            }
            if (userFirstNameTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an First Name!");
                return;
            }
            if (userLastNameTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Last Name!");
                return;
            }
            if (userPasswordTextBox.Text == null)
            {
                MessageBox.Show("You Must Enter an Password!");
                return;
            }
            if (editUserListBox.SelectedItem.ToString() != userEmailTextBox.Text)
            {
                foreach (MediaUser mediaUser in mediaUserList)
                {
                    if (userEmailTextBox.Text == mediaUser.Email)
                    {
                        MessageBox.Show("There is already an user with that email!");
                        return;
                    }
                }
            }
            MediaUser choosenUser = null;
            foreach (MediaUser mediaUser in mediaUserList)
            {
                if (editUserListBox.SelectedItem.ToString() == mediaUser.Email)
                {
                    choosenUser = mediaUser;
                }
            }
            choosenUser.FirstName = userFirstNameTextBox.Text;
            choosenUser.LastName = userLastNameTextBox.Text;
            choosenUser.Email = userEmailTextBox.Text;
            choosenUser.Password = userPasswordTextBox.Text;
            //MediaUser newUser = new MediaUser(userEmailTextBox.Text, userPasswordTextBox.Text, userFirstNameTextBox.Text, userLastNameTextBox.Text);
            myClient.EditUser(choosenUser);
            RefreshUsers();
            MessageBox.Show("DONE!");
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPage.Show();
        }
    }
}
