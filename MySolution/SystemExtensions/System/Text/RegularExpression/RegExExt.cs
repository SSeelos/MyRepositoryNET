using System.Text.RegularExpressions;

namespace SystemExtensions.RegularExpressions
{
    public static class RegExExt
    {
        public static class Pattern
        {
            public const string AnonymousMethodName = @"<(\w|_)+>b_.+";
            //https://regex101.com/r/TTbb2Q/1
            //  /.*\.\d+.r(vt|fa)$/gm
            public const string RevitBackupFile = @".*\.\d+.r(vt|fa)$";
        }

        public static Regex AnonymousMethodName => new(Pattern.AnonymousMethodName);
        public static Regex RevitBackupFile => new(Pattern.RevitBackupFile);

        public static bool IsMatch(this string input, string pattern)
            => Regex.IsMatch(input, pattern);
        public static bool IsMatch(this string input, string pattern, RegexOptions options)
            => Regex.IsMatch(input, pattern, options);
        public static bool IsMatch(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
            => Regex.IsMatch(input, pattern, options, matchTimeout);
        public static Match Match(this string input, string pattern)
            => Regex.Match(input, pattern);
        public static Match Match(this string input, string pattern, RegexOptions options)
            => Regex.Match(input, pattern, options);
        public static Match Match(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
            => Regex.Match(input, pattern, options, matchTimeout);
        public static MatchCollection Matches(this string input, string pattern)
            => Regex.Matches(input, pattern);
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
            => Regex.Matches(input, pattern, options);
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
            => Regex.Matches(input, pattern, options, matchTimeout);
        public static string Replace(this string input, string pattern, string replacement)
            => Regex.Replace(input, pattern, replacement);
        public static string Replace(this string input, string pattern, string replacement, RegexOptions options)
            => Regex.Replace(input, pattern, replacement, options);
        public static string Replace(this string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
            => Regex.Replace(input, pattern, replacement, options, matchTimeout);
        public static string[] Split(this string input, string pattern)
            => Regex.Split(input, pattern);
    }
}
