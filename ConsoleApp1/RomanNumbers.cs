using System.Text;

namespace ConsoleApp1;

public class RomanNumbers
{
    public static Dictionary<char, int> RomanToArabic = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},  
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public static int RomanNumberToInt(string romanNumber)
    {
        // "XI" = 11
        // "IV" = 4
        // "III" = 3

        int result = 0;
        
        
        for (int i = 0; i < romanNumber.Length; i++)
        {
            // символ справа больше символа слева, значит число составное
            if ((i + 1) < romanNumber.Length && (romanNumber[i + 1] > i))
            {
                var romanToParse = string.Concat(i, (i + 1));
                result += RomanToArabic[romanNumber[i + 1]] - RomanToArabic[romanNumber[i]];
            }
            else
            {
                result += RomanToArabic[romanNumber[i]] + RomanToArabic[romanNumber[i + 1]];
            }

            // символ справа такой же 
            if ((i + 1) < romanNumber.Length && (i + 1) = i)
            {
                
            }
            
        }
        
    }
}