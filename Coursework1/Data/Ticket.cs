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
        public int ticket_auto_incresed_id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public  DateTime in_time { get; set; }
        public int below_three { get; set; }
        public int three_to_sixteen { get; set; }
        public int sixteen_to_sixty { get; set; }
        public int above_sixty { get; set; }
        public int age_group { get; set; }
        public int total_cost { get; set; }
        public bool is_group { get; set; }
        public bool isGroup() {
            return this.below_three + this.three_to_sixteen + this.sixteen_to_sixty + this.above_sixty > 1;
        }


        public string toJson() {
            return JsonConvert.SerializeObject(this);
        }
        public override string ToString()
        {
            return this.toJson();
        }
    }
}
