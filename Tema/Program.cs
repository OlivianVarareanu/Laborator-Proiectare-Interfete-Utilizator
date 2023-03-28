using System;

class Program
{
    static void Main(string[] args)
    {
        string[][] words = new string[26][];
        for (int i = 0; i < 26; i++)
        {
            words[i] = new string[0];
        }

        foreach (string arg in args)
        {
            char firstLetter = arg.ToLower()[0];
            int index = firstLetter - 'a';
            Array.Resize(ref words[index], words[index].Length + 1);
            words[index][words[index].Length - 1] = arg;
        }

        for (int i = 0; i < 26; i++)
        {
            char letter = (char)('a' + i);
            Console.WriteLine("Words starting with {0}:", letter);
            Console.WriteLine(string.Join(", ", words[i]));
        }
    }
}
