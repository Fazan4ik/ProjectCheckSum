using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCheckSum
{
    public struct Check
    {
        public string Name { get; set; }        
        public int Quantity { get; set; }       
        public double UnitPrice { get; set; }  
        public double Discount { get; set; }    
        public double TotalCost { 
            get {
                return (UnitPrice * Quantity) * (1 - (Discount / 100));
            } 
        }   
        public string Note { get; set; }      

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Black;  
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\t\tCheck\t\t");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"\tProduct name : {Name}");
            Console.WriteLine($"\tQuantity: {Quantity}\t \t");
            Console.WriteLine($"\tUnit price: {UnitPrice} c.u.\t");
            Console.WriteLine($"\tDiscount: {Discount}% \t \t");
            Console.WriteLine($"\tTotal price: {TotalCost} c.u\t");
            Console.WriteLine($"\tWishlist: {Note}\t");
            Console.WriteLine("--------------------------------");

            Console.ResetColor();  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Check check = new Check
            {
                Name = "Coca cola",          
                Quantity = 1,              
                UnitPrice = 100,          
                Discount = 50,           
                Note = "I am Egor" 
            };

            check.Print();
        }
    }
}
