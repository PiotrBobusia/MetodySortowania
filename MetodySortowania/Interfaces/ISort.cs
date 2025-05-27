namespace MetodySortowania.Interfaces
{
    public interface ISort
    {
        abstract T[] Sort<T>(T[] myArray) where T : IComparable;
    }
}