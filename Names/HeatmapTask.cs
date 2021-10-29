using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new string[30];
         	for (var i = 0; i < days.Length; i++)
                days[i] = (i + 2).ToString();
            
            var mounth = new string[12];
            for (var i = 0; i < mounth.Length; i++)
               mounth[i] = (i + 1).ToString();
            
            double[,] dataForHistogram = new double[days.Length, mounth.Length];
            foreach (var date in names)
               if (date.BirthDate.Day > 1)
               dataForHistogram[date.BirthDate.Day - 2, date.BirthDate.Month - 1]++;
            
            return new HeatmapData("Рождаемость в зависимости от дня и месяца",dataForHistogram, days, mounth);
        }
    }
}