using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SearchMovie.Model
{
    public class DetailsSeries
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        private string _myType = "Series";
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

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        public override string ToString()
        {
            return "\n Id :" + Id +
                   "\n Title : " + Name + 
                   "\n Type : " + Type +
                   "\n Overview : " + Overview + 
                   "\n Average : " + VoteAverage +" / 10" +
                   "\n Number of votes : " + VoteCount;
        }
    }
}
