using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNotifications_Events__ConsoleApp
{
    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public string OrderName { get; }
        public decimal OrderTotalPrice { get; }
        public OrderEventArgs( int orderID, string orderName, decimal orderTotalPrice )
        {
            OrderID = orderID;
            OrderName = orderName;
            OrderTotalPrice = orderTotalPrice;
        }
    }
    public class Order
    {
        public event EventHandler<OrderEventArgs> OnOrderCreated;
        public void CreateOrder( int orderID, string orderName, decimal orderTotalPrice )
        {
            OnOrderCreated?.Invoke( this, new OrderEventArgs( orderID, orderName, orderTotalPrice ) );
        }
    }
    public class EmailService
    {
        public void Subscribe( Order order )
        {
            order.OnOrderCreated += HandlerOrderCreation;
        }
        public void UnSubscribe( Order order )
        {
            order.OnOrderCreated -= HandlerOrderCreation;
        }
        public void HandlerOrderCreation( object sender, OrderEventArgs e )
        {
            Console.WriteLine( $"EmailService: Order Created: {e.OrderID}, {e.OrderName}, {e.OrderTotalPrice}" );
        }
    }
    public class SMSService
    {

        public void Subscribe( Order order )
        {
            order.OnOrderCreated += HandlerOrderCreation;
        }
        public void UnSubscribe( Order order )
        {
            order.OnOrderCreated -= HandlerOrderCreation;
        }
        public void HandlerOrderCreation( object sender, OrderEventArgs e )
        {
            Console.WriteLine( $"SMSService: Order Created: {e.OrderID}, {e.OrderName}, {e.OrderTotalPrice}" );

        }
    }
    public class ShippingService
    {
        public void Subscribe( Order order )
        {
            order.OnOrderCreated += HandlerOrderCreation;
        }
        public void UnSubscribe( Order order )
        {
            order.OnOrderCreated -= HandlerOrderCreation;
        }
        public void HandlerOrderCreation( object sender, OrderEventArgs e )
        {
            Console.WriteLine( $"ShippingService: Order Created: {e.OrderID}, {e.OrderName}, {e.OrderTotalPrice}" );
        }
    }

    internal class Program
    {
        static void Main( string[] args )
        {
            Order order = new Order();

            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            ShippingService shippingService = new ShippingService();

            emailService.Subscribe( order );
            smsService.Subscribe( order );
            shippingService.Subscribe( order );

            order.CreateOrder( 1, "Order1", 100 );

            Console.WriteLine( "--------------------------------------" );
            order.CreateOrder( 2, "Order2", 200 );

            Console.WriteLine( "--------------------------------------------" );
            shippingService.UnSubscribe( order );
            order.CreateOrder( 3, "Order3", 500 );

            Console.WriteLine( "--------------------------------------" );
            order.CreateOrder( 4, "Order4", 700 );

            Console.ReadLine();
        }
    }
}
