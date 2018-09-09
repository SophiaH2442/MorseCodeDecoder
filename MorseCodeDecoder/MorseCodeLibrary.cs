using System.Collections.Generic;

namespace MorseCodeDecoder
{
    public class MorseCodeLibrary
    {
        public IDictionary<string, string> morseCodeDictionary = new Dictionary<string, string>();

        public MorseCodeLibrary()
        {
            morseCodeDictionary.Add(".-", "A");
            morseCodeDictionary.Add("-...", "B");
            morseCodeDictionary.Add("-.-.", "C");
            morseCodeDictionary.Add("-..", "D");
            morseCodeDictionary.Add(".", "E");
            morseCodeDictionary.Add("..-.", "F");
            morseCodeDictionary.Add("--.", "G");
            morseCodeDictionary.Add("....", "H");
            morseCodeDictionary.Add("..", "I");
            morseCodeDictionary.Add(".---", "J");
            morseCodeDictionary.Add("-.-", "K");
            morseCodeDictionary.Add(".-..", "L");
            morseCodeDictionary.Add("--", "M");
            morseCodeDictionary.Add("-.", "N");
            morseCodeDictionary.Add("---", "O");
            morseCodeDictionary.Add(".--.", "P");
            morseCodeDictionary.Add("--.-", "Q");
            morseCodeDictionary.Add(".-.", "R");
            morseCodeDictionary.Add("...", "S");
            morseCodeDictionary.Add("-", "T");
            morseCodeDictionary.Add("..-", "U");
            morseCodeDictionary.Add("...-", "V");
            morseCodeDictionary.Add(".--", "W");
            morseCodeDictionary.Add("-..-", "X");
            morseCodeDictionary.Add("-.--", "Y");
            morseCodeDictionary.Add("--..", "Z");
            morseCodeDictionary.Add("-----", "0");
            morseCodeDictionary.Add(".----", "1");
            morseCodeDictionary.Add("..---", "2");
            morseCodeDictionary.Add("...--", "3");
            morseCodeDictionary.Add("....-", "4");
            morseCodeDictionary.Add(".....", "5");
            morseCodeDictionary.Add("-....", "6");
            morseCodeDictionary.Add("--...", "7");
            morseCodeDictionary.Add("---..", "8");
            morseCodeDictionary.Add("----.", "9");
            morseCodeDictionary.Add("...---...", "SOS");
        }
    }
}
