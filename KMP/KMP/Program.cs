using KMP;
using System.Diagnostics;
using System.Diagnostics.Tracing;

//StringGenerator.CraftData(); //генерируем строки

var watch = new Stopwatch();
watch.Start();
for (int i = 0; i < 100; i++)
{
    string stringsPath = @"C:\Users\yar10\source\repos\FilesWithStrings.Patterns\String" + i.ToString() + ".txt";
    using (StreamReader reader = new StreamReader(stringsPath))
    {
        string word = reader.ReadLine();
        string pattern = reader.ReadLine();

        Console.WriteLine(KnuttMorrisPratt.KMP(word, pattern));
    }
}
watch.Stop();
Console.WriteLine(watch.Elapsed);
Console.WriteLine(KnuttMorrisPratt.counter);
