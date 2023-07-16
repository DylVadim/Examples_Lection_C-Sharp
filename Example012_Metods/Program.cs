﻿// Метода виды:
// Вид 1 Ни чего не возвращают ни чего не принимают
void Method1()
{
    Console.WriteLine("Автор - Дыль Вадим");
}
//Method1(); // Вывод метода

// Вид 2 Ни чего не возвращают но могут принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg); 
}
//Method2(msg: "Текст сообщения");

void Method23(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method23("Текст сообщения", 8); 
//Method23(msg: "новый текст", count: 4); //Явное именовние аргумента переменной

//Вид 3 Что-то возвращают но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 Что-то принимают и что-то возвращают
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

     while (i < count)
     {
        result = result + text;
        i++;
     }
     return result;
}

string res = Method4(10, "qwerty ");
Console.WriteLine(res);
*/
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

     while (i < count)
     {
        result = result + text;
        i++;
     }
     return result;
}

string res = Method4(10, "qwerty ");
Console.WriteLine(res);
*/

// Цикл for
/*
string Metod4(int count, string text)
{
    string result = String.Empty;
        for (int i = 0; i<count; i++)
        {
            result = result + text;
        }
        return result;
}
string res = Metod4(10, "asdf ");
Console.WriteLine(res);
*/

// Вывод таблицы умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i*j}");
    }
    Console.WriteLine();
}
*/

// Работа с текстом
/* Дан текст. В тексте нужно все пробелы заменить чёрточками,
маленькие буквы "к" заменить большими "К",
а большие "С" маленькими "с".

Ясна ли задача? */

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '_');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText,'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText,'с','С');
Console.WriteLine(newText);
Console.WriteLine();