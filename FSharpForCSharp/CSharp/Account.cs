namespace CSharp
{
    using System;
    public class Account
    {
        public Account(string id, DateTime creationTime)
        {
            Id = id;
            CreationTime = creationTime;
        }

        public string Id { get; }
        public DateTime CreationTime { get; }
    }
}