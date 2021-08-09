using System;
namespace Assginments
{
    class WordFrequency
    {
        public static void WordFrequencyCaller()
        {

            string[] stopWordsArrary = {

                "a", "about", "actually", "after", "also", "am", "an",
                "and", "any", "are", "as", "at", "be", "because", "but",
                "by", "could", "do", "each", "either", "en", "for", "from",
                "has", "have", "how","i", "if", "in", "is", "it", "its",
                "just", "of", "or", "so", "some", "such", "that","the", "their",
                "these", "thing", "this", "to", "too", "very", "was", "we",
                "well", "what", "when", "where","who", "will", "with", "you", "your",
                "@","#","$","%","&","*"
            };

            try
            {
                Console.Write("Enter the Text: ");
                var text = Console.ReadLine();
                Console.Write("\n");
                Console.Write("Enter the Word to Find the Frequency in a given Text: ");
                var word = Console.ReadLine();

                foreach (var item in stopWordsArrary)
                {
                    if (item == word)
                    {
                        Console.WriteLine("Not applicable");
                        return;
                    }
                }
                Console.Write("\n");
                Console.WriteLine($"No. of Repetitions of '{word}' word in a given sentence: { CountWordRepetition(text, word)}");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        private static int CountWordRepetition(string sentence, string word)
        {

            int count = 0;
            try
            {
                int i = 0;
                while ((i = sentence.IndexOf(word, i)) != -1)
                {
                    i += word.Length;
                    count++;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return count;
        }
    }
}
