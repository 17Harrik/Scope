using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static string language = "English";

        static void Main(string[] args)
        {
            
            ShowOff();
            
        }

        private static void SayHello(string language)
        {
            Console.Write($"You can say a greeting in {language} by saying ");

            switch (language)
            {
                case "English":
                    Console.WriteLine("Hello");
                    break;
                case "German":
                    Console.WriteLine("Guten tag");
                    break;
                case "French":
                    Console.WriteLine("Bonjour");
                    break;
                default:
                    Console.WriteLine("Ay up");
                    break;
            }
        }

        private static void ShowOff()
        {
            List<string> languages = new List<string>
            {
                "English", "German", "French", "Yorkshire"
            };

            foreach(string language in languages)
            {
                SayHello(language);
            }   
        }
    }
}
