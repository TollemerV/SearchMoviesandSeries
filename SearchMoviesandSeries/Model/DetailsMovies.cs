using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SearchMoviesandSeries.Model;

namespace SearchMovie.Model
{
    public class DetailsMovies : DetailsMedia
    {
        [JsonProperty("title")]
        public string Name { get; set; }

        private string _myType = "Movies";
        public string Type
        {
            get
            {
                return _myType;
            }
            set
            {
                _myType = value;
            }
        }

        public override string ToString()
        {
            return "\n Id :" + Id +
                   "\n Title : " + Name + "" +
                   "\n Type : " + Type +
                   "\n Overview : " + Overview + "" +
                   "\n Average : " + VoteAverage + " / 10" +
                   "\n Number of votes : " + VoteCount;
        }
    }
}
