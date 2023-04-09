using System.Collections.Immutable;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "        EverytHing  i neeD,    is a CuP   of       CoFFee    ";

            sentence = string.Join(" ", sentence.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));


            //StringSplitOptions.RemoveEmptyEntries  bu kod arxa arxaya gələn boşluq simvollarini (" ") silir ve parcalar arasinda 1 dene bosluq qalir

            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }
            sentence = string.Join(" ", words);

            Console.WriteLine(sentence);


        }
        
    }
}