using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods_ConsoleApp
{
    public class Pizza
    {
        public string Content { get; set; }
        public decimal Totalprise { get; set; }

        public override string ToString()
        {
            return $"{Content} \n------------------------\nTotalPrise: {Totalprise.ToString( "#.##" )}";
        }
    }
    public static class PizzaExtention
    {
        public static Pizza AddTopping( this Pizza value, string topping )
        {
            value.Content += $"\n{topping} X $1.5";
            value.Totalprise += 1.5m;
            return value;
        }
        public static Pizza AddSauce( this Pizza value )
        {
            value.Content += $"\nSaucs Added X $2.5";
            value.Totalprise += 2.5m;
            return value;
        }
        public static Pizza AddCheeze( this Pizza value, bool extra )
        {
            value.Content += $"\n{( extra ? "extra" : "regular" )} Cheeze X ${( extra ? "7.00" : "3.5" )}";
            value.Totalprise += extra ? 7m : 3.5m;
            return value;
        }
    }

    internal class Program
    {
        static void Main( string[] args )
        {
            Pizza pizza = new Pizza
            {
                Content = "Burger",
                Totalprise = 5m
            };
            pizza.AddTopping( "Mushrooms" )
                .AddTopping( "Olives" )
                .AddSauce()
                .AddCheeze( true );
            Console.WriteLine( pizza.ToString() );
            Console.ReadKey();
        }
    }
}
