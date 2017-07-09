using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCDictionary;

namespace TTCDictionaryExe
{
    class Program
    {
        static void Main(string[] args)
        {
            TTCDictionary.UnitTests.LanguageDictionaryTest TestDic = new TTCDictionary.UnitTests.LanguageDictionaryTest();
            Console.WriteLine("Setup TestDic variable ...");
            TestDic.Setup();
            Console.WriteLine("Adding scenarios...");
            TestDic.When_adding_a_word_which_does_not_exist_should_return_true();
            TestDic.When_adding_a_word_which_does_exist_should_return_false();
            TestDic.When_adding_a_word_which_does_exist_but_in_a_different_language_should_return_true();
            Console.WriteLine("Checking scenarios...");
            TestDic.When_checking_a_word_which_does_not_exist_should_return_false();
            TestDic.When_checking_a_word_which_does_exist_should_return_true();
            Console.WriteLine("Search scenarios...");
            TestDic.When_searching_a_word_which_exist_in_Words_should_return_the_word();
            TestDic.When_searching_a_word_which_exist_in_Language_should_return_the_word();
            TestDic.When_searching_a_word_which_does_not_exist_should_return_Empty();
            Console.Read();
        }
    }
}
