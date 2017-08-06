using System;
using System.Linq;

namespace Academy.Models.Utils
{
    public static class DateParser
    {
        public static DateTime Parser(string input)
        {
            //2017-01-24
            var splitted = input.Split('-').Select(x => int.Parse(x)).ToArray();

            int year = splitted[0];
            int month = splitted[1];
            int day = splitted[2];

            return new DateTime(year, month, day);

        }


    }
}
