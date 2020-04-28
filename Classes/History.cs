using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime;

namespace DietCalc.Classes
{
    public class History
    {
        private double weight { get; set; }
        private string date { get; set; }
        private int activity { get; set }
        private double BMR { get; set; }
        private double CPM { get; set; }

        /// <summary>
        /// do daty wpisanej recznie
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="date"></param>
        /// <param name="activity"></param>
        /// <param name="user"></param>
        public History(double weight, string date, int activity, Account user)
        {
            this.weight = weight;

            this.date = date;

            this.activity = activity;

            this.BMR = CalcBMR(weight, user.height, activity);

            this.CPM = CalcCPM(weight, user.height, activity);
        }

        /// <summary>
        /// do daty dnia dzisiejszego
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="date"></param>
        /// <param name="activity"></param>
        /// <param name="user"></param>
        public History(double weight, int activity, Account user)
        {
            this.weight = weight;

            this.date = DateTime.Now.ToString("dd.MM.yyyy");

            this.activity = activity;

            this.BMR = CalcBMR(weight, user.height, activity);

            this.CPM = CalcCPM(weight, user.height, activity);
        }

        public double CalcBMR (double weight, int height, int activity)
        {
            return weight * height * activity;
        }

        public double CalcCPM(double weight, int height, int activity)
        {
            return weight * height * activity;
        }

        /// dodanie wratosci do tabeli
        public void DodajNowyRekord(string dataManual, Account user)
        {
            string data;


            //odwolanie insterta do tabeli historiauzytkownika
            //string query......
        }
    }
}