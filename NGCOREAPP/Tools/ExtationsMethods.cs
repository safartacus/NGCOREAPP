namespace NGCOREAPP.Tools
{
    public static class ExtationsMethods
    {
        public static string LowerCase(this Random random)
        {
            return ((char)random.Next('a', 'z')).ToString();
        }
        public static string UpperCase(this Random random)
        {
            return ((char)random.Next('A', 'Z')).ToString();
        }
    }
}
