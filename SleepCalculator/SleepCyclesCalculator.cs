using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleepCalculator
{
    static class SleepCyclesCalculator
    {
        /// <summary>
        /// Oblicza godzinę pójścia spać dla zadanego czasu pobudki w oparciu o półtoragodzinne cykle snu. 
        /// </summary>
        /// <param name="goToSleepTime">
        /// Czas pójścia spać w formacie HH:mm.
        /// </param>
        /// <returns>Trololo</returns>
        public static string GetGoSleepTime(string wakeUpTime)
        {
            DateTime wakeUpDateTime;

            if (DateTime.TryParse(wakeUpTime, out wakeUpDateTime))
                return wakeUpDateTime.AddHours(-5 * 1.5).ToShortTimeString();

            return "Invalid time format";
        }
    }
}
