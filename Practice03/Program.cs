namespace Practice03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle();

            circle1.Input();
            circle2.Input();

            TCircle.InputKut();

            circle1.Output();
            circle2.Output();

            circle1.Porivn(circle2);

            Console.WriteLine("\nДодавання радіусів:");
            TCircle circle3 = new TCircle(circle1 + circle2);
            circle3.Output();

            Console.WriteLine("\nВіднімання радіусів:");
            double R4 = Math.Max(circle1.Radius, circle2.Radius) - Math.Min(circle1.Radius, circle2.Radius);
            TCircle circle4 = new TCircle(R4);
            circle4.Output();

            Console.WriteLine("\nМноження радіус кола1 на число. Введіть число:");
            int number = Convert.ToInt32(Console.ReadLine());
            TCircle circle5 = new TCircle(circle1 * number);
            circle5.Output();
        }
    }
}
