namespace FlyableTask
{
    public class Program
    {
        public static void Main(string[] consoleArguments)
        {
            var list = new List<IFlyable>
            {
                new Bird("Pinguin", false),
                new Plane("Embraer", 20000),
                new Bird("Eagle", true),
                new Plane("Piper", 2500)
            };

            foreach (var item in list)
            {
                item.Fly();
            }
        }
    }
}