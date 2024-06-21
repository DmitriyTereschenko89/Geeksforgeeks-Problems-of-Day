namespace K_closest_elements
{
    public record class CloseElement(int elem, int absDiff, int index)
    {
        public readonly int _elem = elem;
        public readonly int _absDiff = absDiff;
        public readonly int _index = index;
    }
}
