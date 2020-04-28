using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietCalc.Classes
{
    public class Macronutritions
    {
        public double protein { get; set; }
        public double fat { get; set; }
        public double carbo { get; set; }

        public Macronutritions(double protein, double fat, double carbo)
        {
            this.protein = protein;
            this.fat = fat;
            this.carbo = carbo;
        }
    }

    
}