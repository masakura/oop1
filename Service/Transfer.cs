using System.IO;

namespace App.Service
{
    internal sealed class Transfer
    {
        private readonly TextWriter _writer = System.Console.Out;

        internal void Send(string message) {
            _writer.WriteLine(message);
        }
    }
}