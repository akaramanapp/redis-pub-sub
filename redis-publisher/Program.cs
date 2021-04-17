using System;
using StackExchange.Redis;

namespace redis_publisher
{
    class Program
    {
        private const string RedisConnectionString = "localhost:6379";
        private static ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(RedisConnectionString);
        private const string Channel = "channel_one";
        static void Main(string[] args)
        {
            var pubsub = connection.GetSubscriber();
            // Mesajı kanala gönderiyoruz.
            pubsub.PublishAsync(Channel, "Deneme Mesaji!", CommandFlags.FireAndForget);
            Console.Write("Mesaj gönderildi.");
        }
    }
}
