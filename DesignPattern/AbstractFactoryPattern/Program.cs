using AbstractFactoryPattern.ConcreteClient;
using AbstractFactoryPattern.ConcreteFactoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{

    public interface IMessageSender
    {
        void Send(string to, string message);
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending EMAIL to {to}: {message}");
        }
    }

    public class EmailLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[EMAIL LOG] {message}");
        }
    }

    public class SmsSender : IMessageSender
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to}: {message}");
        }
    }

    public class SmsLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[SMS LOG] {message}");
        }
    }

    //Abstract Factory Interface
    public interface INotificationFactory
    {
        IMessageSender CreateMessageSender();
        ILogger CreateLogger();
    }


    //Concrete Factories
    public class EmailNotificationFactory : INotificationFactory
    {
        public IMessageSender CreateMessageSender() => new EmailSender();
        public ILogger CreateLogger() => new EmailLogger();
    }

    public class SmsNotificationFactory : INotificationFactory
    {
        public IMessageSender CreateMessageSender() => new SmsSender();
        public ILogger CreateLogger() => new SmsLogger();
    }

    //Client Code
    public class NotificationService
    {
        private readonly IMessageSender _sender;
        private readonly ILogger _logger;

        public NotificationService(INotificationFactory factory)
        {
            _sender = factory.CreateMessageSender();
            _logger = factory.CreateLogger();
        }

        public void Notify(string recipient, string message)
        {
            _sender.Send(recipient, message);
            _logger.Log($"Message sent to {recipient}");
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            INotificationFactory factory;

            string type = "SMS";

            if (type == "Email")
                factory = new EmailNotificationFactory();
            else
                factory = new SmsNotificationFactory();

            var service = new NotificationService(factory);
            service.Notify("1234567890", "Hello from the Notification Service!");
        }
    }
}
