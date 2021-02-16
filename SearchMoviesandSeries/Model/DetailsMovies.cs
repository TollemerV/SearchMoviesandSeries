using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SearchMovie.Model
{
    public class DetailsMovies
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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

        [JsonProperty("overwiew")]
        public string Overview { get; set; }

        [JsonProperty("vote_average")]
        public int VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        public DetailsMovies()
        {

        }

        public override string ToString()
        {
            return "\n Id :" + Id +
                   "\n Type : " + Type + "" +
                   "\n Title : " + Name +
                   "\n Overview : " + Overview + "" +
                   "\n Average : " + VoteAverage +
                   "\n Number of votes : " + VoteCount;
        }
    }
}
