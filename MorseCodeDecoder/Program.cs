using System;

namespace MorseCodeDecoder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Morse Code");

            while (true)
            {
                string input = Console.ReadLine();

                if (input != null)
                {
                    var morseCodeDecoder = new MorseCode();

                    morseCodeDecoder.Decoder(input);
                    Console.WriteLine(morseCodeDecoder.Decoder(input));
                }
                else
                {
                    Console.WriteLine("Unrecognised Command");
                }

            }

        }
    }
}
