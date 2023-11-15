//5.1
//char[] symbols = { 'a', 'b', 'c', '(', 'x', 'y', 'z', ')', 'd', 'e', 'f' };

//int openingIndex = -1;
//int c = -1;
//for (int i = 0; i < symbols.Length; i++)
//{
//    if (symbols[i] == '(')
//    {
//        openingIndex = i;
//    }
//    else if (symbols[i] == ')')
//    {
//        c = i;
//        break;
//    }
//}
//if (openingIndex != -1 && c != -1)
//{
//    for (int i = openingIndex + 1; i < c; i++)
//    {
//        Console.Write(symbols[i]);
//    }
//}
//else
//{
//    Console.WriteLine("Открывающаяся или закрывающаяся скобка не найдена.");
//}


//5.2 слож
string st = "Дано предложение. Напечатать все его слова, отличные от слова привет пчел!!!";
Console.WriteLine(string.Join(" ", st.Split().Where(i => i != "привет")));

