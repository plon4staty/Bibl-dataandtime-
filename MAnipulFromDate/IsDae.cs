using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MAnipulFromDate
{
    public class IsDae
    {

        private string[] Month = new string[] {  "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь"  };
        private int[] DayM = new int[] {  31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31  };
        int DayIn;
        int j = 0;
        string Type;

        /// <summary>
        /// Разница мжду двумя датами
        /// </summary>
        public int DateWithDae (string Day_1, string Day_2) 
        {
            //Перебрание массива
            for (int i = 0; i < Month.Length; i++)
            {
                
                
                    
                    //Привсаивани данных из массива
                    if (Month[i] == Day_1)
                    {

                    DayIn = DayM[j];

                    }
                    if (Month[i] == Day_2)
                    {

                    i = 12;

                    }
                    else
                    {

                    j++;
                    DayIn += DayM[j];

                    }
                
            }
            return DayIn;

        }
        /// <summary>
        /// Определние высокостного года
        /// </summary>
        public string LeapYear(int Day_1) 
        {
            string Type;
            if (Day_1 % 400 == 0)
            {

                Type = "Год высокосный";

            }
            else
            {

                Type = "Год не высокосный";

            }
            return Type;


        }

        /// <summary>
        /// Время суток
        /// </summary>
        public string TimeOfDay(int Day) 
        {
            
            if (Day <= 12 && Day >= 6)
            {
                Type = "Сейчас утро";
            }
            else if (Day < 18 && Day >= 13)
            {
                Type = "Сейчас днь";
            }
            else if (Day <= 23 && Day >= 17)
            {
                Type = "Сейчас вечер";
            }
            else if (Day <= 5 && Day >= 0)
            {
                Type = "Сейчас ночь";
            }

            return Type;

        }
    }
}
