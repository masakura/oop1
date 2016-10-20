namespace App.Model
{
    internal sealed class GreetingFormat
    {
        private readonly string _username;
        private readonly string _message;

        public GreetingFormat(string username, AmPm ampm)
        {
            this._username = username;
            this._message = ampm.Message();
        }

        internal string Text()
        {
            return $"{_username}さん、{_message}";
        }
    }
}