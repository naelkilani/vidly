using System;

namespace Vidly.Utilities
{
    public static class Utilities
    {
        public static int CalculateAge(this DateTime birthdate)
        {
            var age = DateTime.Now.Year - birthdate.Year;

            if (DateTime.Now.DayOfYear < birthdate.DayOfYear)
                age -= 1;

            return age;
        }
    }
}