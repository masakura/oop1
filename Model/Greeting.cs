namespace App.Model
{
    public sealed class Greeting
    {
        private readonly string _username;

        public Greeting(string username)
        {
            _username = username;
        }

        public string Message()
        {
            var ampm = new AmPm();
            var format = new GreetingFormat(_username, ampm);
            return format.Text();
        } 
    }
}