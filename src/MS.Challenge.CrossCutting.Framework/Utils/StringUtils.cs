namespace MS.Challenge.CrossCutting.Framework.Utils
{
    public static class StringUtils
    {
        public static bool ContainsDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsUpperCase(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ContainsLowerCase(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLower(value[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
