using System;

namespace TCPExtensions
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> filter = new List<T>();

            foreach (T record in records)
            {
                if (func(record))
                {
                    filter.Add (record);
                }
            }

            return filter;
        }
    }
}
