using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("word", "translation");
            dictionary.Add("word2", "translation2");
            if(dictionary.ContainsKey("word")){
                Console.WriteLine(dictionary["word"]);
            }

            foreach(var words in dictionary) {
                Console.WriteLine($"Key: {words.Key}  Value: {words.Value}");
                }
            Console.ReadKey();
        }
        }
    }

