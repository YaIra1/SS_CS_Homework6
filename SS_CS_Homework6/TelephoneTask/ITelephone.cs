namespace TelephoneTask
{
    public interface ITelephone : IComparable<ITelephone>
    {
        string Name { get; }
        double Price { get; }
        void Info();

        int IComparable<ITelephone>.CompareTo(ITelephone another)
        {
            ArgumentNullException.ThrowIfNull(another);

            return this.Price.CompareTo(another.Price);
        }
    }
}
