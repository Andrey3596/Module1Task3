namespace task3
{

    public class Logic // класс где будем хранить логику
    {
        public static int СountIdenticalLetters(string s)
        {
            char p = ' ';
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1] && s[i] != p && s[i + 1] != p)
                {
                    count++;
                }
            }
            return count;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            Console.WriteLine(Logic.СountIdenticalLetters(s));
        }
    }


}