using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisherSubscriper_Events__ConsolApp
{
    public class NewNews
    {
        public string Title { get; }
        public string Body { get; }

        public NewNews( string title, string body )
        {
            Title = title;
            Body = body;
        }
    }
    public class Publisher
    {
        public event EventHandler<NewNews> OnNewsPublished;

        public void PublishNews( string title, string body )
        {
            OnNewsPublished?.Invoke( this, new NewNews( title, body ) );
        }
    }
    public class Subscriber
    {
        private string _Name;

        public Subscriber( string name )
        {
            _Name = name;
        }

        public void Subscribe( Publisher publisher )
        {
            publisher.OnNewsPublished += HandleNewsPublished;
        }

        public void UnSubscribe( Publisher publisher )
        {
            publisher.OnNewsPublished -= HandleNewsPublished;
        }

        public void HandleNewsPublished( object sender, NewNews newNews )
        {
            Console.WriteLine( $" {_Name} received news with title -{newNews.Title}- and body -{newNews.Body}-" );
        }

    }
    internal class Program
    {
        static void Main( string[] args )
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber1 = new Subscriber( "Subscriber1" );
            Subscriber subscriber2 = new Subscriber( "Subscriber2" );

            subscriber1.Subscribe( publisher );
            subscriber2.Subscribe( publisher );

            publisher.PublishNews( "News1", "News1 Body" );
            Console.WriteLine();
            publisher.PublishNews( "News2", "News2 Body" );

            Console.ReadLine();
        }
    }
}
