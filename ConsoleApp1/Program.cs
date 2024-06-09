using System;
using System.Text;

namespace BicycleApp
{
    class Bicycle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FrameSize { get; set; }
        public int WheelSize { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }
        public decimal Price { get; set; }
        public const decimal DiscountPercentage = 10.0m;
        // конструктор класу
        public Bicycle(string brand, string model, int frameSize, int wheelSize, string color, bool isElectric, decimal price)
        {
            Brand = brand;
            Model = model;
            FrameSize = frameSize;
            WheelSize = wheelSize;
            Color = color;
            IsElectric = isElectric;
            Price = price;
        }

        // метод для виведення інформації про велосипед
        public void DisplayInfo()
        {
            string electricStatus = IsElectric ? "Так" : "Ні";
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Розмір рами: {FrameSize}");
            Console.WriteLine($"Розмір колеса: {WheelSize}");
            Console.WriteLine($"Колір: {Color}");
            Console.WriteLine($"Електричний: {electricStatus}");
            Console.WriteLine($"Ціна: {Price:F2}");
            Console.WriteLine($"Знижка: {DiscountPercentage}%");
            Console.WriteLine($"Ціна зі знижкою: {CalculateDiscountedPrice():F2}");
        }

        // метод для розрахунку вартості зі знижкою
        public decimal CalculateDiscountedPrice()
        {
            decimal discountAmount = Price * (DiscountPercentage / 100);
            return Price - discountAmount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            // введення даних для одного екземпляра
            Console.Write("Введіть бренд велосипеда: ");
            string brand = Console.ReadLine();

            Console.Write("Введіть модель велосипеда: ");
            string model = Console.ReadLine();

            Console.Write("Введіть розмір рами: ");
            int frameSize = int.Parse(Console.ReadLine());

            Console.Write("Введіть розмір колеса: ");
            int wheelSize = int.Parse(Console.ReadLine());

            Console.Write("Введіть колір велосипеда: ");
            string color = Console.ReadLine();

            Console.Write("Велосипед електричний (так/ні): ");
            bool isElectric = Console.ReadLine().ToLower() == "так";

            Console.Write("Введіть ціну велосипеда: ");
            decimal price = decimal.Parse(Console.ReadLine());

            // створення об'єкта класу Bicycle
            Bicycle bike = new Bicycle(brand, model, frameSize, wheelSize, color, isElectric, price);

            // проведення дій методом класу та виведення результатів на екран
            Console.WriteLine("\nІнформація про велосипед:");
            bike.DisplayInfo();
        }
    }
}