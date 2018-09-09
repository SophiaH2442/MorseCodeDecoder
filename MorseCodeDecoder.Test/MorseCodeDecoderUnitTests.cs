using NUnit.Framework;

namespace MorseCodeDecoder.Test
{
    [TestFixture]
    public class MorseCodeDecoderUnitTests
    {
        [Test]
        public void MorseCodeWordInput_ReturnsCorrectString()
        {
            // Arrange
            var input = "-... . .- ..- - .. ..-. ..- .-..";
            var morseCodeDecoder = new MorseCode();

            // Act
            var item = morseCodeDecoder.Decoder(input);

            // Assert
            Assert.AreEqual("BEAUTIFUL", item);
        }

        [Test]
        public void MorseCodeLetterInput_ReturnsCorrectLetter()
        {
            // Arrange
            var input = ".-..";
            var morseCodeDecoder = new MorseCode();

            // Act
            var item = morseCodeDecoder.Decoder(input);

            // Assert
            Assert.AreEqual("L", item);
        }

        [Test]
        public void MorseCodePhraseInput_ReturnsCorrectPhrase()
        {
            // Arrange
            var input = ".... --- .--  -. --- .--  -... .-. --- .-- -.  -.-. --- .--";
            var morseCodeDecoder = new MorseCode();

            // Act
            var item = morseCodeDecoder.Decoder(input);

            // Assert
            Assert.AreEqual("HOW NOW BROWN COW", item);
        }
    }
}
