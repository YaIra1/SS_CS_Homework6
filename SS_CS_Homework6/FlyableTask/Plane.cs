namespace FlyableTask
{
    public class Plane : IFlyable
    {
        private string _mark;
        private double _highFly;

        public Plane(string mark, double highFly)
        {
            _mark = mark;
            _highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"The mark of the plane {_mark} flies on height {_highFly}");
        }
    }
}
