using System;
using System.IO;

namespace Singleton.Structural
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>

    public class Program
    {
       

        public static void Main(string[] args)
        {
            LoggingServiceSingleton log = LoggingServiceSingleton.Instance;
            log.WriteToLog("Hector enters");

            Tuple<int, int>  obj = GetTwoNumbers();
            double result = GetAverage(obj.Item1, obj.Item2);
            PrintResult(result);

            log.ReadLog();
        }

        public static Tuple<int,int> GetTwoNumbers()
        {
            LoggingServiceSingleton log = LoggingServiceSingleton.Instance;



            Console.WriteLine("Give First number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Second number:");
            int b = Convert.ToInt32(Console.ReadLine());


            log.WriteToLog($"User inserts two numbers: {a} , {b}");
            return Tuple.Create(a, b);
        }

        public static double GetAverage(int a, int b)
        {
            LoggingServiceSingleton log = LoggingServiceSingleton.Instance;
            log.WriteToLog($"Average Calculation");
            return (a + (double)b) / 2;
        }

        public static void PrintResult(double average)
        {
            LoggingServiceSingleton log = LoggingServiceSingleton.Instance;
            log.WriteToLog($"Average = {average}");
            Console.WriteLine("Average is " + average);
        }



    }

    public sealed class LoggingServiceSingleton
    {
        public static LoggingServiceSingleton Instance { get; } = new LoggingServiceSingleton();
        private LoggingServiceSingleton() { }

        public void WriteToLog(string message)
        {
            string path = @"log.txt";
            string str = message + "-----" + DateTime.Now.ToString();

            if (!File.Exists(path))
            {
                File.Create(path);
                File.AppendAllLines(path, new string[] {str});
            }
            else
            {
                File.AppendAllLines(path, new string[] { str });
            }
        }

        public void ReadLog()
        {
            string path = @"log.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("No Data Exists");
            }
            else
            {
                string result = File.ReadAllText(path);
                Console.WriteLine(result);
            }
        }

    }

}

