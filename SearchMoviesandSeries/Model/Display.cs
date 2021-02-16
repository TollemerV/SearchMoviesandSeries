using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMovie.Model
{
    public class DisplayMovies
    {
        [JsonProperty("results")]
        public List<Movies> displayMovie { get; set; }

        public DisplayMovies()
        {
        }
    }

    public class DisplaySeries
    {
        [JsonProperty("results")]
        public List<Series> displaySerie { get; set; }

        public DisplaySeries()
        {
        }
    }
}
