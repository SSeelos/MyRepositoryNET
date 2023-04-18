using System.Runtime.CompilerServices;

namespace SystemExtensions
{
    public static class ObjectExt
    {
        public static object ChangeType(this object obj, Type type)
            => Convert.ChangeType(obj, type);
        public static T ChangeType<T>(this object obj)
            => (T)obj.ChangeType(typeof(T));

        public class ExtensionProperty<T>
        {
            public T Property { get; set; }
        }
        private static readonly ConditionalWeakTable<object, ExtensionProperty<object>> data
            = new();

        /// <summary>
        /// allows extension of (sealed) types with properties
        /// </summary>
        public static ExtensionProperty<object> GetExtension(this object subject)
            => data.GetOrCreateValue(subject);
    }
}
