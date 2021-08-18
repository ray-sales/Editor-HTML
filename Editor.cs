using System;
using System.Text;

namespace EditorHMTL
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITOR MODE");
            Console.WriteLine("------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (ConsoleKey.Escape != Console.ReadKey().Key);

            Console.WriteLine("-----------");
            Console.WriteLine("Do You want to save to file?");
            Viewer.Show(file.ToString());
        }
    }
}