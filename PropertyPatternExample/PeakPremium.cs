using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyPatternExample
{
    public static class PeakPremium
    {
        public static decimal CalculatePeakTimePremium(DateTime time, bool isInbound) =>
            (IsWeekDay(time), GetTimeSlots(time), isInbound) switch
            {
                (true, TimeSlots.MorningPeak, true) => 2.00m,
                (true, TimeSlots.MorningPeak, false) => 1.00m,
                (true, TimeSlots.Daytime, true) => 1.50m,
                (true, TimeSlots.Daytime, false) => 1.50m,
                (true, TimeSlots.EveningPeak, true) => 1.00m,
                (true, TimeSlots.EveningPeak, false) => 2.00m,
                (true, TimeSlots.Overnight, true) => 0.75m,
                (true, TimeSlots.Overnight, false) => 0.75m,
                (false, TimeSlots.MorningPeak, true) => 1.00m,
                (false, TimeSlots.MorningPeak, false) => 1.00m,
                (false, TimeSlots.Daytime, true) => 1.00m,
                (false, TimeSlots.Daytime, false) => 1.00m,
                (false, TimeSlots.EveningPeak, true) => 1.00m,
                (false, TimeSlots.EveningPeak, false) => 1.00m,
                (false, TimeSlots.Overnight, true) => 1.00m,
                (false, TimeSlots.Overnight, false) => 1.00m,
                (false, _, _) => 1.0m
            };
        private enum TimeSlots
        {
            MorningPeak,
            Daytime,
            EveningPeak,
            Overnight
        }

        private static TimeSlots GetTimeSlots(DateTime time)
        {
            int hour = time.Hour;
            if (hour < 6)
                return TimeSlots.Overnight;
            else if (hour < 10)
                return TimeSlots.MorningPeak;
            else if (hour < 16)
                return TimeSlots.Daytime;
            else if (hour < 20)
                return TimeSlots.EveningPeak;
            else
                return TimeSlots.Overnight;
        }
        private static bool IsWeekDay(DateTime timeOfToll) =>
            timeOfToll.DayOfWeek switch
            {
                DayOfWeek.Saturday => false,
                DayOfWeek.Sunday => false,
                _ => true
            };
    }
}
