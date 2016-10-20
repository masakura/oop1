namespace App.Service
{
    public sealed class Launcher
    {
        public void Launch()
        {
            var service = new GreetingService();
            service.Greet();
        }
    }
}