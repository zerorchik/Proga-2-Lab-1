using Newtonsoft.Json;
using System;
using System.IO;

namespace proga_2_lab_1
{
    public class Interval
    {
        private double _start;
        private double _end;

        public double Start { get { return _start; } }
        public double End { get { return _end; } }

        public Interval(double start, double end)
        {
            if (start > end)
            {
                _start = end;
                _end = start;
            }
            else
            {
                _start = start;
                _end = end;
            }
        }

        public static double Length(Interval interval)
        {
            return interval.End - interval.Start;
        }

        public static Interval Move(Interval interval, double a)
        {
            return new Interval(interval.Start + a, interval.End + a);
        }

        public static Interval MultiplyToNum(Interval interval, double a)
        {
            return new Interval(interval.Start * a, interval.End * a);
        }

        public static Interval Sum(Interval interval1, Interval interval2)
        {
            return new Interval(interval1.Start + interval2.Start, interval1.End + interval2.End);
        }

        public static Interval Difference(Interval interval1, Interval interval2)
        {
            return new Interval(interval1.Start - interval2.Start, interval1.End - interval2.End);
        }

        public static bool IsBigger(Interval interval1, Interval interval2)
        {
            if (Length(interval1) > Length(interval2))
                return true;
            else return false;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void SaveJson(string filePath)
        {
            File.WriteAllText(filePath, ToJson());
        }

        public static Interval FromJsonFile(string filepath)
        {
            return JsonConvert.DeserializeObject<Interval>(File.ReadAllText(filepath));
        }
    }
}
