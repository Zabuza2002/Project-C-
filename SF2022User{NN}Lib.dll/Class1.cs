using System;

namespace SF2022User_NN_Lib.dll
{
    public class Calculations
    {
        public string [] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan  beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            string[] fteeperiods = new string[30];
            return fteeperiods;
        }
        public static bool AvailablePeriods(string pass)
        {
            if(pass.Length <8 || pass.Length > 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
