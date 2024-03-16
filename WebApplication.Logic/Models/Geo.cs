using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Miha.Models
{
    public class Geo
    {
        [JsonPropertyName("lat")]
        public string Longitude { get; set; }
        [JsonPropertyName("lng")]
        public double Latitude { get; set; }
    }
}
