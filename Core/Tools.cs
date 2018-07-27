namespace Tools
{
    public static class TypeConverters
    {
        public static T Convert<T>(U input)
        {
            return (T) input;
        }
    }
}
