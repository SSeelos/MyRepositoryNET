namespace SystemExtensions
{
    public static class CollectionExt
    {
        /// <returns>true if contained completely</returns>
        public static bool Contains<T>(this ICollection<T> collection, IEnumerable<T> values)
        {
            foreach (var item in values)
            {
                if (!collection.Contains(item))
                    return false;
            }

            return true;
        }

        /// <returns>true if any match found</returns>
        public static bool ContainsAny<T>(this ICollection<T> collection, IEnumerable<T> values)
        {
            foreach (var item in values)
            {
                if (collection.Contains(item))
                    return true;
            }

            return false;
        }

        /// <returns>true if items match exactly</returns>
        public static bool IsMatch<T>(this ICollection<T> collection, IEnumerable<T> values)
        {
            List<T> valuesList = values.ToList();
            List<T> collectionList = collection.ToList();

            if (valuesList.Count != collectionList.Count)
                return false;

            for (int i = 0; i < collection.Count; i++)
            {
                if (!collectionList[i].Equals(valuesList[i]))
                    return false;
            }

            return true;
        }
    }
}
