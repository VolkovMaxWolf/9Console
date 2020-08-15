using System;
using System.IO;
using System.Linq;

namespace _9console
{
    class Program
    {
        private const String PATH = "..\\..\\..\\text.txt";
        private const String PATH2 = "..\\..\\..\\text2.txt";
        private const String PATH3 = "..\\..\\..\\text3.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку");
            String sentence = Console.ReadLine();
            FileStream f = new FileStream(PATH, FileMode.OpenOrCreate);
            BinaryWriter fOut = new BinaryWriter(f);
            char[] chArray = sentence.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!Char.IsDigit(chArray[i])) fOut.Write(chArray[i]);
            }
            fOut.Close();

            Console.WriteLine("Введите длину слов");
            int n = Convert.ToInt32(Console.ReadLine());
            FileStream fileStream = new FileStream(PATH, FileMode.OpenOrCreate);
            StreamReader sR = new StreamReader(fileStream);
            String str1 = String.Empty;
            int count = 1;
            while ((str1 = sR.ReadLine()) != null && str1 != String.Empty)
            {

                String[] arr = str1.Split(' ');

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length == n) Console.WriteLine(arr[i]);
                }

            }
            sR.Close();
            fileStream.Close();


            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите длину строк");
            int n1 = Convert.ToInt32(Console.ReadLine());
            String str2 = String.Empty;
            FileStream fileStream1 = new FileStream(PATH2, FileMode.Open);
            StreamReader sR2 = new StreamReader(fileStream1);
            while ((str2 = sR2.ReadLine()) != null && str2 != String.Empty)
            {
                if (str2.Length > n1) File.AppendAllText(PATH3, str2 + Environment.NewLine);
            }
            sR2.Close();
            fileStream1.Close();
        }
    }
}
