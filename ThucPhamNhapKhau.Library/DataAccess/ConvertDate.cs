using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThucPhamNhapKhau.Library.DataAccess
{
    public class ConvertDate
    {
        public static int Day(string date)
        {
            int chuoi = 1;
            if (date != "" && date != "NULL")
            {
                int day;
                string[] temp;
                temp = date.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    day = Convert.ToInt32(temp[0]);
                    chuoi = day;
                }
                catch
                {

                }

            }
            return chuoi;

        }
        public static int Month(string date)
        {
            int chuoi = 1;
            if (date != "" && date != "NULL")
            {
                int month;
                string[] temp;
                temp = date.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    month = Convert.ToInt32(temp[1]);
                    chuoi = month;
                }
                catch
                {

                }

            }
            return chuoi;

        }
        public static int Year(string date)
        {
            int chuoi = 0;
            if (date != "" && date != "NULL")
            {
                int year;
                string[] temp;
                temp = date.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    year = Convert.ToInt32(temp[2]);
                    chuoi = year;
                }
                catch
                {

                }

            }
            return chuoi;

        }

        public static DateTime YearMonthDay(string date)
        {
            DateTime data = new DateTime();
            if (date != "")
            {
                data = new DateTime(Year(date), Month(date), Day(date));
            }
            
            return data;
        }
    }
}