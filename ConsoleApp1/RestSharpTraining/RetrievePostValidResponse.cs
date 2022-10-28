using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTraining
{
    class RetrievePostValidResponse
    {
        [JsonProperty("id")]
        public int Inte { get; set; }

        public string? title { get; set; }


        public string? author { get; set; }
    }
}
