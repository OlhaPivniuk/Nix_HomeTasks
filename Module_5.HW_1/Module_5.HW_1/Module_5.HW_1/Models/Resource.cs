using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5.HW_1.Models
{
    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        [JsonProperty("pantone_value")]
        public string PantoneValue { get; set; }
    }
}
