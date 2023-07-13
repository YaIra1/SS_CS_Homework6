namespace TelephoneTask
{
    public class MobileTelephone : ITelephone
    {
        private string _name;
        private double _price;

        public string Name => _name;
        public double Price => _price;

        public MobileTelephone(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public void Info()
        {
            Console.WriteLine($"Mobile telephone {_name} costs ${_price}");
        }
    }
}
