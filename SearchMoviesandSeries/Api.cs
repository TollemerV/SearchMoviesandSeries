using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SearchMovie.Model;
using RestSharp;

namespace SearchMovie
{
    public class Api
    {

        private const string api = "api_key=91d9592dccb04c5a93f6b63b25d08270";
        private const string path = "https://api.themoviedb.org/3/";
        // Search movie : movie/550? or movie/popular


        public Api()
        {

        }

        public Movies[] GetMovie(string search)
        {
            var client = new RestClient(path + "search/movie?" + api + "&language=en-US&query" + search);

            var request = new RestRequest();

            var response = client.Get(request);

            Movies[] moviesReturn = JsonConvert.DeserializeObject<Movies[]>(response.Content);


            return moviesReturn;
        }

        public DetailsMovies GetMovieDetails(int id)
        {
            var client = new RestClient(path + "/movie/" + id + "?" + api + "&language=en-US&query");

            var request = new RestRequest();

            var response = client.Get(request);


            var detailsReturn = JsonConvert.DeserializeObject<DetailsMovies>(response.Content);
            return detailsReturn;

        }
    }
}
