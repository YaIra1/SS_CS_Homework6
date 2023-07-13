namespace TelephoneTask
{
    public class RadioTelephone : ITelephone
    {
        private string _name;
        private double _price;
        private bool _hasAutoresponse;

        public string Name => _name;
        public double Price => _price;
        public bool HasAutoresponse => _hasAutoresponse;

        public RadioTelephone(string name, double price, bool hasAutoresponse)
        {
            _name = name;
            _price = price;
            _hasAutoresponse = hasAutoresponse;
        }

        public void Info()
        {
            Console.WriteLine($"Radio telephone {_name} costs ${_price} and has autoresponse: {_hasAutoresponse}");
        }
    }
}
