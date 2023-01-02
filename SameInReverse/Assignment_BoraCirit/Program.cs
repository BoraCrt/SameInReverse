string readPath = @"C:\SameInReverse.txt";
string writePath = @"C:\SameInReverseFound.txt";
string text = File.ReadAllText(readPath);
string longestPalindromicWord = String.Empty;

string Reverse(string text)
{
    char[] charArray = text.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


for (int i = 0; i <= text.Length - 3; i++)
{
    for (int j = text.Length - 1; j >= i + 2; j--)
    {
        //Şu an sorgulayacağı uzunluk 
        int length = j - i + 1;
        // Şu an sorgulayacağı uzunluk daha önce bulunmuş uzunluktan kısaysa yapma
        if (longestPalindromicWord.Length < length)
        {
            string complexText = text.Substring(i, length);

            //Sorgulanan complexText'in tersi aynı mı ?  
            if (complexText.Equals(Reverse(complexText)))
            {
                longestPalindromicWord = complexText;
                //i sabit iken herhangi bir j' de bir tane  palindrom bulmuşsa bir sonraki(daha düşük j değeri) için dönmeye gerek yok.
                break;
            }
        }
    }
}

Console.WriteLine("Longest Palindromic Word İn SameInReverse.txt : " + longestPalindromicWord);
File.WriteAllText(writePath, longestPalindromicWord);
Console.WriteLine("The Longest Palindromic Word Availiable in SameInReverseFound.txt");




