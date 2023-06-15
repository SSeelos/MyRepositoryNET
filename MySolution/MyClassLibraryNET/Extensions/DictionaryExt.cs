namespace MyRootNamespace.MyClassLibraryNET
{
    public static class DictionaryExt
    {
        /// <summary>
        /// ignore white space and case
        /// </summary>
        public static TVal GetGenerous<TVal>(this Dictionary<string, TVal> dictionary, string key)
        {
            return dictionary.Where(x
                => x.Key.Replace(" ", "").ToLower()
                == key.Replace(" ", "").ToLower())
                .FirstOrDefault().Value;
        }
    }
}
