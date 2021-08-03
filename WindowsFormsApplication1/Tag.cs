using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tag
    {
        [JsonProperty("id")]
        public int id
        { get; set; }

        [JsonProperty("epc")]
        public string epc
        { get; set; }

        [JsonProperty("datetime")]
        public string datetime
        { get; set; }

        [JsonProperty("uid")]
        public string uid
        { get; set; }

        [JsonProperty("bib_no")]
        public Boolean bib_no
        { get; set; }
    }
}
