using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program190
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Уровень доступа (G/U/M/A): ");
            string  access = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrEmpty(access) || access.Length != 1)
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            char level = access[0];
            string actions;
            switch (level)
            {
                case 'G': actions = "Просмотр публичной информации, регистрация."; break;
                case 'U': actions = "Просмотр, комментарии, загрузка файлов, редактирование своего профиля."; break;
                case 'M': actions = "Всё для User + модерация комментариев, удаление спама, блокировка пользователей."; break;
                case 'A': actions = "Все действия + управление настройками, создание разделов, полный доступ к логам."; break;
                default:
                    Console.WriteLine("Неизвестный уровень доступа.");
                    return;
            }
            Console.WriteLine(actions);
        }
    }
}