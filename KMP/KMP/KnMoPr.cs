using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    public class KnuttMorrisPratt
    {
        public static int counter { get; set; }
        public static int KMP(string text, string pattern)
        {
            int include = -1;
            counter = 1;
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(text) || pattern.Length > text.Length)
                throw new Exception();

            int[] prefix = PrefFunc(pattern);
            int i = 0; //индекс текста
            int j = 0; //pattern index

            while (i < text.Length)
            {
                if (text[i] == pattern[j])
                {
                    i++;
                    j++;
                    counter += 2;
                }

                if (j == pattern.Length)
                {
                    include = i - j; // Найдено вхождение
                    j = prefix[j - 1]; // Сдвигаем паттерн
                    counter += 2;
                }
                else if (i < text.Length && text[i] != pattern[j])
                {
                    if (j != 0)
                    {
                        j = prefix[j - 1]; counter++; // Откатываем j
                    }
                    else
                        i++; counter++; // Переходим к следующему символу в тексте
                }
            }
            return include;
        }
        public static int[] PrefFunc(string pattern)
        {
            int[] prefix = new int[pattern.Length];
            int maxPrefLen = 0;
            counter = 2;
            for (int i = 1; i < pattern.Length; i++)
            {
                while (maxPrefLen > 0 && pattern[i] != pattern[maxPrefLen])
                    maxPrefLen = prefix[maxPrefLen - 1]; counter++;

                if (pattern[i] == pattern[maxPrefLen])
                    maxPrefLen++; counter++;

                prefix[i] = maxPrefLen;
            }
            return prefix;
        }
    }
}
