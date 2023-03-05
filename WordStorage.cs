﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class WordStorage
    {
        private const string _path = "wordstorage.txt";

        public Dictionary<string, string> GetAllWords()
        {
            try
            {
                var dic = new Dictionary<string, string>();
                if (File.Exists(_path))
                {
                    foreach (var line in File.ReadAllLines(_path))
                    {
                        var words = line.Split('|');
                        if (words.Length == 2)
                        {
                            dic.Add(words[0], words[1]);
                        }
                    }
                }
                return dic;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не удалось считать файл со словарем.");
                return new Dictionary<string, string>();
            }
        }
        public void AddWord (string eng, string rus)
        {
            try
            {
                using (var writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine($"{eng}|{rus}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ну удалось добавить слово {eng} в словарь");
            }
        }
    
    }
}
