internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Podaj tekst: ");
        string inputText = Console.ReadLine();
        Console.Write("Podaj wartość klucza: ");
        string keyInput = Console.ReadLine();
        int key;
        
        if (!int.TryParse(keyInput.Trim(), out key))
        {
            key = 0;
        }

        string encrypted = CaesarCipher.Encrypt(inputText, key);
        Console.WriteLine();
        Console.WriteLine("Tekst zaszyfrowany:");
        Console.WriteLine(encrypted);
    }

    public static class CaesarCipher
    {
        public static string Encrypt(string plain, int key)
        {
            if (plain is null) return string.Empty;
            int k = ((key % 26) + 26) % 26;

            char[] result = new char[plain.Length];
            for (int i = 0; i < plain.Length; i++)
            {
                char c = plain[i];
                if (c >= 'a' && c <= 'z')
                {
                    int offset = c - 'a';
                    int shifted = (offset + k) % 26;
                    result[i] = (char)('a' + shifted);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
    }
}