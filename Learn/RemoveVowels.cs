using Learn.Services;

namespace Learn
{
    public static class Vowels//: ICar
    {
        public static string RemoveVowels(string name)
        {
            string vowels = "aeiou";
            //string name = "Some Name with vowels";

            return new string(name.Where(c => !c.IsVowel()).ToArray());
        }
        public static bool IsVowel(this char c)
        {
            return new[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' }.Contains(c);
        }
    }
}
