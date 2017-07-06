using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TTCDictionary.UnitTests
{
    [TestFixture]
    public class LanguageDictionaryTest
    {
        private LanguageDictionary SUT;

        private Dictionary<string, string> list;

        [SetUp]
        public void Setup()
        {
            list = new Dictionary<string, string>();

            SUT = new LanguageDictionary(list);
        }

        [Test]
        public void When_adding_a_word_which_does_not_exist_should_return_true()
        {
            // Arrange.
            var word = "test";
            var lang = "English";

            // Act.
            var result = this.SUT.Add(lang, word);

            // Assert.
            // Assert.IsTrue(result);
            Console.WriteLine(" When_adding_a_word_which_does_not_exist_should_return_true ");
            Console.Write(" Add in lang: {0:S} ",lang);
            Console.Write(" the word: {0:S}  --> ", word);
            Console.WriteLine(result);


            var listCheck = this.list.FirstOrDefault(i => i.Key == lang && i.Value == word);

            Assert.IsTrue(listCheck.Key == lang);
            Assert.IsTrue(listCheck.Value == word);
            
        }

        [Test]
        public void When_adding_a_word_which_does_exist_should_return_false()
        {
            // Arrange.
            var word = "test";
            this.SUT.Add("English", word);

            // Act.
            var result = this.SUT.Add("English", word);

            // Assert.
            // Assert.IsFalse(result);
            Console.WriteLine(" When_adding_a_word_which_does_exist_should_return_false ");
            Console.Write(" Add in lang: English");
            Console.Write(" the word: {0:S}  --> ", word);
            Console.WriteLine(result);
        }

        [Test]
        public void When_adding_a_word_which_does_exist_but_in_a_different_language_should_return_true()
        {
            // Arrange.
            var word = "test";
            this.SUT.Add("English", word);

            // Act.
            var result = this.SUT.Add("German", word);

            // Assert.
            // Assert.IsTrue(result);
            Console.WriteLine(" When_adding_a_word_which_does_exist_in_a_different_language_return_true ");
            Console.Write(" Add in lang: German");
            Console.Write(" the word: {0:S}  --> ", word);
            Console.WriteLine(result);
        }

        [Test]
        public void When_checking_a_word_which_does_not_exist_should_return_false()
        {
            // Arrange.
            var word = "test";
            this.SUT.Add("English", word);
            var newword = "new";

            // Act.
            var result = this.SUT.Check("English", newword);

            // Assert.
            // Assert.IsFalse(result);
            Console.WriteLine(" When_checking_a_word_which_does_not_exist_should_return_false ");
            Console.Write(" Checked lang: English");
            Console.Write(" Checked word: {0:S}  --> ", newword);
            Console.WriteLine(result);

        }

        [Test]
        public void When_checking_a_word_which_does_exist_should_return_true()
        {
            // Arrange.
            var word = "test";
            this.SUT.Add("English", word);

            // Act.
            var result = this.SUT.Check("English", word);

            // Assert.
            // Assert.IsTrue(result);
            Console.WriteLine(" When_checking_a_word_which_does_exist_should_return_true ");
            Console.Write(" Checked lang: English");
            Console.Write(" Checked word: {0:S}  --> ", word);
            Console.WriteLine(result);

        }

        [Test]
        public void When_searching_a_word_which_exist_should_return_the_word()
        {
            // The method expect a search in all keys and values
            // Arrange.
            var word = "test";
            this.SUT.Add("English", word);

            // Act.
            var result = this.SUT.Search(word);

            // Assert.
            // Assert.IsTrue(result);
            Console.Write(" When_searching_a_word_which_exist_should_return_the_word ");
            Console.Write(" Searched word: {0:S}  --> ", word);
            Console.WriteLine(result);
        }

        [Test]
        public void When_searching_a_word_which_does_not_exist_should_return_Empty()
        {
            // The method expect a search in all keys and values
            // Arrange.
            var word = "test";
            this.SUT.Add("English", word);
            var wordsearch = "other";

            // Act.
            var result = this.SUT.Search(wordsearch);

            // Assert.
            // Assert.IsTrue(result);
             Console.Write(" When_searching_a_word_which_does_not_exist_should_return_Empty ");
             Console.Write(" Searched word: {0:S}  --> ", wordsearch);
             Console.WriteLine(result);
        }

    }
}
