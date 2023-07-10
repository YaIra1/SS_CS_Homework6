namespace DeveloperTask
{
    public class Builder : IDeveloper
    {
        private readonly string _tool;

        public string Tool => _tool;

        public Builder(string tool)
        {
            _tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Working with a {Tool} tool");
        }

        public void Destroy()
        {
            Console.WriteLine($"Destroing {Tool} tool while working hard");
        }
    }
}
