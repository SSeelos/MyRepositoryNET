using System.Reflection;

namespace SystemExtensions.Reflection
{
    public static class MemberInfoExt
    {
        /// <summary>
        ///checks if a given <see cref="MemberInfo"/> object has an attribute of type T applied to it.
        /// </summary>
        public static bool IsDefinedByAttribute<T>(this MemberInfo memberInfo)
            where T : Attribute
            => Attribute.IsDefined(memberInfo, typeof(T));
        public static bool IsDefinedByAttribute(this MemberInfo memberInfo, Type attributeType)
            => Attribute.IsDefined(memberInfo, attributeType);
    }
}
