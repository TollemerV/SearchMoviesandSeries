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

        public Movies[] SearchMovie(string search)
        {
            Movies[] myMovie = myApi.GetMovie(search);

            return myMovie;
        }



        public DetailsMovies DetailsMovie(int id)
        {
            DetailsMovies myMovie = myApi.GetMovieDetails(id);

            return myMovie;
        }
    }
}
