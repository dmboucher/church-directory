namespace DirectoryApp
{
    public static class Common
    {
        public static int CountWordsAndCommas(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString)) return 0;

            int c = 0;
            for (int i = 1; i < inputString.Length; i++)
            {
                if (char.IsWhiteSpace(inputString[i - 1]) == true || inputString.Substring(i, 1) == ",")
                {
                    if (char.IsLetterOrDigit(inputString[i]) == true || char.IsPunctuation(inputString[i]))
                    {
                        c++;
                    }
                }
            }
            if (inputString.Length > 2)
            {
                c++;
            }
            return c;
        }
    }
}
