using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietCalc.Classes
{
    public class Analysis
    {
        public int target { get; set; }
        public int targetWeight { get; set; }
        public double caloriesChange { get; set; }
        public double weightChange { get; set; }

        public double CalcProtein(double weight, int activity, int target)
        {
            return weight * activity * target;
        }

        public double CalcFat(double weight, int activity, int target)
        {
            return weight * activity * target;
        }

        public double CalcCarbo(double weight, int activity, int target)
        {
            return weight * activity * target;
        }
    }
}