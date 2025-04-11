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
        // "IX" = 9
        // "IV" = 4
        // "III" = 3
        
        
        for (int i = 0; i < number.Length; i++)
        {
            // символ справа больше символа слева, значит число составное
            if ((i + 1) < number.Length && (i + 1) > i)
            {
                var romanToParse = string.Concat(i, (i + 1));
                
            }

            // символ справа такой же 
            if ((i + 1) < number.Length && (i + 1) = i)
            {
                
            }
            
        }
        
        int result = 0;
    };
}