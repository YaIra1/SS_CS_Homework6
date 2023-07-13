namespace TelephoneTask
{
    public class Program
    {
        public static void Main(string[] consoleArguments)
        {
            var list = new List<ITelephone>
            {
                new MobileTelephone("Sony", 650),
                new RadioTelephone("Panasonic", 300, true),
                new MobileTelephone("OnePlus", 500),
                new RadioTelephone("Motorola", 250, false)
            };

            foreach (var item in list)
            {
                item.Info();
            }
            Console.WriteLine();

            list.Sort();
            Console.WriteLine("Sorted telephones by price:");

            foreach (var item in list)
            {
                item.Info();
            }
            Console.WriteLine();

            Console.WriteLine($"Total price of telephones is: $ {list.Sum(t => t.Price)}");
            Console.WriteLine();

            Console.WriteLine("All radiotelephones with autoresponse: ");
            foreach (ITelephone item in list)
            {
                if (item is RadioTelephone radio && radio.HasAutoresponse)
                {
                    radio.Info();
                }
            }
        }
    }
}