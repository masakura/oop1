namespace App.Model
{
    internal sealed class AmPm
    {
        private readonly Clock _clock = new Clock();

        internal string Message() {
            var ampm = _clock.AmPm();

            string message = string.Empty;

            if (ampm == "am")
            {
                message = "おはようございます";
            }
            else if (ampm == "pm")
            {
                message = "こんにちは";
            }

            return message;
        }
    }
}