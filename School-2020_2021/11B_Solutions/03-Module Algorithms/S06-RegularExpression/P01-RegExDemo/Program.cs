﻿using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"[0-9]+";
        string input = input2; 
        RegexOptions options = RegexOptions.Multiline;

        //връща списък от съвпадения
        MatchCollection matches = Regex.Matches(input, pattern, options);

        foreach (Match m in matches)
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }

    public static string input2 = @"От днес за 10 дни в 156 цялата страна 263555влиза в сила трето затваряне с цел ограничаване разпространението на коронавируса. Преустановяват се присъствените учебни занятия в училищата, яслите и детските градини. Затварят се ресторантите, моловете, кината и театрите. 

Работа преустановяват игралните зали, казината и търговските площи на 300 квадратни метра с изключение на хранителните супермаркети. Ресторантите ще могат да работят само за доставки и вземане на храна за дома и офиса. Мерките включват още задължително еднопосочно движение на всички пазари в страната. Затварят се фитнеси, плувни комплекси, музеите и танцовите школи. Забраняват се сватби и кръщенета с над 15 души. Висшите училища също преустановяват учебните занятия с изключение на практически упражнения по клинични дисциплини.

Главният държавен здравен инспектор доцент Ангел Кунчев коментира, че наблюденията в други европейски държави показват че последният пик на заболеваемостта от Covid-19 е с продължителност между две и четири седмици: ""10 дни не е малък срок, очевидно намаляването на контактите, ще окаже влияние но дали ще е достатъчно, това вече ми е трудно да кажа. Едно намаляване на контактите в този момент би трябвало да повлияе.""

В София отворени остават две  детски градини за деца на медици на първа линия -  117-а детска градина ""Надежда"" в район ""Младост"" и 124-та ""Бърборино"" в район ""Красно село"".";
}
