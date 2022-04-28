using System;
using static proga_2_lab_1.Interval;

namespace proga_2_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Interval a = new Interval(-4, 7);
            Interval b = new Interval(3, 9);

            Console.WriteLine("Інтервал А = (" + a.Start + ", " + a.End + ")");
            Console.WriteLine("Інтервал B = (" + b.Start + ", " + b.End + ")");
            Console.WriteLine("\n------------------\n\nДОВЖИНА:\n|А| = " + Length(a));
            Console.WriteLine("|B| = " + Length(b));

            if (IsBigger(a, b))
                Console.WriteLine("\nПОРІВНЯННЯ:\nA > B");
            else Console.WriteLine("\nПОРІВНЯННЯ:\nA < B");

            Console.WriteLine("\nЗСУВ У ПРАВО:\nA + 1 = (" + Move(a, 1).Start + ", " + Move(a, 1).End + ")");
            Console.WriteLine("\nЗСУВ У ЛІВО:\nВ - 0.5 = (" + Move(b, -0.5).Start + ", " + Move(b, -0.5).End + ")");

            Console.WriteLine("\nСТИСНЕННЯ:\nA / 2 = (" + MultiplyToNum(a, 0.5).Start + ", " + MultiplyToNum(a, 0.5).End + ")");
            Console.WriteLine("\nРОЗШИРЕННЯ:\nВ * 1.5 = (" + MultiplyToNum(b, 1.5).Start + ", " + MultiplyToNum(b, 1.5).End + ")");

            Console.WriteLine("\nСУМА:\nA + В = (" + Sum(a, b).Start + ", " + Sum(a, b).End + ")");
            Console.WriteLine("\nРІЗНИЦЯ:\nА - В = (" + Difference(a, b).Start + ", " + Difference(a, b).End + ")");

            var toJson = a.ToJson();
            a.SaveJson("aJson.json");
            Interval fromJson = Interval.FromJsonFile("aJson.json");

            Console.WriteLine("\nЗБЕРЕЖЕННЯ У JSON:\nA -> JSON: \n" + toJson);
            Console.WriteLine("\nЗЧИТУВАННЯ З ФАЙЛА JSON:\nJSON -> A = (" + fromJson.Start + ", " + fromJson.End + ")");
        }
    }
}