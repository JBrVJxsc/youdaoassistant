
using System;
namespace YouDaoAssistant
{
    public class Word : IComparable
    {
        public string WordName
        {
            get;
            set;
        }

        public string Meaning
        {
            get;
            set;
        }

        public int CompareTo(object obj)
        {
            Word word = obj as Word;
            return string.CompareOrdinal(WordName, word.WordName);
        }
    }
}
