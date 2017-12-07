using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaneKolekcje
{
    class Country
    {
        public string NAME;
        [JsonProperty("area")]
        public long? Population;
        [JsonProperty("population")]
        public long? Area;
        //public List<Curency> Money;
    }
}
