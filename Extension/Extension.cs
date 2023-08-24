using System;


namespace Extension
{
    public static class Extension
    {
        public static int WordCount(this string s)
        {
            string[] words = s.Split(new char[] {' ','.','?','!'}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public static int Parse(this string s)
        {
            return int.TryParse(s, out int i)? i:0;
        }
    }
}
