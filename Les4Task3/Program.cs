
using System.ComponentModel;

// string s1 = "hello";
// Console.WriteLine(s1);

// char[]ch_array = {'w','o','r','l','d'};
// string s2 = new String(ch_array);
// Console.WriteLine(s2);

// string s3 = new String('z',10);
// Console.WriteLine(s3);

// // считать с консоли строку состоящую из цифр и латинских букв.
// // сформировав новую строку состоящую из букв исходной строки


// string GetLettersFromString(string s)
// {
//    string letters = "";
//    foreach (char e in s)
//    {
//        if(char.IsAsciiLetter(e) == true)
//        {
//         letters = letters + e;
//        }   
//    }
//    return letters;
// }


// string str = Console.ReadLine()!;
// string rez = GetLettersFromString(str);
// System.Console.WriteLine(rez);



// считать с консоли строку состоящую из цифр и латинских букв.
// сформировать массив состоящий из цифр исходной строки
// qwe123dg456 => [1, 2, 3, 4, 5, 6]

int GetLettersFromDigits(string s)
{
   int count = default;
   string letters = "";
   foreach (char e in s)
   {     
        if (char.IsAsciiDigit(e) == true)
        {
            letters = letters + e;
            count++;
        }
   }
   //Console.WriteLine(count);
   return count;
}


Console.WriteLine("Введите строку состоящую из цифр и латинских букв");
string s = Console.ReadLine()!;
int rezult = GetLettersFromDigits(s);
Console.WriteLine(rezult);
