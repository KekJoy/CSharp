using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new string[31]; // Массив данных для оси X. 
            
            for (var i = 1; i < days.Length; i++)
                days[i] = (i + 1).ToString();
            
            
            var birthsCounter = new double[31]; // Массив данных для оси Y
            
            foreach (var day in names)
                if (day.Name == name && day.BirthDate.Day != 1)
                birthsCounter[day.BirthDate.Day - 1]++;


            return new HistogramData("Рождаемость по числам в зависимоти от имени", days, birthsCounter);
        }
    }
}