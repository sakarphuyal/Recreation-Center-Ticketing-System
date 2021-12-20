using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1.Data
{
    class TicketPriceForWeekDays
    {
        public int week_individual_less_than_three_one_hour { get; set; }//1,1
        public int week_individual_three_to_sixteen_one_hour { get; set; }//1,2
        public int week_individual_sixteen_to_sixty_one_hour { get; set; }//1,3
        public int week_individual_sixty_plus_one_hour { get; set; }//1,4
        public int week_individual_less_than_three_two_hour { get; set; }//2,1
        public int week_individual_three_to_sixteen_two_hour { get; set; }//2,2
        public int week_individual_sixteen_to_sixty_two_hour { get; set; }//2,3
        public int week_individual_sixty_plus_two_hour { get; set; }//2,4
        public int week_individual_less_than_three_three_hour { get; set; }//3,1
        public int week_individual_three_to_sixteen_three_hour { get; set; }//3,2
        public int week_individual_sixteen_to_sixty_three_hour { get; set; }//3,3
        public int week_individual_sixty_plus_three_hour { get; set; }//3,4
        public int week_individual_less_than_three_four_hour { get; set; }//4,1
        public int week_individual_three_to_sixteen_four_hour { get; set; }//4,1
        public int week_individual_sixteen_to_sixty_four_hour { get; set; }//4,3
        public int week_individual_sixty_plus_four_hour { get; set; }//4,4
        public int week_individual_less_than_three_whole_day { get; set; }//5,1
        public int week_individual_three_to_sixteen_whole_day { get; set; }//5,2
        public int week_individual_sixteen_to_sixty_whole_day { get; set; }//5,3
        public int week_individual_sixty_plus_whole_day { get; set; }//5,4
        public int week_group_two_to_five_one_hour { get; set; }//6,1
        public int week_group_five_to_ten_one_hour { get; set; }//6,2
        public int week_group_ten_to_fifteen_one_hour { get; set; }//6,3
        public int week_group_fifteen_plus_one_hour { get; set; }//6,4
        public int week_group_two_to_five_two_hour { get; set; }//7,1
        public int week_group_five_to_ten_two_hour { get; set; }//7,2
        public int week_group_ten_to_fifteen_two_hour { get; set; }//7,3
        public int week_group_fifteen_above_two_hour { get; set; }//7,4
        public int week_group_two_to_five_three_hour { get; set; }//8,1
        public int week_group_five_to_ten_three_hour { get; set; }//8,2
        public int week_group_ten_to_fifteen_three_hour { get; set; }//8,3
        public int week_group_fifteen_plus_three_hour { get; set; }//8,4
        public int week_group_two_to_five_four_hour { get; set; }//9,1
        public int week_group_five_to_ten_four_hour { get; set; }//9,2
        public int week_group_ten_to_fifteen_four_hour { get; set; }//9,3
        public int week_group_fifteen_plus_four_hour { get; set; }//9,4
        public int week_group_two_to_five_whole_day { get; set; }//10,1
        public int week_group_five_to_ten_whole_day { get; set; }//10,2
        public int week_group_ten_to_fifteen_whole_day { get; set; }//10,3
        public int week_group_fifteen_plus_whole_day { get; set; }//10,4
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
