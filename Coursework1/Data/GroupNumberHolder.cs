using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1.Data
{
    class GroupNumberHolder
    {
        public int below_three { get; set; }
        public int three_to_sixteen { get; set; }
        public int sixteen_to_sixty { get; set; }
        public int above_sixty { get; set; }
        public GroupNumberHolder() {
            resetData();
        }

        public void resetData() {
            this.below_three = 0;
            this.three_to_sixteen = 0;
            this.sixteen_to_sixty = 0;
            this.above_sixty = 0;
        }

    }
}
