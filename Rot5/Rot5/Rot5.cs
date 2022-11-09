namespace Rot5Crypto
{
    public static class Rot5
    {
        static Rot5()
        {
        }


        public static string Encrypt(string original)
        {
            StringBuilder sb = new();

            foreach(char currentCharacter in original.ToCharArray())
            {
                sb.Append(char.IsDigit(currentCharacter) ? EncryptDigit(int.Parse(currentCharacter.ToString())) : currentCharacter);
            }

            return sb.ToString();
        }

        private static string EncryptDigit(int digitToEncrypt)
        {
            return ((digitToEncrypt < 5) ? digitToEncrypt + 5 : digitToEncrypt - 5).ToString();
        }
    }
}