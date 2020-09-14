using System;

namespace CSharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var account = new Account("1", DateTime.Now.ToUniversalTime());
            Console.WriteLine($"Account id: {account.Id} {account.CreationTime}");
        }
    }
}
