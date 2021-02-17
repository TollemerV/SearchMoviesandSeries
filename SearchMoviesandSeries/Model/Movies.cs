using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SearchMovie.Model
{
    public class Movies
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

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
                   "\n Title : " + Title + 
                   "\n Type : " + _myType;
        }
    }
}