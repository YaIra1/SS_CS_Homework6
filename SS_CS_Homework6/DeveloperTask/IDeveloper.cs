namespace DeveloperTask
{
    public interface IDeveloper : IComparable
    {
        string Tool { get; }

        void Create();
        void Destroy();

        int IComparable.CompareTo(object? obj)
        {
            var another = obj as IDeveloper;

            ArgumentNullException.ThrowIfNull(obj);

            return this.Tool.CompareTo(another.Tool);
        }
    }
}
