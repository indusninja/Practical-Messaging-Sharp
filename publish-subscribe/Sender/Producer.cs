using System;
using SimpleMessaging;

namespace Sender
{
    class Producer
    {
        static void Main(string[] args)
        {
            using (var channel = new PublishSubscribeChannel(ChannelType.Publisher))
            {
                var rand = new Random();
                var id = rand.Next(0, 100);
                string message = "Hello World! from " + id;
                channel.Send(message);
                Console.WriteLine("Sent message {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}