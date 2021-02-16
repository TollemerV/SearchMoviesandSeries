﻿using SearchMovie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMovie
{
    public class Manager
    {
        public Api myApi = new Api();

        public Manager()
        {
            
        }

        ////////////////////////////////////////////////////
        ///////////////////GET MOVIES////////////////////////
        ////////////////////////////////////////////////////

        public List<Movies> SearchMovie(string search)
        {
            List<Movies> myMovies = myApi.GetMovies(search);

            return myMovies;
        }

        ////////////////////////////////////////////////////
        ///////////////////DETAILS MOVIES////////////////////////
        ////////////////////////////////////////////////////
        public DetailsMovies DetailsMovie(int id)
        {
            DetailsMovies myMovieDetails = myApi.GetMoviesDetails(id);

            return myMovieDetails;
        }

        ////////////////////////////////////////////////////
        ///////////////////GET SERIES////////////////////////
        ////////////////////////////////////////////////////

        public List<Series> SearchSeries(string search)
        {
            List<Series> mySeries = myApi.GetSeries(search);

            return mySeries;
        }

        ////////////////////////////////////////////////////
        ///////////////////DETAILS SERIES////////////////////////
        ////////////////////////////////////////////////////

        public DetailsSeries DetailsSeries(int id)
        {
            DetailsSeries mySerieDetails = myApi.GetSeriesDetails(id);

            return mySerieDetails;
        }

    }
}
