using FluentAssertions.Execution;
namespace MyXUnitTestProject
{
    public static class AssertionScopeExt
    {
        public static void AssertionScope<T>(this T subject, Action<T> action)
        {
            using var scope = new AssertionScope();
            action.Invoke(subject);
        }
        /// <summary>
        /// reports failures BUT does not cause test to fail!
        /// </summary>
        public static string[] AssertionScopeFailures<T>(this T subject, Action<T> action)
        {
            using var scope = new AssertionScope();
            action.Invoke(subject);

            return scope.Discard();
        }
    }
}
