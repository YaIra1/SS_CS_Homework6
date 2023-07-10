namespace DeveloperTask
{
    public class Program
    {
        public static void Main(string[] consoleArguments)
        {
            var list = new List<IDeveloper>
            {
                new Builder("Hammer"),
                new Programmer("C#"),
                new Builder("Brush"),
                new Programmer("Java")
            };

            list.Sort();

            foreach (IDeveloper item in list)
            {
                Console.WriteLine(item.Tool);
                item.Create();
                item.Destroy();
                Console.WriteLine();
            }
        }
    }
}