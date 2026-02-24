Console.WriteLine("Введите строку");
string s = Console.ReadLine();


char p = ' ';
int count = 0;

for (int i = 0; i < s.Length - 1; i++)
{
    if (s[i] == s[i + 1] && s[i] != p && s[i + 1] != p)
    {
        count++;
    }
}
Console.WriteLine(count);