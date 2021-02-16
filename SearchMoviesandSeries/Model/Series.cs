using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SearchMovie.Model
{
    public class Series
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Title { get; set; }

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

        public Series()
        {

        }

        public override string ToString()
        {
            return "\n Id :" + Id +
                   "\n Type : " + Type + "" +
                   "\n Title : " + Title;
        }
    }
}
