using System.Diagnostics;
using System.Collections;
using EmojiLibrary;

internal class Program
{
    static void Main(string[] args)
    {
        //// Генерация элементов из 3 разных классов
        //Hashtable hash = new Hashtable();
        //for (int i = 0; i < 3; i++)
        //{
        //    try
        //    {
        //        Face f = new Face();
        //        f.RandomInit();
        //        Emoji emoji = new Emoji(f.Name, f.Tag);
        //        hash.Add(emoji, f);
        //    }
        //    catch (Exception e)
        //    {
        //        i--;
        //    }
        //}
        //for (int i = 3; i < 6; i++)
        //{
        //    try
        //    {
        //        Animal f = new Animal();
        //        f.RandomInit();
        //        Emoji emoji = new Emoji(f.Name, f.Tag);
        //        hash.Add(emoji, f);
        //    }
        //    catch (Exception e)
        //    {
        //        i--;
        //    }
        //}
        //for (int i = 6; i < 9; i++)
        //{
        //    try
        //    {
        //        Smiling f = new Smiling();
        //        f.RandomInit();
        //        Emoji emoji = new Emoji(f.Name, f.Tag);
        //        hash.Add(emoji, f);
        //    }
        //    catch (Exception e)
        //    {
        //        i--;
        //    }
        //}
        //// Конец генерации элементов из 3 разных классов

        //// Добавление элемента 
        //Emoji e11 = new Emoji("0", "0");
        //hash.Add(e11, new Face("0", "0", 0, "0"));
        //hash.Add(new Emoji("hi", "<hi>"), new Face("hi", "<hi>", 3, "25"));

        //// Вывод
        //foreach (var item in hash.Keys)
        //{
        //    Console.WriteLine($"Ключ: {item}, значение: {hash[item]}");
        //}
        //Console.WriteLine($"\nВ словаре {hash.Count} элементов\n");

        //hash.Remove(new Emoji("hi", "<hi>"));

        ////Вывод после удаления элемента
        //foreach (var item in hash.Keys)
        //{
        //    Console.WriteLine($"Ключ: {item}, значение: {hash[item]}");
        //}
        //Console.WriteLine($"\nВ словаре {hash.Count} элементов\n");


        ////Поиск
        //Console.WriteLine("Введите элемент для поиска: ");
        //Emoji find = new Emoji();
        //find.Init();
        //if (hash.ContainsKey(find))
        //    Console.WriteLine("Найден");
        //else Console.WriteLine("Не найден");


        //// Запрос на подсчет всех животных эмодзи
        //int count = 0;
        //foreach (DictionaryEntry item in hash)
        //{
        //    if (item.Value is Animal) { count++; }
        //}
        //Console.WriteLine($"\nВ предлагаемой коллекции найдено {count} животных эмодзи");


        //// Запрос на вывод всех улыбающихся эмодзи
        //Console.WriteLine("\nВсе улыбающиеся эмодзи из коллекции:");
        //foreach (DictionaryEntry item in hash)
        //{
        //    if (item.Value is Smiling) { Console.WriteLine(item); ; }
        //}

        //// Запрос на подсчет эмодзи с силой более 5
        //count = 0;
        //foreach (DictionaryEntry item in hash)
        //{
        //    if (item.Value is Face)
        //    {
        //        Face face = (Face)item.Value;
        //        if (face.Power > 5)
        //        {
        //            count++;
        //        }
        //    }
        //}
        //Console.WriteLine($"\nВ предлагаемой коллекции найдено {count} эмодзи с силой более 5");


        ////Клонирование
        //Hashtable cloned = (Hashtable)hash.Clone();

        //Console.WriteLine("\nКлонированная:");
        //foreach (var item in cloned.Keys)
        //{
        //    Console.WriteLine($"Ключ: {item}, значение: {cloned[item]}");
        //}

        //Console.WriteLine("\nИсходная:");
        //foreach (var item in hash.Keys)
        //{
        //    Console.WriteLine($"Ключ: {item}, значение: {hash[item]}");
        //}



        //    // Генерация элементов
        //    Queue<Emoji> que = new Queue<Emoji>();

        //    for (int i = 0; i < 9; i++)
        //    {
        //        Emoji f = new Emoji();
        //        f.RandomInit();
        //        que.Enqueue(f);
        //    }
        //    // Конец генерации элементов


        //    // Добавление элемента 
        //    Emoji e12 = new Emoji("0", "0");
        //    que.Enqueue(e12);

        //    Emoji e13 = new Emoji("2", "2");
        //    que.Enqueue(e13);


        //    foreach (Emoji e in que) { Console.WriteLine(e); }

        //    //Поиск
        //    Console.WriteLine("\nВведите элемент для поиска: ");
        //    Emoji find2 = new Emoji();
        //    find2.Init();
        //    if (que.Contains(find2))
        //        Console.WriteLine("Найден");
        //    else
        //        Console.WriteLine("Не найден");

        //    //Удаление из очереди
        //    Emoji deq = que.Dequeue();
        //    Console.WriteLine($"\nИз очереди удален {deq}");

        //    Console.WriteLine("\nОчередь после удаленного элемента: ");
        //    foreach (Emoji e in que) { Console.WriteLine(e); } // Вывод


        //    //Запрос 1
        //    int countWithTag = que.Count(e => e.Tag == "<settings>");
        //    Console.WriteLine($"\nКоличество элементов с тегом '<settings>': {countWithTag}");

        //    //Запрос 2
        //    char startingLetter = 'П';
        //    var elementsStartingWithLetter = que.Where(e => e.Name.StartsWith(startingLetter));
        //    Console.WriteLine($"\nЭлементы, начинающиеся с буквы '{startingLetter}':");
        //    foreach (var e in elementsStartingWithLetter)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    //Запрос 3
        //    string nameToCheck = "Привет";
        //    bool containsWithName = que.Any(e => e.Name == nameToCheck);
        //    if (containsWithName)
        //    {
        //        Console.WriteLine($"\nОчередь содержит элемент с именем '{nameToCheck}'");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"\nОчередь не содержит элемент с именем '{nameToCheck}'");
        //    }

        //    //Клонирование и вывод
        //    Queue<Emoji> clonedQueue = CloneQueue(que);
        //    foreach (Emoji e in clonedQueue) { Console.WriteLine(e); }



        //}
        //static Queue<T> CloneQueue<T>(Queue<T> original)
        //{
        //    // Создаем новую очередь
        //    Queue<T> cloned = new Queue<T>();

        //    // Копируем элементы из исходной очереди в клонированную
        //    foreach (T item in original)
        //    {
        //        cloned.Enqueue(item);
        //    }

        //    return cloned;
        //


        TestCollection testCollection = new TestCollection(1000);
        testCollection.MeasureSearchTimes();
    }
}
