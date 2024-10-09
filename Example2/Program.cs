namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть розмір масиву:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть множник:");
                int mul = Convert.ToInt32(Console.ReadLine());

                Arrays a = new Arrays(n);
                a = Arrays.generateRandomArray(a);

                Arrays resArray = a * mul;

                Console.WriteLine("Оригінальний масив:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.WriteLine("Масив після множення:");
                for (int i = 0; i < resArray.Length; i++)
                {
                    Console.WriteLine(resArray[i]);
                }
            }
            catch
            {
                Console.WriteLine("Помилка введення даних.");
            }
        }
    }
}
