using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1.Data
{
    class Ticket
    {
        public string id { get; set; }
        public string name { get; set; }

        public string age_group { get; set; }
        public DateTime date { get; set; }
        public  DateTime in_time { get; set; }
        public string is_group { get; set; }
        public int number_of_people { get; set; }

        public double  total_cost { get; set; }


        public string toJson() {
            return JsonConvert.SerializeObject(this);
        }
        public override string ToString()
        {
            return this.toJson();
        }
    }
}
