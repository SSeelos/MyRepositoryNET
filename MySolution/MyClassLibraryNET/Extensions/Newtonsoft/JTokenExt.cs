using Newtonsoft.Json.Linq;

namespace MyRootNamespace.MyClassLibraryNET
{
    public static class JTokenExt
    {
        public static T? GetTokenValue<T>(this JToken token, string tokenName)
        {
            JToken? value = token.SelectToken(tokenName);
            return value == null ? default : value.Value<T>();
        }
    }
}
