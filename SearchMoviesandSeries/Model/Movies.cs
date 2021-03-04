using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SearchMoviesandSeries.Model;

namespace SearchMovie.Model
{
    public class Movies : Media
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        private string _myType = "Movie";
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
                   "\n Title : " + Title + 
                   "\n Type : " + Type;
        }
    }
}