using System;

namespace EventExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            notifier.NotifyEvent += new Notifier.NotificationDelegate(new EmailNotification().Notify);
            notifier.NotifyEvent += new Notifier.NotificationDelegate(new MobileNotification().Notify);
            notifier.SendNotification("email","Hello Email");
        }
    }

    class Notifier
    {
        public delegate void NotificationDelegate(string career, string message);
        public event NotificationDelegate NotifyEvent;
        public void SendNotification(string career,string message)
        {
            NotifyEvent(career,message);
        }
    }
    class EmailNotification
    {
        public void Notify(string career,string message)
        {
            Console.WriteLine($"Sending to Email Address => {career}");
            Console.WriteLine("Message: "+message);
        }
    }
    class MobileNotification
    {
        public void Notify(string career, string message)
        {
            Console.WriteLine($"Sending to Mobile Career Mobile Number => {career}");
            Console.WriteLine("Message: "+message);
        }
    }
}
