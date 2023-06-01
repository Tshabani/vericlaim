using System; 

namespace vericlaim
{
    public static class StringExtension 
    { 
        public static string ReverseWords(this string line)
        {
            string[] words = line.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
