
using Learn;

//------------- This is example for Removing Vowels --------------------
//string name = "Some Name with vowels";
//string noVowelName = Vowels.RemoveVowels(name);
//Console.WriteLine(noVowelName);
//----------------------------------------------------------------------

//------- Print last k-digits ------------------------------------
//int[] a = { 22, 31, 44, 27, 37, 43 };
//int k = 2;
//int n = a.Length;
//int lastK = FindLastKDigits.lastKDigits(a, n, k);
//Console.WriteLine(lastK);
//----------------------------------------------------------------

//------- Print Max Occurring Char ------------------------------------
//string sentence = "cthis is max ocuring char based of count and sequence of sttt";
//char maxChar = MaxOccurringChar.FindFirstOccuranceOfMaxOccurringChar(sentence);
//Console.WriteLine(maxChar);
//----------------------------------------------------------------

//Console.ReadLine();
//-------- Baseball Game -----------------------------------------
char[] space = new char[] { ' ' };
string input = Console.ReadLine();
int output;
if (input != null)
{
    string[] ops = input.Split(space);
    output = BaseballSolution.calPoints(ops);
    Console.WriteLine(output);
}
//----------------------------------------------------------------