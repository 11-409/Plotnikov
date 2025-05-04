using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    class StringGenerator
    {
        public static void CraftData()
        {
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                var filePath = @"C:\Users\yar10\source\repos\FilesWithStrings.Patterns\String" + i.ToString() + ".txt";
                string alphabet = "abcdefghijklmnopqrstuvwxyz";
                int lengthString = random.Next(100, 10001);
                int lengthPattern = random.Next(15, Math.Min(1001, lengthString));
                bool shouldPatternExist = random.Next(2) == 0;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    StringBuilder sbString = new StringBuilder(lengthString);
                    StringBuilder sbPattern = new StringBuilder(lengthPattern);
                    for (int k = 0; k < lengthString; k++)
                    {
                        sbString.Append(alphabet[random.Next(alphabet.Length)]);
                    }
                    for (int m = 0; m < lengthPattern; m++)
                    {
                        sbPattern.Append(alphabet[random.Next(alphabet.Length)]);
                    }
                    string finalString = sbString.ToString();
                    string finalPattern = sbPattern.ToString();
                    if (shouldPatternExist)
                    {
                        int insertPos = random.Next(0, lengthString - lengthPattern + 1);
                        finalPattern = finalString.Substring(insertPos, random.Next(lengthPattern));
                    }
                    writer.WriteLine(finalString);
                    writer.WriteLine(finalPattern);
                }
            }
        }
    }
}
