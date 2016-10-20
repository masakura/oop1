namespace App.Service
{
    internal sealed class User
    {
        internal string Name { get; } = System.Environment.GetEnvironmentVariable("USER");
    }
}