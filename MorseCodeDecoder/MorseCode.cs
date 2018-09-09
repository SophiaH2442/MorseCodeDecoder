using System;
using System.Text;

namespace MorseCodeDecoder
{
    public class MorseCode 
    {
        public MorseCode()
        {
        }

        public string Decoder(string input)
        {
            StringBuilder characterCodeString = new StringBuilder();
            MorseCodeLibrary dictionary = new MorseCodeLibrary();
            
            string[] words = input.Trim().Split(new[] { "   " }, StringSplitOptions.None);
            foreach (var word in words)
            {
                string[] characters = word.Trim().Split(' ');
                foreach (string character in characters)
                {
                    if (character == "")
                    {
                        characterCodeString.Append(" ");
                    }
                    else
                    {
                        dictionary.morseCodeDictionary.TryGetValue(character, out string value);
                        characterCodeString.Append(value);
                    } 
                }
            }
            return (characterCodeString.ToString().TrimEnd());
        }
    }
}
