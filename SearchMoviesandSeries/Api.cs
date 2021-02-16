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

        ////////////////////////////////////////////////////
        ///////////////////GET MOVIES////////////////////////
        ////////////////////////////////////////////////////

        public List<Movies> GetMovie(string search)
        {
            var client = new RestClient(path + "search/movie?" + api + "&language=en-US&query" + search);

            var request = new RestRequest();

            var response = client.Get(request);

            var moviesReturn = JsonConvert.DeserializeObject<DisplayMovies>(response.Content);

            if (moviesReturn is null)
            {
                throw new FailureConnectionException();
            }
            else if (moviesReturn.displayMovie.Count == 0)
            {
                throw new EmptyDataException();
            }

            return moviesReturn.displayMovie;
        }


        ////////////////////////////////////////////////////
        ///////////////////DETAILS MOVIES////////////////////////
        ////////////////////////////////////////////////////

        public DetailsMovies GetMoviesDetails(int id)
        {
            var client = new RestClient(path + "movie/" + id + "?" + api + "&language=en-US&query");

            var request = new RestRequest();

            var response = client.Get(request);


            var detailsReturn = JsonConvert.DeserializeObject<DetailsMovies>(response.Content);
            
            if (detailsReturn == null)
            {
                throw new FailureConnectionException();
            }
            return detailsReturn;

        }



        ////////////////////////////////////////////////////
        ///////////////////GET SERIES////////////////////////
        ////////////////////////////////////////////////////

        public List<Series> GetSeries(string search)
        {
            var client = new RestClient(path + "search/tv?" + api + "&language=en-US&query" + search);

            var request = new RestRequest();

            var response = client.Get(request);

            var seriesReturn = JsonConvert.DeserializeObject<DisplaySeries>(response.Content);

            if (seriesReturn is null)
            {
                throw new FailureConnectionException();
            }
            else if (seriesReturn.displaySerie.Count == 0)
            {
                throw new EmptyDataException();
            }

            return seriesReturn.displaySerie;
        }


        ////////////////////////////////////////////////////
        ///////////////////DETAILS SERIES////////////////////////
        ////////////////////////////////////////////////////
        ///
        public DetailsSeries GetSeriesDetails(int id)
        {
            var client = new RestClient(path + "tv/" + id + "?" + api + "&language=en-US&query");

            var request = new RestRequest();

            var response = client.Get(request);


            var detailsReturn = JsonConvert.DeserializeObject<DetailsSeries>(response.Content);

            if (detailsReturn == null)
            {
                throw new FailureConnectionException();
            }
            return detailsReturn;

        }
    }
}
