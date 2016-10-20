using App.Model;

namespace App.Service
{
    internal sealed class GreetingService
    {
        private readonly User _user = new User();
        private readonly Transfer _transfer = new Transfer();

        internal void Greet() {
            var greeting = new Greeting(_user.Name);
            var message = greeting.Message();
            _transfer.Send(message);
        }
    }
}