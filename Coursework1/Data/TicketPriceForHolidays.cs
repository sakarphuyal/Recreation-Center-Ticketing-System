using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1.Data
{
    class TicketPriceForHolidays
    {
        public int holiday_individual_less_than_three_one_hour { get; set; }//1,1
        public int holiday_individual_three_to_sixteen_one_hour { get; set; }//1,2
        public int holiday_individual_sixteen_to_sixty_one_hour { get; set; }//1,3
        public int holiday_individual_sixty_plus_one_hour { get; set; }//1,4
        public int holiday_individual_less_than_three_two_hour { get; set; }//2,1
        public int holiday_individual_three_to_sixteen_two_hour { get; set; }//2,2
        public int holiday_individual_sixteen_to_sixty_two_hour { get; set; }//2,3
        public int holiday_individual_sixty_plus_two_hour { get; set; }//2,4
        public int holiday_individual_less_than_three_three_hour { get; set; }//3,1
        public int holiday_individual_three_to_sixteen_three_hour { get; set; }//3,2
        public int holiday_individual_sixteen_to_sixty_three_hour { get; set; }//3,3
        public int holiday_individual_sixty_plus_three_hour { get; set; }//3,4
        public int holiday_individual_less_than_three_four_hour { get; set; }//4,1
        public int holiday_individual_three_to_sixteen_four_hour { get; set; }//4,2
        public int holiday_individual_sixteen_to_sixty_four_hour { get; set; }//4,3
        public int holiday_individual_sixty_plus_four_hour { get; set; }//4,4
        public int holiday_individual_less_than_three_whole_day { get; set; }//5,1
        public int holiday_individual_three_to_sixteen_whole_day { get; set; }//5,2
        public int holiday_individual_sixteen_to_sixty_whole_day { get; set; }//5,3
        public int holiday_individual_sixty_plus_whole_day { get; set; }//5,4
        public int holiday_group_two_to_five_Discount { get; set; }//6,1
        public int holiday_group_five_to_ten_Discount { get; set; }//6,2
        public int holiday_group_ten_to_fifteen_Discount { get; set; }//6,3
        public int holiday_group_fifteen_plus_Discount { get; set; }//6,4
       

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
