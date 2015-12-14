using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENITITY
{
    class WORDS
    {
        private int word_id;
        private string word;
        private string category;
        private string mean;
        private string phonetic;
        private string sentence;

        public string Word
        {
            get
            {
                return word;
            }

            set
            {
                word = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Mean
        {
            get
            {
                return mean;
            }

            set
            {
                mean = value;
            }
        }

        public string Phonetic
        {
            get
            {
                return phonetic;
            }

            set
            {
                phonetic = value;
            }
        }

        public string Sentence
        {
            get
            {
                return sentence;
            }

            set
            {
                sentence = value;
            }
        }

        public int Word_id
        {
            get
            {
                return word_id;
            }

            set
            {
                word_id = value;
            }
        }
        public WORDS(int _word_id,string _word,string _category,string _phonetic,string _mean, string _sentence)
        {
            this.word_id = _word_id;
            this.word = _word;
            this.category = _category;
            this.phonetic = _phonetic;
            this.mean = _mean;
            this.sentence = _sentence;
        }
    }
}
