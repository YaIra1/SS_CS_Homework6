namespace FlyableTask
{
    public class Bird : IFlyable
    {
        private string _name;
        private bool _canFly;

        public Bird(string name, bool canFly)
        {
            _name = name;
            _canFly = canFly;

        }

        public void Fly()
        {
            Console.WriteLine($"The {_name} bird can fly: {_canFly}");
        }
    }
}
