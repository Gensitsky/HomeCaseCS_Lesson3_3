/*Описать структуру RequestItem содержащую поля:
товар; количество единиц товара.*/
using System;

namespace HomeCaseCS_Lesson3_3
{
    struct RequestItem
    {
        private string productName;
        private int productUnits;

        public RequestItem(string name,int units)
        {
            productName = name;
            productUnits = units;
        }
        public void PrintRequest()
        {
            Console.WriteLine($"Product: {productName}");
            Console.WriteLine($"Units: {productUnits}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RequestItem item1 = new RequestItem("Notebook Asus X302UV", 1);
            RequestItem item2 = new RequestItem("Notebook Asus X751LB", 1);

            item1.PrintRequest();
            Console.WriteLine();
            item2.PrintRequest();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
