using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
    class Program
    {
        public class Publisher
        {
            // Define a delegate for the event
            public delegate void Notify(string message);

            // Define an event based on the delegate
            public event Notify OnPublish;

            public void Publish(string message)
            {
                // Raise the event
                OnPublish?.Invoke(message);
            }
        }

        public class Subscriber
        {
            public void Subscribe(Publisher publisher)
            {
                // Subscribe to the event
                publisher.OnPublish += Display;
            }

            private void Display(string message)
            {
                Console.WriteLine($"Received message: {message}");
            }
        }
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Subscribe to the event
            subscriber.Subscribe(publisher);

            // Publish a message
            publisher.Publish("Hello, Events!");
        }
    }
}
