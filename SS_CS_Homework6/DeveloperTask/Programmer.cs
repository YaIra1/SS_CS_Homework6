namespace DeveloperTask
{
    public class Programmer : IDeveloper
    {
        private readonly string _language;

        public string Tool => _language;

        public Programmer(string language)
        {
            _language = language;
        }

        public void Create()
        {
            Console.WriteLine($"Creating application using {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Destroying a project using {Tool} language");
        }
    }
}
