namespace Mono.Security
{
    internal static class Locale
    {
        internal static string GetText(string msg)
        {
            return msg;
        }

        internal static string GetText(string msg, params object[] args)
        {
            return string.Format(msg, args);
        }
    }
}
