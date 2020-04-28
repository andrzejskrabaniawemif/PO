using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DietCalc.Classes
{
    public class Account
    {
        public string accountID { get; set; }
        public string password { get; set; }
        public DateTime dateBirth { get; set; }
        public string male { get; set; }

        public int height { get; set; }

        /// <summary>
        /// uzupelnienie danych obiektu klasu Account
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="dateBirth"></param>
        /// <param name="gender"></param>
        public Account(string login, string password, string dateBirth, int gender, int height)
        {
            this.accountID = login;
            this.password = password;
            this.dateBirth = dateBirth;
            this.male = gender;
            this.height = height;
        }

        /// <summary>
        /// dodanie nowego uztkownika
        /// </summary>
        public void CreateAccount()
        {
            if (VerifyLogin() == true)
            {
                RunSQL(string.Format("insert into Users (login, password, dateBirth, male, height) values {0}, {1}, {2}, {3}, {4}", accountID, password, dateBirth, male, height));
            }
            else
            {
                MessageBox.Show("Taki login juz istnieje", "Informacja");
            }
        }


        /// <summary>
        /// porownuje loginy podczas zakladania konta
        /// </summary>
        /// <returns></returns>
        public bool VerifyLogin()
        {
            string userLogin = GetField("login","Users", "login = " + accountID);

            if(string.IsNullOrEmpty(userLogin))
            {
                return true; // nie ma takiego loginu w tabeli
            }
            else
            {
                return false; //istnieje taki login w bazie
            }
        }

        ///metoda odpalajaca zapytanie, dodawanie uzytk. do tabeli
        ///<param name="=query"></param>
        ///

        public string RunSQL(string query)
        {
            return query;
        }

        /// <summary>
        /// sprawdza czy login istnieje w bazie i czy do danego loginu wpisane jest dobre haslo
        /// </summary>
        /// <returns> true - login i haslo prawidlowe, false lub haslo bledne</returns>
        public bool VerifyLoginandPassword()
        {
            string getPassword = GetField("password", "Users", "login = " + accountID); // wyciagniecie hasla przypisane do danego loginu

            if (string.IsNullOrEmpty(getPassword))
            {
                return false; //brak loginu w tabeli Users
            }
            else
            {
                if (getPassword == password)
                {
                    return true; // dane logowania prawidłowe
                }
                else
                {
                    return false; //haslo nieprawidlowe
                }
            }
        }

        /// <summary>
        /// wydiagnie danych z odpowiednich tabeli
        /// </summary>
        /// <param name="field"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public string GetField(string field, string table, string where)
        {
            return string.Format("SELECT '{0}' FROM '{1}' WHERE'{2}'", field, table, where); //wyciaganie danych z bazy
        }
    }
}