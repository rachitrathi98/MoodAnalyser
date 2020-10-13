using System;
namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");
            //AnalyseMood mood = new AnalyseMood("I am in Sad mood");
            //Console.WriteLine(mood.Analysemood());
            // MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser.AnalyseMood", "AnalyseMood");
            //MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("MoodAnalyser.AnalyseMood", "AnalyseMood", "happy");
            MoodAnalyserFactory.InvokeAnalyserMethod("happy", "Analysemood");
        }
    }
}
