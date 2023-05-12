using System;
using System.Collections;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название композиции: ");
            string s = Console.ReadLine();

            // создаю новый словарь
            Hashtable index = new Hashtable()
            {
                ["Черные глаза"] = "Айдамир Мугу",
                ["Зеленоглазое такси"] = "Михаил Боярский",
                ["МАЙ МАЙ"] = "LOVV66",
                ["Не более"] = "keendy",
                ["Девушка мечты"] = "Кирилл Нефтерев",
                ["Лёд Сердце"] = "Гио Пика",
                ["Буйно голова"] = "Гио Пика",
                ["HALLOWEEN"] = "BUSHIDO ZHO",
                ["В сигаретном дыму"] = "Ислам Идигов",
                ["Нежная походка"] = "Алихан Амхадов"
            };

            if (index.ContainsKey(s))
            {
                Console.WriteLine($"Исполнитель: {index[s]}");
                // выводит исполнителя по названию композиции

                index.Remove(s);
                // удаляем

                foreach (var i in index.Keys)
                {
                    Console.WriteLine(index[i]);
                }
                // перебираем массив и выводим все элементы словаря

                index.Clear();
                // полностью удаляем содержимое словаря
            }
            else
            {
                Console.WriteLine("Такой композиции нет");
                //это сообщение выводится в консоль если ключа не существует
            }
        }
    }
}