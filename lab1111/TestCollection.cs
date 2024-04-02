using System.Diagnostics;
using System.Collections;
using EmojiLibrary;
using System.Collections.Generic;
using System.Reflection;

internal class TestCollection
{
    Stack<Emoji> collection1 = new Stack<Emoji>();
    Stack<string> collection2 = new Stack<string>();
    Dictionary<Emoji, Face> collection3 = new Dictionary<Emoji, Face>();
    Dictionary<string, Face> collection4 = new Dictionary<string, Face>();

    Face? first, middle, last, noexist;

    public TestCollection(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Face f = new Face();
            f.RandomInit();
            f.Name += i.ToString();
            collection1.Push(f);
            collection2.Push(f.ToString());
            collection3.Add(f.GetBase, f);
            collection4.Add(f.GetBase.ToString(), f);

            if (i == 0)
                first = (Face)f.Clone();
            if (i == length / 2)
                middle = (Face)f.Clone();
            if (i == length - 1)
                last = (Face)f.Clone();
            else
                noexist = (Face)f.Clone();
        }
    }
    public void MeasureSearchTimes()
    {
        MeasureCollection(collection1, first, middle, last, noexist);
        MeasureCollection(collection2, first.ToString(), middle.ToString(), last.ToString(), noexist.ToString());
        MeasureDictionary(collection3, first.GetBase, middle.GetBase, last.GetBase, noexist.GetBase);
        MeasureDictionary(collection4, first.GetBase.ToString(), middle.GetBase.ToString(), last.GetBase.ToString(), noexist.GetBase.ToString());
    }

    private void MeasureCollection<T>(IEnumerable<T> collection, T first, T middle, T last, T noexist)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        bool foundFirst = collection.Contains(first);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска первого элемента в стэке: {stopwatch.Elapsed}");

        stopwatch.Restart();
        bool foundMiddle = collection.Contains(middle);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска среднего элемента в стэке: {stopwatch.Elapsed}");

        stopwatch.Restart();
        bool foundLast = collection.Contains(last);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска последнего элемента в стэке: {stopwatch.Elapsed}");

        stopwatch.Restart();
        bool foundNoExist = collection.Contains(noexist);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска элемента не находящегося в стэке: {stopwatch.Elapsed}");

        Console.WriteLine();
    }

    private void MeasureDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey firstKey, TKey middleKey, TKey lastKey, TKey noexistKey)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        bool foundFirst = dictionary.ContainsKey(firstKey);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска первого элемента в dictionary: {stopwatch.Elapsed}");

        stopwatch.Restart();
        bool foundMiddle = dictionary.ContainsKey(middleKey);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска среднего элемента в dictionary: {stopwatch.Elapsed}");

        stopwatch.Restart();
        bool foundLast = dictionary.ContainsKey(lastKey);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска последнего элемента в dictionary: {stopwatch.Elapsed}");

        stopwatch.Restart();
        bool foundNoExist = dictionary.ContainsKey(noexistKey);
        stopwatch.Stop();
        Console.WriteLine($"Время поиска элемента не находящегося в dictionary: {stopwatch.Elapsed}");

        Console.WriteLine();
    }
}