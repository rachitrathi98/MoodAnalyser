using System;
namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");
            AnalyseMood mood = new AnalyseMood("I am in Sad mood");
            string resultMood = mood.analysemood();
            Console.WriteLine("The Mood is " + resultMood);
        }
    }
}
