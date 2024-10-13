using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainForm form = new MainForm();
            form.Draw();
        }
    }


    class FileDescriptor
    {

        string Name;
        double size;
        string isDirectory;
        string modification;


        public FileDescriptor(string Name, double size, string isDirectory, string modification)
        {
            this.Name = Name;
            this.size = size;
            this.isDirectory = isDirectory;
            this.modification = modification;
        }
        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }
        public double getSize()
        {
            return size;
        }

        public string getIsDirectory()
        {
            return isDirectory;
        }

        public string getModification()
        {
            return modification;
        }
    }

    public class MainForm
    {

        const int max_length = 7;
        List<FileDescriptor> files = new List<FileDescriptor>()
        {
            new FileDescriptor("Ajacx", 32934, "true ", "19:23 "),
            new FileDescriptor("Sep  ", 52732, "false", "12:43 "),
            new FileDescriptor("cmd  ", 32214, "true ", "14:33 "),
            new FileDescriptor("bitma", 21374, "false", "10:23 ")
        };

        public void formating()
        {
            int mlength = 0;
            foreach (FileDescriptor fd in files)
            {

                if (fd.getName().Length > max_length)
                {
                    fd.setName(fd.getName().Substring(0, max_length) + "~ exe");
                }
                else
                {
                    fd.setName(fd.getName() + " exe");
                }

                if (mlength < fd.getName().Length)
                {
                    mlength = fd.getName().Length;
                }
            }

        }
        public void Draw()
        {
            formating();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("    ");
            string[] str1 = { "Левая", "Файл", "Диск", "Команды", "Правая" };
            for (int i = 0; i < str1.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(str1[i][0]);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(str1[i].TrimStart(str1[i][0]) + "    ");

            }
            Console.Write("                    ");
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2554");

            for (int i = 1; i < 31; i++)
            {
                if (i == 15)
                {
                    Console.Write(" C: |NC ");
                    i = 22;
                }
                if (i == 10)
                {
                    Console.Write("\u2564");
                }
                if (i == 24)
                {
                    Console.Write("\u2564");
                }
                Console.Write("\u2550");
            }
            Console.Write("\u2557");

            Console.Write("\u2554");
            for (int i = 1; i < 31; i++)
            {
                if (i == 15)
                {
                    Console.Write(" C: |NC ");
                    i = 22;
                }
                if (i == 10)
                {
                    Console.Write("\u2564");
                }
                if (i == 24)
                {
                    Console.Write("\u2564");
                }
                Console.Write("\u2550");
            }
            Console.Write("\u2557");

            Console.WriteLine();

            for (int i = 0; i < files.Count(); i++)
            {
                Console.WriteLine("\u2551" + files[i].getName() + "\u2502 " + (files[i].getSize()).ToString() + " \u2502 " + files[i].getIsDirectory() + " \u2502 " + files[i].getModification().ToString() + "\u2551" + "\u2551" + files[i].getName() + "\u2502 " + (files[i].getSize()).ToString() + " \u2502 " + files[i].getIsDirectory() + " \u2502 " + files[i].getModification().ToString() + "\u2551");
            }
            Console.Write("\u255F");
            for (int i = 1; i < 31; i++)
            {
                Console.Write("\u2500");
                if (i == 9 || i == 16 || i == 23)
                {
                    Console.Write("\u2534");
                }

            }
            Console.Write("\u2562");
            Console.Write("\u255F");
            for (int i = 1; i < 31; i++)
            {
                Console.Write("\u2500");
                if (i == 9 || i == 16 || i == 23)
                {
                    Console.Write("\u2534");
                }

            }
            Console.WriteLine("\u2562");

            Console.Write("\u2551" + ".." + "   >Каталог< 16.09.2024  13:15 " + "\u2551");
            Console.WriteLine("\u2551" + ".." + "   >Каталог< 16.09.2024  13:15 " + "\u2551");
            Console.Write("\u255A");
            for (int i = 1; i < 34; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u255D");
            Console.Write("\u255A");
            for (int i = 1; i < 34; i++)
            {
                Console.Write("\u2550");
            }
            Console.WriteLine("\u255D");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("C:/NC>_");
            string[] str2 = { "Пом", "Выз", "Чтение", "Правка", "Коп", "НовИмя", "НоваКат", "Удал-е", "Меню", "Выход" };
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(str2[i - 1] + " ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}