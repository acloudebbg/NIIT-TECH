using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCDictionary
{
    public class LanguageDictionary : ILanguageDictionary
    {
        private Dictionary<string, string> list;

        public LanguageDictionary(Dictionary<string, string> list)
        {
            this.list = list;
        }
		
		public bool Check(string language, string word)
        {
			if (list.Any(i => i.Key == language && i.Value == word))
			{
				return true;
			}

			return false;
		}

        public bool Add(string language, string word)
        {
			/* for consistency we could call the method "check" so we have a clear view of what the method does
			 * 
			 * 	if it doesn't exist in the current list we add it, otherwise we do nothing */

			if (this.Check(language, word))
			{
				return false;
			}
			else
			{
				list.Add(language, word);
				return true;
			}
        }

        public IEnumerable<string> Search(string word)
        {
            // The method expect to search in all keys and values
            throw new NotImplementedException();
        }
    }
}
