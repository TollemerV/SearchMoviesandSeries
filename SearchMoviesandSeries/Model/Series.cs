using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SearchMoviesandSeries.Model;

namespace SearchMovie.Model
{
    public class Series : Media
    {
        [JsonProperty("name")]
        public string Title { get; set; }

        private string _myType = "Serie";
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
                   "\n Title : " + Title + "" +
                   "\n Type : " + Type;
        }
    }
}
