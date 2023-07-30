namespace ExplorerPasteHelper
{
    internal static class Utils
    {
        public static string PadRight(string str, string padString, int length)
        {
            if(str == null)
            {
                return null;
            }

            if(str.Length > length)
            {
                return str.Substring(0, length - padString.Length) + padString;
            }
            else
            {
                return str;
            }
        }
    }
}
