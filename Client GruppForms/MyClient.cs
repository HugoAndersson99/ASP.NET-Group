using Client_GruppForms.Objects;
using Newtonsoft.Json;
using System.Text;

namespace Client_GruppForms
{
    public class MyClient
    {
        public List<Serie> GetAllSeries()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage =
                client.GetAsync("https://localhost:7196/api/serie/all").Result;

            string json = responseMessage.Content.ReadAsStringAsync().Result;

            List<Serie> series = JsonConvert.DeserializeObject<List<Serie>>(json);

            return series;
        }
        public List<MediaUser> GetAllUsers()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage =
                client.GetAsync("https://localhost:7196/api/mediauser/all").Result;

            string json = responseMessage.Content.ReadAsStringAsync().Result;

            List<MediaUser> users = JsonConvert.DeserializeObject<List<MediaUser>>(json);

            return users;
        }
        public void AddNewMediaUser(MediaUser user)
        {
            string json = JsonConvert.SerializeObject(user);

            string url = "https://localhost:7196/api/mediauser/add";

            HttpClient client = new HttpClient();

            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(url, content).Result;
        }

        public List<Movie> GetAllMovies()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage =
                client.GetAsync("https://localhost:7196/api/movie/all").Result;

            string json = responseMessage.Content.ReadAsStringAsync().Result;

            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(json);

            return movies;
        }

        public void GetMovieByID(int id)
        {
            string url = "https://localhost:7196/api/movie/byid?id=" + id;
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.GetAsync(url).Result;

        }

        public void GetSerieByID(int id)
        {
            string url = "https://localhost:7196/api/serie/byid?id=" + id;
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.GetAsync(url).Result;

        }
        public void DeleteMovieByID(int id)
        {
            string url = "https://localhost:7196/api/movie/delete?id=" + id;
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.DeleteAsync(url).Result;
        }

        public void DeleteSerieByID(int id)
        {
            string url = "https://localhost:7196/api/serie/delete?id=" + id;
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.DeleteAsync(url).Result;
        }

        public void AddMovie(Movie movie)
        {
            string json = JsonConvert.SerializeObject(movie);

            string url = "https://localhost:7196/api/movie/add";

            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
        }

        public void AddSerie(Serie serie)
        {
            string json = JsonConvert.SerializeObject(serie);

            string url = "https://localhost:7196/api/serie/add";

            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
        }

        public void EditMovie(Movie movie)
        {
            string json = JsonConvert.SerializeObject(movie);

            string url = "https://localhost:7196/api/movie/edit";

            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url, content).Result;

        }

        public void EditSerie(Serie serie)
        {
            string json = JsonConvert.SerializeObject(serie);

            string url = "https://localhost:7196/api/serie/edit";

            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url, content).Result;

        }
        public void SetUser(MediaUser mediaUser)
        {
            string url = "https://localhost:7196/api/mediauser/user";
            string json = JsonConvert.SerializeObject(mediaUser);
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;

        }
        public void Test(MediaUser mediaUser)
        {

        }
        public bool AddMovieToLibrary(Movie movie)
        {
            try
            {
                string url = "https://localhost:7196/api/mediauser/addMovieToLibrary";
                string json = JsonConvert.SerializeObject(movie);
                HttpClient client = new HttpClient();
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                //var requestContent = new StringContent(JsonConvert.SerializeObject(new { Movie = movie, MediaUser = mediaUser }), System.Text.Encoding.UTF8, "application/json");
                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    // Handle unsuccessful response
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("Exception: " + ex.Message);
                return false;
            }

            // string url = "https://localhost:7196/api/mediauser/addMovieToLibrary";
            // var content = new StringContent(JsonConvert.SerializeObject(new { movie, mediaUser }), Encoding.UTF8, "application/json");
            //
            // HttpClient client = new HttpClient();
            //
            // client.PostAsync(url, content);
        }

        public bool AddSerieToLibrary(Serie serie)
        {
            try
            {
                string url = "https://localhost:7196/api/mediauser/addSerieToLibrary";
                string json = JsonConvert.SerializeObject(serie);
                HttpClient client = new HttpClient();
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                //var requestContent = new StringContent(JsonConvert.SerializeObject(new { Movie = movie, MediaUser = mediaUser }), System.Text.Encoding.UTF8, "application/json");
                var response = client.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    // Handle unsuccessful response
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("Exception: " + ex.Message);
                return false;
            }
        }

        public List<Movie> GetUserMovies(MediaUser mediaUser)
        {
            try
            {
                string url = $"https://localhost:7196/api/mediauser/user/{mediaUser.Id}/movies";
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    List<Movie> userMovies = JsonConvert.DeserializeObject<List<Movie>>(json);
                    return userMovies;
                }
                else
                {
                    // Hantera felaktigt svar
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Hantera exception
                MessageBox.Show("Exception: " + ex.Message);
                return null;
            }
        }

        public List<Serie> GetUserSeries(MediaUser mediaUser)
        {
            try
            {
                string url = $"https://localhost:7196/api/mediauser/user/{mediaUser.Id}/series";
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    List<Serie> userSeries = JsonConvert.DeserializeObject<List<Serie>>(json);
                    return userSeries;
                }
                else
                {
                    // Hantera felaktigt svar
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Hantera exception
                MessageBox.Show("Exception: " + ex.Message);
                return null;
            }
        }
    }
}
