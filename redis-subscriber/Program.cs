using System;
using StackExchange.Redis;

namespace redis_subscriber
{
    class Program
    {
        private const string RedisConnectionString = "localhost:6379";
        private static ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(RedisConnectionString);
        private const string Channel = "channel_one";
        static void Main(string[] args)
        {
            // Create pub/sub
            var pubsub = connection.GetSubscriber();

            // Subscriber subscribes to a channel
            pubsub.Subscribe(Channel, (channel, message) => Console.Write(message));
            Console.ReadLine();
        }
    }
}
