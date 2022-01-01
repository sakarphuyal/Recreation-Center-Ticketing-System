using Newtonsoft.Json;

namespace Coursework1.Data
{
    class TicketPrice
    {
        public int oneHourPrice { get; set; }//1,1
        public int twoHourPrice { get; set; }//2,1
        public int threeHourPrice { get; set; }//3,1
        public int fourHourPrice { get; set; }//4,1
        public int wholeDayPrice { get; set; }//5,1

        public int groupFiveDiscount { get; set; }//6,1
        public int groupTenDiscount { get; set; }//6,2
        public int groupFifteenDiscount { get; set; }//6,3
        public int groupMaxDiscount { get; set; }//6,4

        public int holidayDiscount { get; set; }
        public int childDiscount { get; set; }
        public int oldDiscount { get; set; }
        public int weekendDiscount { get; set; }
        
        public string toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        public override string ToString()
        {
            return this.toJson();
        }
    }
}
