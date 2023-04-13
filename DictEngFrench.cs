﻿namespace DZ_CS_11
{
    static internal class DictEngFrench
    {
        static private string? eng = null;

        static public List<string> frenchTranslations = new();

        static Dictionary<string, List<string>> Translations = new();

        static public void AddWord()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the word in English:\t");
            Console.ResetColor();
            eng = Console.ReadLine();

            bool correct = false;
            if (eng != null)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter the translation:\t");
                    Console.ResetColor();
                    string? translate = Console.ReadLine();

                    if (translate != null)
                        frenchTranslations.Add(translate);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Add one more translate variant?\n1. Yes\n2. No ");
                    Console.ResetColor();
                    int confirm = Convert.ToInt32(Console.ReadLine());

                    if (confirm == 1)
                        correct = true;
                    else if (confirm == 2)
                        correct = false;
                } while (correct);

                Translations.Add(eng, frenchTranslations);
                eng = null;
                frenchTranslations = new();
            }
            Console.Clear();
        }

        static public void RemoveWordFromDict()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the word what you want remove:");
            Console.ResetColor();
            string? input = Console.ReadLine();

            if (input != null)
                foreach (var item in Translations)
                    if (item.Key.ToLower() == input.ToLower())
                        Translations.Remove(item.Key);
            Console.Clear();
        }

        static public void RemoveWordFromTranslation()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the word for which you want to remove the translation:");
            Console.ResetColor();
            string? input = Console.ReadLine();

            if (input != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter the translation word to remove:");
                Console.ResetColor();
                string? wordToRemove = Console.ReadLine();

                if (wordToRemove != null)
                    foreach (var item in Translations)
                        if (item.Value.Contains(wordToRemove) && item.Key.ToLower() == input.ToLower())
                            item.Value.Remove(wordToRemove);
                        else
                            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Translation don't have inputed value!!!");
                Console.ResetColor();
                Console.Clear();
            }
        }

        static public void ChangeEngWord()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter English word which you want to change the translation:");
            Console.ResetColor();
            string? input = Console.ReadLine();

            if (input != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter word to change:");
                Console.ResetColor();
                string? wordToChange = Console.ReadLine();
                if (wordToChange != null)
                {
                    KeyValuePair<string, List<string>> pair = new(wordToChange, Translations[input]);
                    Translations[input.Replace(input, wordToChange)] = pair.Value;
                    Translations.Remove(input);
                }
            }
            Console.Clear();
        }

        static public void ChangeFrenchWord()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter in what translate word need change translation:");
            Console.ResetColor();
            string? input = Console.ReadLine();
            if (input != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter what french word must be changed:");
                Console.ResetColor();
                string? wordWhatChange = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter word on change:");
                Console.ResetColor();
                string? wordToChange = Console.ReadLine();

                if (wordWhatChange != null && wordToChange != null)
                {
                    Translations[input].Remove(wordWhatChange);
                    Translations[input].Add(wordToChange);
                }
            }
            Console.Clear();
        }

        static public void SearchTranslate()
        {
            Console.WriteLine("Enter word to search");
            string? input = Console.ReadLine();
            if (input != null)
            {
                foreach (var item in Translations)
                    if (item.Key.ToLower() == input.ToLower() || item.Value.Contains(input))
                    {
                        Console.WriteLine("Searched word:");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"English:\t{item.Key}");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("French:\t ");

                        foreach (var item1 in item.Value)
                            Console.Write(item1 + " | ");
                    }
                Console.ResetColor();
            }
        }

        static public void ShowDict()
        {
            foreach (var item in Translations)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"English: {item.Key}");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("French:\t ");

                foreach (var item1 in item.Value)
                    Console.Write(item1 + " | ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
