using System;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        string pattern = @"[А-Я][а-я]+";
        string input = @"Отвъд популярните обещания за динамичен екип, атрактивно възнаграждение и широк пакет допълнителни придобивки, каквито със сигурност имаме, за нас е по-важно как нашите колеги виждат и оценяват преживяването си в А1 България. Затова даваме думата на тях:
А1 е водещ доставчик на дигитални услуги и телекомуникационни решения с повече от 25-годишна история в България. Ние предоставяме мобилни и фиксирани услуги, високоскоростен интернет, цифрова и сателитна телевизия, включително четири собствени спортни канала – MAX Sport и платежни услуги. На нашите ...
ул Кукуш 1
1309 София
map Виж на картата";
        RegexOptions options = RegexOptions.Multiline;
        MatchCollection r = Regex.Matches(input, pattern, options);
        
        foreach (Match m in r)
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}

