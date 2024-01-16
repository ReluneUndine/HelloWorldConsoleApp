/* импорт пространств имен (подключение библиотек)
"using system" - чтобы не нужно было писать system в каждой строке
"using static system.console" - чтобы не нужно было писать console перед каждой командой
*/

using System;
using static System.Console;

/// <summary>
/// Пространство имен
/// Создание собственной библиотеки
/// </summary>
namespace HelloWorldConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// Код, который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)      // Точка входа, начало приложения, основа кода
        {
            WriteLine("Hello, World!!!"); // Вывод текста на экран
            ReadKey();                   // Окошко будет висеть на экране до тех пор, пока пользователь не нажмет какую-то кнопку
        }
    }
}

