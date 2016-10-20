using System;

namespace App.Model
{
    internal sealed class Clock
    {
        private Func<DateTime> _now = () => DateTime.Now;

        internal string AmPm()
        {
            var hour = _now().Hour;
            if (hour <= 12)
            {
                return "am";
            } else {
                return "pm";
            }
        }
    }
}