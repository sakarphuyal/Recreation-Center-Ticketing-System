using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1.Data
{
    class Ticket : IComparable<Ticket>
    {
        public int ticketId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public  DateTime in_time { get; set; }
        public int childCount { get; set; }
        public int normalCount { get; set; }
        public int oldCount { get; set; }
        public int total_cost { get; set; }
        public DateTime check_out { get; set; }

        public int CompareTo(Ticket other)
        {
            return ticketId - other.ticketId;
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
