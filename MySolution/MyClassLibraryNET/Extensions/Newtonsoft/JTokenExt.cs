using Newtonsoft.Json.Linq;

namespace MyRootNamespace.MyClassLibraryNET
{
    public static class JTokenExt
    {
        public static T? GetValue<T>(this JToken token, string tokenName)
        {
            var value = token.SelectToken(tokenName);
            return value == null ? default : value.Value<T>();
        }
    }
}
