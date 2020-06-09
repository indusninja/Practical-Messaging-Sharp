using SimpleMessaging;
using System;

namespace Model
{
    public class Greeting : IAmAMessage
    {
        public string Salutation { get; set; } = "Hello World";
        public DateTime SendTime { get; set; } = DateTime.Now;
    }
}