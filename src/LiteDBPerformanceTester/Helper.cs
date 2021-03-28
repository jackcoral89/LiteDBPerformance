using LiteDB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteDBPerformanceTester
{
    static class Helper
    {
        public static void Run(this ILiteDBTest test, string name, Action action)
        {
            var sw = new Stopwatch();

            sw.Start();
            action();
            sw.Stop();

            var time = sw.ElapsedMilliseconds.ToString().PadLeft(5, ' ');
            var seg = Math.Round(test.Count / sw.Elapsed.TotalSeconds).ToString().PadLeft(8, ' ');

            Console.WriteLine(name.PadRight(15, ' ') + ": " +
                              time + " ms - " +
                              seg + " records/second");
        }

        public static IEnumerable<TestDoc> GetDocs(int count)
        {
            for (var i = 0; i < count; i++)
            {
                yield return new TestDoc
                {
                    Name = Guid.NewGuid().ToString(),
                    LongText = LoremIpsum(3,10,2,10,5)
                };
            }
        }

        private static string LoremIpsum(int minWords, int maxWords, int minSentences, int maxSentences,
            int numParagraphs)
        {
            var words = new[]
            {
                "lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
                "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
                "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"
            };

            var rand = new Random(DateTime.Now.Millisecond);
            var numSentences = rand.Next(maxSentences - minSentences) + minSentences + 1;
            var numWords = rand.Next(maxWords - minWords) + minWords + 1;

            var result = new StringBuilder();

            for (int p = 0; p < numParagraphs; p++)
            {
                for (int s = 0; s < numSentences; s++)
                {
                    for (int w = 0; w < numWords; w++)
                    {
                        if (w > 0)
                        {
                            result.Append(" ");
                        }

                        result.Append(words[rand.Next(words.Length)]);
                    }

                    result.Append(". ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        public class TestDoc
        {
            public int Id { get; set; }
            
            public string Name { get; set; }
            
            public string LongText { get; set; }
        }
    }
}